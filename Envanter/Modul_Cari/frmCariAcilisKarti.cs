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

namespace Envanter.Modul_Cari
{
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        bool Edit = false;
        int CariID = -1;

        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = Numara.CariKodNumarası();
        }

        void KurumListele(int cariID)
        {
            var srg = from s in DB.Kurumlars
                      where s.CariID == cariID
                      select s;

            foreach (Fonksiyonlar.Kurumlar item in srg)
            {
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("ID", item.ID);
                gridView1.SetFocusedRowCellValue("KurumAdi", item.KurumAdi);
                gridView1.SetFocusedRowCellValue("Sehir", item.Sehir);
                gridView1.UpdateCurrentRow();
            }
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";

            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);
            }

            txtCariKodu.Text = Numara.CariKodNumarası();
            Edit = false;
            CariID = -1;
            MainForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Cariler Cari = new Fonksiyonlar.Cariler();
                Cari.Adres = txtAdres.Text;
                Cari.CariAdi = txtCariAdi.Text;
                Cari.CariKodu = txtCariKodu.Text;
                Cari.Email = txtEmail.Text;
                Cari.Fax = txtFax.Text;
                Cari.Ilce = txtIlce.Text;
                Cari.Sehir = txtSehir.Text;
                Cari.Telefon = txtTelefon.Text;
                Cari.Ulke = txtUlke.Text;
                Cari.VergiDairesi = txtVergiDairesi.Text;
                Cari.VergiNo = txtVergiNo.Text;
                Cari.WebAdres = txtWebAdres.Text;
                Cari.Yetkili = txtYetkili.Text;
                Cari.YetkiliEmail = txtYetkiliEmail.Text;
                Cari.SaveDate = DateTime.Now;
                Cari.SaveUser = MainForm.UserID;
                DB.Carilers.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni cari kaydı oluşturulmuştur!");
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
                Fonksiyonlar.Cariler Cari = DB.Carilers.First(s => s.ID == CariID);
                Cari.Adres = txtAdres.Text;
                Cari.CariAdi = txtCariAdi.Text;
                Cari.CariKodu = txtCariKodu.Text;
                Cari.Email = txtEmail.Text;
                Cari.Fax = txtFax.Text;
                Cari.Ilce = txtIlce.Text;
                Cari.Sehir = txtSehir.Text;
                Cari.Telefon = txtTelefon.Text;
                Cari.Ulke = txtUlke.Text;
                Cari.VergiDairesi = txtVergiDairesi.Text;
                Cari.VergiNo = txtVergiNo.Text;
                Cari.WebAdres = txtWebAdres.Text;
                Cari.Yetkili = txtYetkili.Text;
                Cari.YetkiliEmail = txtYetkiliEmail.Text;
                Cari.EditDate = DateTime.Now;
                Cari.EditUser = MainForm.UserID;
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
                DB.Carilers.DeleteOnSubmit(DB.Carilers.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        void Ac(int ID)
        {
            try
            {
                Temizle();
                Edit = true;
                CariID = ID;
                Fonksiyonlar.Cariler cari = DB.Carilers.First(s => s.ID == CariID);
                txtAdres.Text = cari.Adres;
                txtCariAdi.Text = cari.CariAdi;
                txtCariKodu.Text = cari.CariKodu;
                txtEmail.Text = cari.Email;
                txtFax.Text = cari.Fax;
                txtIlce.Text = cari.Ilce;
                txtSehir.Text = cari.Sehir;
                txtTelefon.Text = cari.Telefon;
                txtUlke.Text = cari.Ulke;
                txtVergiDairesi.Text = cari.VergiDairesi;
                txtVergiNo.Text = cari.VergiNo;
                txtWebAdres.Text = cari.WebAdres;
                txtYetkili.Text = cari.Yetkili;
                txtYetkiliEmail.Text = cari.YetkiliEmail;
                KurumListele(CariID);
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!(CariID > 0)) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            MainForm.Aktarma = -1;
        }
    }
}