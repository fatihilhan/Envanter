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
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;

        public frmStokHareketleri()
        {
            InitializeComponent();
            txtStokAdi.Select();
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }



        void Temizle()
        {
            txtPartNo.Text = "";
            txtSeriNo.Text = "";
            txtStokAdi.Text = "";
            txtHareketID.Text = "";
        }

        void Listele()
        {
            var query = (from s in DB.StokHareketleris
                         join p in DB.Stoklars on s.StokID equals p.ID
                         join x in DB.StokKartlaris on p.StokKartID equals x.ID
                         join y in DB.StokGruplaris on x.GrupID equals y.ID
                         join z in DB.Depolars on s.DepoID equals z.ID into de
                         from d in de.DefaultIfEmpty()
                         join k in DB.Kurumlars on s.KurumID equals k.ID into kh
                         from w in kh.DefaultIfEmpty()
                         where x.StokAdi.Contains(txtStokAdi.Text.ToLower())
                         && s.ID.ToString().Contains(txtHareketID.Text)
                         && p.SeriNo.Contains(txtSeriNo.Text.ToLower())
                         && p.PartNo.Contains(txtPartNo.Text.ToLower())


                         select new
                         {
                             ID = s.ID,
                             StokID = s.StokID,
                             Tur = s.Tur,
                             DepoAdi = d.DepoAdi,
                             KurumAdi = w.KurumAdi,
                             Tarih = s.Tarih,
                             GrupAdi = y.GrupAdi,
                             StokAdi = x.StokAdi,
                             PartNo = p.PartNo,
                             SeriNo = p.SeriNo,
                             Aciklama = s.Aciklama
                         }).OrderByDescending(c => c.ID); ;

            Liste.DataSource = query.ToList();
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Liste.ShowRibbonPrintPreview();
        }
    }
}