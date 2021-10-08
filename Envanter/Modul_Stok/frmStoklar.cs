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
using DevExpress.XtraEditors.Controls;
using static Envanter.Fonksiyonlar.Instances;

namespace Envanter.Modul_Stok
{
    public partial class frmStoklar : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int StokKartID = -1;
        int StokID = -1;
        int DepoID = -1;
        int KurumID = -1;

        public frmStoklar()
        {
            InitializeComponent();
        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            if (DB.VW_Yetkilers.First(s => s.ID == MainForm.UserID && s.Aktif == true).Rol == "StokEkle")
            {
                btnKaydet.Enabled = true;
            }
            else { btnKaydet.Enabled = false; }

            List<DepoGetir> depos = new List<DepoGetir>();
            foreach (var qr in DB.VW_KullaniciDepos)
            {
                if (qr.UserID == MainForm.UserID && qr.Aktif == true)
                {
                    depos.Add(new DepoGetir(qr.DepoID, qr.DepoAdi));
                }
            }

            cbxDepo.Properties.DataSource = depos;
            cbxDepo.Properties.DisplayMember = "DepoAdi";
            cbxDepo.Properties.ValueMember = "DepoId";
            cbxDepo.EditValue = depos[0].DepoId;
            DepoID = int.Parse(cbxDepo.GetColumnValue("DepoId").ToString());

            txtStokKodu.Text = Numara.StokKodNumarası().ToString();
            Mesajlar.FormAcilis(this.Text);
            txtHastaneAdi.Enabled = false;
            btnKartEkle.Enabled = false;
            txtAlisFiyat.Text = "0";
            txtSatisFiyat.Text = "0";
            if (!Resim)
            {
                btnResimSil.Enabled = false;
            }
        }

        void Temizle()
        {
            txtStokKodu.Text = Numara.StokKodNumarası().ToString();
            txtStokAdi.Text = "";
            txtLabel.Text = "";
            txtStokKartNo.Text = "";
            txtHastaneAdi.Text = "";
            txtPartNo.Text = "";
            txtSeriNo.Text = "";
            txtSatisFiyat.Text = "0";
            txtAlisFiyat.Text = "0";
            txtDurum.SelectedIndex = 0;
            cbxDepo.Text = "";
            txtRaf.Text = "";
            txtAciklama.Text = "";
            picStok.Image = null;
            btnKartEkle.Enabled = false;
            Edit = false;
            Resim = false;
            StokKartID = -1;
            StokID = -1;
            DepoID = -1;
            KurumID = -1;
            MainForm.Aktarma = -1;
            for (int i = gvKartListesi.RowCount; i > -1; i--)
            {
                gvKartListesi.DeleteRow(i);
            }
        }

        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg|PNG(*.png)|*.png|Bitmap(*.bmp)|*.bmp";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                picStok.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Stoklar stok = new Fonksiyonlar.Stoklar();
                stok.StokKartID = StokKartID;
                if (!(DepoID > 0))
                {
                    XtraMessageBox.Show("Depo seçiniz!", "Depo Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                stok.DepoID = DepoID;
                stok.Tipi = (int)StokDurum.Giris;
                stok.PartNo = txtPartNo.Text;
                stok.SeriNo = txtSeriNo.Text;
                stok.Label = txtLabel.Text;
                stok.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                stok.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                stok.Durum = txtDurum.Text;
                stok.Raf = txtRaf.Text;
                stok.Aciklama = txtAciklama.Text;
                if (Resim) stok.Image = new System.Data.Linq.Binary(Resimleme.ResimYukleme(picStok.Image));
                stok.SaveDate = DateTime.Now;
                stok.SaveUser = MainForm.UserID;
                DB.Stoklars.InsertOnSubmit(stok);
                DB.SubmitChanges();

                //Hareket Kaydi olusturma bölümü
                Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                hareket.StokID = stok.ID;
                if (KurumID > 0)
                {
                    hareket.Aciklama = KurumAc(KurumID) + "'nden teslim alındı.";
                    hareket.KurumID = KurumID;
                }
                else
                {
                    hareket.Aciklama = "Envantere yeni stok girişi yapıldı.";
                }
                hareket.Tur = "Giriş";
                hareket.Tarih = DateTime.Now;
                hareket.DepoID = DepoID;
                hareket.SaveDate = DateTime.Now;
                hareket.SaveUser = MainForm.UserID;
                DB.StokHareketleris.InsertOnSubmit(hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni stok kaydı oluşturuldu.");
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
                Fonksiyonlar.Stoklar Stok = DB.Stoklars.First(s => s.ID == StokID);
                Stok.StokKartID = StokKartID;
                Stok.DepoID = DepoID;
                Stok.PartNo = txtPartNo.Text;
                Stok.SeriNo = txtSeriNo.Text;
                Stok.Label = txtLabel.Text;
                Stok.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                Stok.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                Stok.Durum = txtDurum.Text;
                Stok.Raf = txtRaf.Text;
                Stok.Aciklama = txtAciklama.Text;
                if (Resim) Stok.Image = new System.Data.Linq.Binary(Resimleme.ResimYukleme(picStok.Image));
                Stok.EditDate = DateTime.Now;
                Stok.EditUser = MainForm.UserID;
                DB.SubmitChanges();

                //var query = DB.Stoklars.Where(s => s.OemID == StokID);
                ///*alttaki sorgu ile üstteki ifade ayni anlama gelir.
                // * var query = from s in DB.Stoklars
                // *             where s.OemID == StokID
                // *             select s;

                //stok kaydini guncellemeden once varolan oem'leri cikartiyoruz.*/
                //foreach (Fonksiyonlar.Stoklar item in query)
                //{
                //    item.OemID = null;
                //}

                //// Gridviewdeki oemleri stokkartina bagliyoruz.
                //for (int i = 0; i < gridView1.RowCount; i++)
                //{
                //    int oemID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());
                //    Fonksiyonlar.Stoklar oem = DB.Stoklars.First(s => s.ID == oemID);
                //    oem.OemID = StokID;
                //}
                //DB.SubmitChanges();
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
            /* OemID'si gönderdiğimiz stokID'ye eşit olan kartları bulup null yapıyoruz. */
            var query = from s in DB.Stoklars
                        where s.OemID == StokID
                        select s;

            foreach (Fonksiyonlar.Stoklar stok in query)
            {
                stok.OemID = null;
            }

            /* Daha sonra ilgili stok girişimizi siliyoruz. */
            try
            {
                DB.SubmitChanges();
                /* Sorgu yukarıda, değişikliği aşağıda kaydettik. 
                 * Bu kullanım microsoft makalesinde böyle verilmiştir.*/

                Fonksiyonlar.Stoklar stok = DB.Stoklars.First(s => s.ID == StokID);
                stok.Tipi = (int)StokDurum.Sil;
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void StokKartAc(int ID)
        {
            StokKartID = ID;
            txtStokAdi.Text = DB.StokKartlaris.First(s => s.ID == StokKartID).StokAdi;
            txtStokKartNo.Text = DB.StokKartlaris.First(s => s.ID == StokKartID).ID.ToString();
        }

        void Ac(int ID)
        {
            Temizle();
            Edit = true;
            StokID = ID;
            txtHastaneAdi.Enabled = false;
            Fonksiyonlar.Stoklar Stok = DB.Stoklars.First(s => s.ID == StokID);
            StokKartAc(Stok.StokKartID.Value);
            DepoGetir(Stok.DepoID.Value);
            if (Stok.Image != null) picStok.Image = Resimleme.ResimGetirme(Stok.Image.ToArray());
            else picStok.Image = null;

            txtStokKodu.Text = Stok.ID.ToString();
            txtAciklama.Text = Stok.Aciklama.ToString();
            txtAlisFiyat.Text = Stok.AlisFiyat.ToString();
            txtDurum.Text = Stok.Durum.ToString();
            txtRaf.Text = Stok.Raf.ToString();
            txtPartNo.Text = Stok.PartNo.ToString();
            txtSatisFiyat.Text = Stok.SatisFiyat.ToString();
            txtSeriNo.Text = Stok.SeriNo.ToString();
            txtLabel.Text = Stok.Label.ToString();
            btnKartEkle.Enabled = true;
            if (Stok.Image != null) btnResimSil.Enabled = true;

            #region OemListele
            // Stoga bagli oem parcalari View'den getiriyoruz
            var srg = from s in DB.VW_Oems
                      where s.OemID == StokID
                      select s;

            foreach (Fonksiyonlar.VW_Oem k in srg)
            {
                gvKartListesi.AddNewRow();
                gvKartListesi.SetFocusedRowCellValue("ID", k.ID);
                gvKartListesi.SetFocusedRowCellValue("GrupAdi", k.GrupAdi);
                gvKartListesi.SetFocusedRowCellValue("StokAdi", k.StokAdi);
                gvKartListesi.SetFocusedRowCellValue("SeriNo", k.SeriNo);
                gvKartListesi.SetFocusedRowCellValue("PartNo", k.PartNo);
            }
            #endregion
        }

        string KurumAc(int ID)
        {
            string kurumAdi = DB.Kurumlars.First(s => s.ID == ID).KurumAdi;
            return kurumAdi;
        }

        void DepoGetir(int ID)
        {

            try
            {
                DepoID = DB.Depolars.First(s => s.ID == ID).ID;
                cbxDepo.EditValue = DepoID;
                //txtDepo.Text = DB.Depolars.First(s => s.ID == ID).DepoAdi;
            }
            catch (InvalidOperationException)
            {
                XtraMessageBox.Show("Böyle bir depo bulunmadı!", "Depo Seç", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string StokKartAdi(int KartID)
        {
            string StokAdi = DB.StokKartlaris.First(s => s.ID == KartID).StokAdi;
            return StokAdi;
        }



        #region Events
        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            MainForm.Aktarma = -1;
        }

        private void txtStokKartNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokKartlari(true);
            if (ID > 0)
            {
                StokKartAc(ID);
            }
            MainForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (!(StokID > 0))
            {
                YeniKaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKartEkle_Click(object sender, EventArgs e)
        {
            Formlar.KartListesi(StokID);

            var srg = from s in DB.VW_Oems
                      where s.OemID == StokID
                      select s;

            for (int i = 0; i < gvKartListesi.RowCount;)
            {
                gvKartListesi.DeleteRow(i);
            }

            foreach (Fonksiyonlar.VW_Oem k in srg)
            {
                gvKartListesi.AddNewRow();
                gvKartListesi.SetFocusedRowCellValue("ID", k.ID);
                gvKartListesi.SetFocusedRowCellValue("GrupAdi", k.GrupAdi);
                gvKartListesi.SetFocusedRowCellValue("StokAdi", k.StokAdi);
                gvKartListesi.SetFocusedRowCellValue("SeriNo", k.SeriNo);
                gvKartListesi.SetFocusedRowCellValue("PartNo", k.PartNo);
            }
        }

        private void btnOemSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Oemi çıkardığına dair hareket kaydı.
                Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                hareket.Aciklama = StokID + " kodlu " + StokKartAdi(StokKartID) + "  stoğundan çıkarıldı.";
                hareket.Tur = "Giriş";
                hareket.StokID = int.Parse(gvKartListesi.GetFocusedRowCellValue("ID").ToString());
                hareket.Tarih = DateTime.Now;
                hareket.SaveDate = DateTime.Now;
                hareket.SaveUser = MainForm.UserID;
                DB.StokHareketleris.InsertOnSubmit(hareket);

                //Oemi ilgili stoktan ayırır.
                int oemID = int.Parse(gvKartListesi.GetFocusedRowCellValue("ID").ToString());
                Fonksiyonlar.Stoklar item = DB.Stoklars.First(s => s.ID == oemID);
                item.OemID = null;
                item.Tipi = (int)StokDurum.Giris;
                DB.SubmitChanges();
                gvKartListesi.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void txtHastaneAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KurumListesi(true);
            if (ID > 0)
            {
                txtHastaneAdi.Text = KurumAc(ID);
            }
            MainForm.Aktarma = -1;
            KurumID = ID;
        }

        private void chkTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransfer.Checked == false)
            {
                txtHastaneAdi.Enabled = false;
                KurumID = -1;
                txtHastaneAdi.Text = "";
            }
            else if (chkTransfer.Checked == true)
            {
                txtHastaneAdi.Enabled = true;
            }
        }

        private void picStok_DoubleClick(object sender, EventArgs e)
        {
            Fonksiyonlar.Stoklar Stok = DB.Stoklars.First(s => s.ID == StokID);
            if (Stok.Image != null && StokID > 0) Formlar.StokFoto(StokID);
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            if (StokID > -1)
            {
                Fonksiyonlar.Stoklar Stok = DB.Stoklars.First(s => s.ID == StokID);
                Stok.Image = null;
                picStok.Image = null;
            }
        }
        private void frmStoklar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)  // F1, F2 ve F3 tuşlarına kısayol atamaları yaptık. 
            {
                case Keys.F1:
                    int ID1 = Formlar.StokListesi(true);
                    if (ID1 > 0)
                    {
                        Ac(ID1);
                    }
                    MainForm.Aktarma = -1;
                    break;

                case Keys.F2:
                    int ID2 = Formlar.StokKartlari(true);
                    if (ID2 > 0)
                    {
                        StokKartAc(ID2);
                    }
                    MainForm.Aktarma = -1;
                    break;
            }
        }
        private void cbxDepo_EditValueChanged(object sender, EventArgs e)
        {
            DepoID = int.Parse(cbxDepo.GetColumnValue("DepoId").ToString());
        }
        #endregion
    }
}