using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;

namespace Envanter
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static Fonksiyonlar.Kullanicilar User;
        public static int UserID = -1;
        public static int Aktarma = -1; // Formlar arası geçişler için aktarma değişkeni oluşturduk.
        public static string conStr = "";

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Fonksiyonlar.Kullanicilar user)
        {
            InitializeComponent();
            User = user;
            UserID = User.ID;
        }

        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        private void barBtnStoklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Stoklar();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barBtnStokKartlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKartlari();
        }

        private void barBtnCariKartAc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariKartAc();
        }

        private void barBtnHastaneler_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KurumEkle();
        }

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void batBtnDepoTanimlama_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.DepoListesi();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokTransferi();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppSetting setting = new AppSetting();
            string[] connection = setting.GetConnectionString("cn").Split('=', ';');
            //string[] connection = System.Configuration.ConfigurationManager.ConnectionStrings["cn"].ConnectionString.Split('=', ';');
            barTxtDatabase.Caption = "Database: " + connection[1] + ":" + connection[3];
            conStr = setting.GetConnectionString("cn");
            barTxtUser.Caption = "Kullanıcı: " + User.Ad + " " + User.Soyad;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.SkinName = UserLookAndFeel.Default.SkinName;
            settings.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName;
            settings.Save();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var settings = Properties.Settings.Default;
            if (!String.IsNullOrEmpty(settings.SkinName))
            {
                if (!String.IsNullOrEmpty(settings.SkinName))
                {
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName, settings.Palette);
                }
                else
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName);
            }
        }
    }
}