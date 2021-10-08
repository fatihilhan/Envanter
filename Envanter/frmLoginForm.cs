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
using DevExpress.LookAndFeel;
using Squirrel;
using System.Diagnostics;

namespace Envanter
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Database = new Fonksiyonlar.DatabaseDataContext();

        #region Constructors
        public frmLoginForm()
        {
            InitializeComponent();
            CheckForUpdates();
            AddVersionNumber();
        }
        #endregion

        #region Methods

        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            
            this.Text += $"v.{versionInfo.FileVersion}";
        }

        private async void CheckForUpdates()
        {
            try
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/fatihilhan/Renova_Envanter"))
                {
                    var release = await mgr.UpdateApp();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to check updates: " + e.ToString());
            }
        }

        #endregion

        #region Events
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.Kullanicilar user = Database.Kullanicilars.First(s => s.KullaniciAdi == txtKullanici.Text.Trim() && s.Sifre == txtSifre.Text.Trim());
                user.LastLogin = DateTime.Now;
                Database.SubmitChanges();
                this.Hide();
                MainForm frm = new MainForm(user);
                frm.Show();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kullanıcı adı ve şifrenizi kontrol edip tekrar deneyiniz.");
                return;
            }
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmConnection frm = new frmConnection();
            frm.ShowDialog();
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

        #endregion
    }
}