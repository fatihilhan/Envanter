using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Envanter.Modul_Stok
{
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;


        public frmStokGruplari()
        {
            InitializeComponent();
            txtGrupAdi.Select();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.StokGruplaris
                      where s.GrupAdi.Contains(txtGrupAdi.Text.ToLower())
                      select s;

            grdMain.DataSource = lst;
            txtGrupKodu.Text = Numara.StokGrupKodNumarası().ToString();
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.StokGruplari Grup = new Fonksiyonlar.StokGruplari();
                Grup.GrupAdi = txtGrupAdi.Text;
                Grup.SaveDate = DateTime.Now;
                Grup.SaveUser = MainForm.UserID;
                DB.StokGruplaris.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.StokGruplari Grup = DB.StokGruplaris.First(s => s.ID == SecimID);
                Grup.GrupAdi = txtGrupAdi.Text;
                Grup.EditUser = MainForm.UserID;
                Grup.EditDate = DateTime.Now;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }

        void Sil()
        {
            try
            {
                DB.StokGruplaris.DeleteOnSubmit(DB.StokGruplaris.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (SqlException)
            {
                MessageBox.Show("Silmek istediğiniz gruba bağlı kayıtlar bulunmaktadır.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GrupAdi").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!(SecimID > 0)) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                MainForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void txtGrupAdi_EditValueChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}