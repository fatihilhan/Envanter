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
using Envanter.Fonksiyonlar;

namespace Envanter.Modul_Cari
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;

        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
            txtCariAdi.Select();
        }

        void Listele()
        {
            var srg = from s in DB.Carilers
                      where s.CariAdi.Contains(txtCariAdi.Text.ToLower())
                      && s.CariKodu.Contains(txtCariKodu.Text)
                      select s;

            Liste.DataSource = srg;
        }

        void Temizle()
        {
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);
            }
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception ex)
            {
                SecimID = -1;
                Mesajlar.Hata(ex);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
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
    }
}