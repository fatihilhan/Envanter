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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Envanter.Modul_Stok
{
    public partial class frmStokKartlari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        #region Variables

        bool Edit = false;
        public bool Secim = false;
        int StokKartID = -1;
        int GrupID = -1;

        #endregion

        #region Constructors
        public frmStokKartlari()
        {
            InitializeComponent();
        }

        private void frmStokKartlari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        #endregion

        #region Methods

        void Listele()
        {
            var lst = from s in DB.StokKartlaris
                      join p in DB.StokGruplaris on s.GrupID equals p.ID into ps
                      from p in ps.DefaultIfEmpty()

                      select new
                      {
                          ID = s.ID,
                          KartAdi = s.StokAdi,
                          GrupAdi = p.GrupAdi
                      };

            grdMain.DataSource = lst;
            txtKartAdi.Select();
            txtKartKodu.Text = Numara.StokKartNumarası().ToString();
        }

        void Ara()
        {
            var qr = from s in DB.StokKartlaris
                     join p in DB.StokGruplaris on s.GrupID equals p.ID into ps
                     from p in ps.DefaultIfEmpty()
                     where s.StokAdi.Contains(txtKartAdi.Text.ToLower())

                     select new
                     {
                         ID = s.ID,
                         KartAdi = s.StokAdi,
                         GrupAdi = p.GrupAdi
                     };

            grdMain.DataSource = qr;
        }

        void Temizle()
        {
            txtKartKodu.Text = "";
            txtKartAdi.Text = "";
            txtGrupAdi.Text = "";
            StokKartID = -1;
            GrupID = -1;
            Edit = false;
            MainForm.Aktarma = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.StokKartlari stokKarti = new Fonksiyonlar.StokKartlari();
                stokKarti.StokAdi = txtKartAdi.Text;
                stokKarti.GrupID = GrupID;
                stokKarti.SaveDate = DateTime.Now;
                stokKarti.SaveUser = MainForm.UserID;
                DB.StokKartlaris.InsertOnSubmit(stokKarti);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni stok kartı oluşturuldu!");
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
                Fonksiyonlar.StokKartlari stokKarti = DB.StokKartlaris.First(s => s.ID == StokKartID);
                stokKarti.StokAdi = txtKartAdi.Text;
                stokKarti.GrupID = GrupID;
                stokKarti.SaveDate = DateTime.Now;
                stokKarti.SaveUser = MainForm.UserID;
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
                DB.StokKartlaris.DeleteOnSubmit(DB.StokKartlaris.First(s => s.ID == StokKartID));
                DB.SubmitChanges();
                Temizle();
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
                StokKartID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                Fonksiyonlar.StokKartlari stok = DB.StokKartlaris.First(s => s.ID == StokKartID);
                Ac(stok.GrupID.Value);
                txtKartKodu.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtKartAdi.Text = gridView1.GetFocusedRowCellValue("KartAdi").ToString();
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GrupAdi").ToString();
            }
            catch (Exception ex)
            {
                Edit = false;
                StokKartID = -1;
                MessageBox.Show(ex.Message);
            }
        }

        public void Ac(int ID)
        {
            Edit = true;
            GrupID = ID;
            txtGrupAdi.Text = DB.StokGruplaris.First(s => s.ID == GrupID).GrupAdi;
        }

        #endregion

        #region Events

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!Secim)
            {
                if (Edit && StokKartID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
                {
                    Guncelle();
                }
                else
                {
                    YeniKaydet();
                }
            }
            if (Secim && gridView1.RowCount > 0)    // Seçim için açılırsa ve enter ile hızlıca seçim yapabilmek için
            {
                Sec();
                if (StokKartID > 0)
                {
                    MainForm.Aktarma = StokKartID;
                    this.Close();
                }
            }
            else if (Secim && gridView1.RowCount == 0)  // Seçim için açılırsa ama yeni kart eklemek istiyorsam bunu çalıştırır
                YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokKartID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo hitInfo = gridView1.CalcHitInfo((e as MouseEventArgs).Location); //grup satirina tikli degilse ifadeyi calistir

            if (!hitInfo.InGroupRow)
            {
                Sec();
            }

            if (Secim && StokKartID > 0)
            {
                MainForm.Aktarma = StokKartID;
                this.Close();
            }
        }

        private void txtGrupAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGruplari(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            MainForm.Aktarma = -1;
        }

        private void txtKartAdi_EditValueChanged(object sender, EventArgs e)
        {
            Ara();
        }

        #endregion

    }
}