using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter.Modul_Stok
{
    public partial class frmStokFoto : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        public int StokID = -1;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        System.Drawing.Image img;

        public frmStokFoto()
        {
            InitializeComponent();
        }


        private void frmStokFoto_Load(object sender, EventArgs e)
        {
            Fonksiyonlar.Stoklar Stok = DB.Stoklars.First(s => s.ID == StokID);
            if (Stok.Image != null) pictureBox1.Image = Resimleme.ResimGetirme(Stok.Image.ToArray());

            this.Text = Stok.PartNo;

            img = pictureBox1.Image;
            if (img.Width > screenWidth || img.Height > screenHeight)
            {
                this.Size= new System.Drawing.Size(screenWidth, screenHeight);
                this.WindowState = FormWindowState.Maximized;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else this.Size = new System.Drawing.Size(img.Width, img.Height);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}