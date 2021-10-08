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

namespace Envanter.Modul_Stok
{
    public partial class frmDepoTanimlama : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        public bool depoSec = false;
        bool Edit = false;
        int DepoID = -1;

        public frmDepoTanimlama()
        {
            InitializeComponent();
            txtDepoAdi.Select();
        }

        private void frmDepoTanimlama_Load(object sender, EventArgs e)
        {
            Listele();
            if (depoSec)
            {
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
        }


        void Listele()
        {
            txtDepoKodu.Text = Numara.DepoKodNumarası().ToString();

            var qr = from s in DB.Depolars
                     where s.DepoAdi.Contains(txtDepoAdi.Text.ToLower())
                     select s;

            grdMain.DataSource = qr.ToList();
        }

        void Temizle()
        {
            txtDepoAdi.Text = "";
            txtDepoKodu.Text = "";
            DepoID = -1;
            depoSec = false;
            Edit = false;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Depolar depo = new Fonksiyonlar.Depolar();
                depo.DepoAdi = txtDepoAdi.Text;
                depo.SaveDate = DateTime.Now;
                depo.SaveUser = MainForm.UserID;
                DB.Depolars.InsertOnSubmit(depo);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni depo tanımlaması yapılmıştır!");
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.Depolar depo = DB.Depolars.First(s => s.ID == DepoID);
                depo.DepoAdi = txtDepoAdi.Text;
                depo.EditDate = DateTime.Now;
                depo.EditUser = MainForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Sil()
        {
            try
            {
                DB.Depolars.DeleteOnSubmit(DB.Depolars.First(s => s.ID == DepoID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                DepoID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtDepoAdi.Text = gridView1.GetFocusedRowCellValue("DepoAdi").ToString();
                txtDepoKodu.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            }
            catch (Exception)
            {
                DepoID = -1;
                Edit = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && DepoID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!(DepoID > 0)) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && DepoID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdMain_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (depoSec && DepoID > 0)
            {
                MainForm.Aktarma = DepoID;
                this.Close();
            }
        }

        private void txtDepoAdi_EditValueChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}