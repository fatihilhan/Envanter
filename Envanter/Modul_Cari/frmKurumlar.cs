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
using DevExpress.XtraPrinting.Native;

namespace Envanter.Modul_Cari
{
    public partial class frmKurumlar : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        bool Edit = false;
        int KurumID = -1;
        int CariID = -1;

        public frmKurumlar()
        {
            InitializeComponent();
        }

        private void frmKurumlar_Load(object sender, EventArgs e)
        {
            txtKurumKodu.Text = Numara.KurumKodNumarası();
        }

        void cariAc(int cariID)
        {
            CariID = cariID;
            txtCariAdi.Text = DB.Carilers.First(s => s.ID == CariID).CariAdi;
            txtCariKodu.Text = DB.Carilers.First(s => s.ID == CariID).CariKodu;
            txtVergiDairesi.Text = DB.Carilers.First(s => s.ID == CariID).VergiDairesi;
            txtVergiNo.Text = DB.Carilers.First(s => s.ID == CariID).VergiNo;
        }

        void Ac(int ID)
        {
            Edit = true;
            KurumID = ID;
            Fonksiyonlar.Kurumlar kurum = DB.Kurumlars.First(s => s.ID == ID);
            cariAc(kurum.CariID.Value);
            txtAdres.Text = kurum.Adres;
            txtEmail.Text = kurum.Email;
            txtFax.Text = kurum.Fax;
            txtKurumAdi.Text = kurum.KurumAdi;
            txtKurumKodu.Text = kurum.KurumKodu;
            txtIlce.Text = kurum.Ilce;
            txtSehir.Text = kurum.Sehir;
            txtTelefon.Text = kurum.Telefon;
            txtUlke.Text = kurum.Ulke;
            txtWebAdres.Text = kurum.WebAdres;
            txtYetkili1.Text = kurum.Yetkili1;
            txtYetkili1Email.Text = kurum.Yetkili1Email;
            txtYetkili2.Text = kurum.Yetkili2;
            txtYetkili2Email.Text = kurum.Yetkili2Email;
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";

            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";

            txtCariKodu.Text = Numara.CariKodNumarası();
            Edit = false;
            KurumID = -1;
            CariID = -1;
            MainForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Kurumlar kurum = new Fonksiyonlar.Kurumlar();
                kurum.Adres = txtAdres.Text;
                kurum.CariID = CariID;
                kurum.Email = txtEmail.Text;
                kurum.Fax = txtFax.Text;
                kurum.KurumAdi = txtKurumAdi.Text;
                kurum.KurumKodu = txtKurumKodu.Text;
                kurum.Ilce = txtIlce.Text;
                kurum.Sehir = txtSehir.Text;
                kurum.Telefon = txtTelefon.Text;
                kurum.Ulke = txtUlke.Text;
                kurum.WebAdres = txtWebAdres.Text;
                kurum.Yetkili1 = txtYetkili1.Text;
                kurum.Yetkili1Email = txtYetkili1Email.Text;
                kurum.Yetkili2 = txtYetkili2.Text;
                kurum.Yetkili2Email = txtYetkili2Email.Text;
                kurum.SaveDate = DateTime.Now;
                kurum.SaveUser = MainForm.UserID;
                DB.Kurumlars.InsertOnSubmit(kurum);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni kurum kaydı oluşturulmuştur!");
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
                Fonksiyonlar.Kurumlar kurum = DB.Kurumlars.First(s => s.ID == KurumID);
                kurum.Adres = txtAdres.Text;
                kurum.CariID = CariID;
                kurum.Email = txtEmail.Text;
                kurum.Fax = txtFax.Text;
                kurum.KurumAdi= txtKurumAdi.Text;
                kurum.KurumKodu = txtKurumKodu.Text;
                kurum.Ilce = txtIlce.Text;
                kurum.Sehir = txtSehir.Text;
                kurum.Telefon = txtTelefon.Text;
                kurum.Ulke = txtUlke.Text;
                kurum.WebAdres = txtWebAdres.Text;
                kurum.Yetkili1 = txtYetkili1.Text;
                kurum.Yetkili1Email = txtYetkili1Email.Text;
                kurum.Yetkili2 = txtYetkili2.Text;
                kurum.Yetkili2Email = txtYetkili2Email.Text;
                kurum.EditDate = DateTime.Now;
                kurum.EditUser = MainForm.UserID;
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
            DB.Kurumlars.DeleteOnSubmit(DB.Kurumlars.First(s => s.ID == KurumID));
            DB.SubmitChanges();
            Temizle();
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0)
            {
                cariAc(id);
            }
            MainForm.Aktarma = -1;
        }

        private void txtKurumKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.KurumListesi(true);
            if (id > 0)
            {
                Ac(id);
            }
            MainForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && KurumID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && KurumID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}