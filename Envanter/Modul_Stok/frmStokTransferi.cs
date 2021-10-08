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
using DevExpress.XtraEditors.Filtering.Templates;
using Envanter.Fonksiyonlar;
using static Envanter.Fonksiyonlar.Instances;

namespace Envanter.Modul_Stok
{
    public partial class frmStokTransferi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        #region Variables

        int depoID = -1;
        int cikisDepoID = -1;
        int kurumID = -1;
        int stokID = -1;

        #endregion

        #region Constructors

        public frmStokTransferi()
        {
            InitializeComponent();
        }

        private void frmStokTransferi_Load(object sender, EventArgs e)
        {
            txtTarih.DateTime = DateTime.Now;
        }

        #endregion

        #region Methods

        void Temizle()
        {
            txtKaynakDepo.Text = "";
            txtHedefDepo.Text = "";
            DepoBilgisi.Text = "Depo Bilgisi";
            txtAciklama.Text = "";
            depoID = -1;
            kurumID = -1;
            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);
            }
        }

        void StokEkle(int ID)
        {
            var qr = DB.VW_Oems.First(s => s.ID == ID);

            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue("ID", qr.ID);
            gridView1.SetFocusedRowCellValue("StokAdi", qr.StokAdi);
            gridView1.SetFocusedRowCellValue("SeriNo", qr.SeriNo);
            gridView1.SetFocusedRowCellValue("PartNo", qr.PartNo);
            gridView1.SetFocusedRowCellValue("GrupAdi", qr.GrupAdi);
            gridView1.UpdateCurrentRow();

            // Stoga bagli oem parcalari View'den getiriyoruz
            #region OemListele
            var srg = from s in DB.VW_Oems
                      where s.OemID == ID
                      select s;

            foreach (Fonksiyonlar.VW_Oem k in srg)
            {
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("ID", k.ID);
                gridView1.SetFocusedRowCellValue("OemID", k.OemID);
                gridView1.SetFocusedRowCellValue("StokAdi", k.StokAdi);
                gridView1.SetFocusedRowCellValue("SeriNo", k.SeriNo);
                gridView1.SetFocusedRowCellValue("PartNo", k.PartNo);
                gridView1.SetFocusedRowCellValue("GrupAdi", k.GrupAdi);
                gridView1.UpdateCurrentRow();
            }
            #endregion
        }

        string KurumAc(int ID)
        {
            string kurumAdi = DB.Kurumlars.First(s => s.ID == ID).KurumAdi;
            return kurumAdi;
        }

        string DepoAc(int ID)
        {
            string depoAdi = DB.Depolars.First(s => s.ID == ID).DepoAdi;
            return depoAdi;
        }

        string StokKartAdi(int StokID)
        {
            int KartID = int.Parse(DB.Stoklars.First(s => s.ID == StokID).StokKartID.ToString());
            string StokAdi = DB.StokKartlaris.First(s => s.ID == KartID).StokAdi;
            return StokAdi;
        }

        void OemSil(int StokID)
        {
            //Oemi çıkardığına dair hareket kaydı.
            Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
            hareket.Aciklama = StokID + " kodlu " + StokKartAdi(StokID) + "  stoğundan çıkarıldı.";
            hareket.Tur = "Oem";
            hareket.StokID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            hareket.Tarih = DateTime.Now;
            hareket.SaveDate = DateTime.Now;
            hareket.SaveUser = MainForm.UserID;
            DB.StokHareketleris.InsertOnSubmit(hareket);

            //Oemi ilgili stoktan ayırır.
            int oemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            Fonksiyonlar.Stoklar item = DB.Stoklars.First(s => s.ID == oemID);
            item.OemID = null;
            DB.SubmitChanges();
            gridView1.DeleteSelectedRows();
        }


        int Sec()
        {
            try
            {
                stokID = int.Parse(gridView1.GetFocusedRowCellValue("OemID").ToString());

                return stokID;
            }
            catch (Exception)
            {
                return stokID = -1;
            }
        }

        void YeniGiris()
        {

            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int StokID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());
                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.Tur = "Giriş";
                    hareket.Aciklama = txtAciklama.Text;
                    hareket.StokID = StokID;
                    hareket.KurumID = kurumID;
                    hareket.DepoID = depoID;
                    hareket.Tarih = DateTime.Parse(txtTarih.Text);
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);
                    Fonksiyonlar.Stoklar stok = DB.Stoklars.First(s => s.ID == StokID);
                    stok.DepoID = depoID;
                    stok.Tipi = (int)StokDurum.Giris;
                }
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void YeniCikis()
        {

            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int StokID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());

                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.Tur = "Çıkış";
                    hareket.Aciklama = txtAciklama.Text;
                    hareket.StokID = StokID;
                    hareket.KurumID = kurumID;
                    hareket.DepoID = depoID;
                    hareket.Tarih = DateTime.Parse(txtTarih.Text);
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);

                    Fonksiyonlar.Stoklar stok = DB.Stoklars.First(s => s.ID == StokID);
                    stok.DepoID = null;
                    stok.Tipi = (int)StokDurum.Cikis;
                    stok.OemID = null; //Eğer stok çıkış yapıldığında stoğa bağlı oemlerin parçadan ayrılmasını istiyorsam, burada ayırabilirim.
                }

                DB.SubmitChanges();
                Temizle();
            }

            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void YeniIkame()
        {
            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int StokID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());

                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.Tur = "İkame";
                    hareket.Aciklama = txtAciklama.Text;
                    hareket.StokID = StokID;
                    hareket.KurumID = kurumID;
                    hareket.DepoID = depoID;
                    hareket.Tarih = DateTime.Parse(txtTarih.Text);
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);

                    Fonksiyonlar.Stoklar stok = DB.Stoklars.First(s => s.ID == StokID);
                    stok.DepoID = depoID;
                    stok.Tipi = (int)StokDurum.Cikis;
                    //stok.OemID = null;
                }

                DB.SubmitChanges();
                Temizle();
            }

            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void DepoyaTransfer()
        {
            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int StokID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());

                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.Tur = "Çıkış";
                    hareket.Aciklama = DepoAc(depoID) + " --->> " + DepoAc(cikisDepoID) + " " + txtAciklama.Text;
                    hareket.StokID = StokID;
                    hareket.DepoID = depoID;
                    hareket.Tarih = DateTime.Parse(txtTarih.Text);
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);

                    Fonksiyonlar.Stoklar stok = DB.Stoklars.First(s => s.ID == StokID);
                    stok.DepoID = cikisDepoID;
                    stok.Tipi = (int)StokDurum.Cikis;
                }
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int StokID = int.Parse(gridView1.GetRowCellValue(i, "ID").ToString());

                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.Tur = "Giriş";
                    hareket.Aciklama = DepoAc(depoID) + " --->> " + DepoAc(cikisDepoID) + " " + txtAciklama.Text;
                    hareket.StokID = StokID;
                    hareket.DepoID = cikisDepoID;
                    hareket.Tarih = DateTime.Parse(txtTarih.Text);
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);
                }

                DB.SubmitChanges();
                Temizle();
            }

            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void HareketGetir(int ID)
        {

            if (ID > 0)
            {
                //txtKaynakDepo.Text=DB.StokHareketleris.First(s => s.ID == ID).;
            }
        }

        #endregion

        #region Events
        private void txtKaynakDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtHareketTipi.SelectedIndex == 0)
            {
                int ID = Formlar.KurumListesi(true);
                if (ID > 0)
                {
                    txtKaynakDepo.Text = KurumAc(ID);
                }
                MainForm.Aktarma = -1;
                kurumID = ID;
            }
            else if (txtHareketTipi.SelectedIndex == 1 || txtHareketTipi.SelectedIndex == 2 || txtHareketTipi.SelectedIndex == 3)
            {
                int ID = Formlar.DepoListesi(true);
                if (ID > 0)
                {
                    txtKaynakDepo.Text = DepoAc(ID);
                }
                MainForm.Aktarma = -1;
                depoID = ID;
            }
        }

        private void txtHedefDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtHareketTipi.SelectedIndex == 0)
            {
                int ID = Formlar.DepoListesi(true);
                if (ID > 0)
                {
                    txtHedefDepo.Text = DepoAc(ID);
                }
                MainForm.Aktarma = -1;
                depoID = ID;
            }
            else if (txtHareketTipi.SelectedIndex == 1 || txtHareketTipi.SelectedIndex == 2)
            {
                int ID = Formlar.KurumListesi(true);
                if (ID > 0)
                {
                    txtHedefDepo.Text = KurumAc(ID);
                }
                MainForm.Aktarma = -1;
                kurumID = ID;
            }
            else if (txtHareketTipi.SelectedIndex == 3)
            {
                int ID = Formlar.DepoListesi(true);
                if (ID > 0)
                {
                    txtHedefDepo.Text = DepoAc(ID);
                }
                MainForm.Aktarma = -1;
                cikisDepoID = ID;
            }
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (txtHareketTipi.SelectedIndex == 0) //Hareket tipi Giriş ise daha önce çıkış yapılmış kayıtlar gelsin
            {
                ID = Formlar.StokListesi(false, true);
            }
            else if (txtHareketTipi.SelectedIndex == 1 || txtHareketTipi.SelectedIndex == 3) //Hareket tipi Çıkış ve Depolar arası ise envanterde olan kayıtlar gelsin.
            {
                ID = Formlar.StokListesi(true, false);
            }
            else if (txtHareketTipi.SelectedIndex == 2) //Hareket tipi ikame ise sadece envanterde olan kayıtlar gelsin.
            {
                ID = Formlar.StokListesi(true, false);
            }
            if (ID > 0)
            {
                StokEkle(ID);
            }
            MainForm.Aktarma = -1;
        }

        private void txtHareketTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtKaynakDepo_TextChanged(object sender, EventArgs e)
        {
            DepoBilgisi.Text = txtKaynakDepo.Text + "  --->  " + txtHedefDepo.Text;
        }

        private void txtHedefDepo_TextChanged(object sender, EventArgs e)
        {
            DepoBilgisi.Text = txtKaynakDepo.Text + "  --->  " + txtHedefDepo.Text;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtHareketTipi.SelectedIndex == 0)
            {
                YeniGiris();
            }
            if (txtHareketTipi.SelectedIndex == 1)
            {
                YeniCikis();
            }
            if (txtHareketTipi.SelectedIndex == 2)
            {
                YeniIkame();
            }
            if (txtHareketTipi.SelectedIndex == 3)
            {
                DepoyaTransfer();
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            int ID = Formlar.StokHareketleri(true);
            HareketGetir(ID);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (Mesajlar.YeniKayit() == DialogResult.Yes)
            {
                Temizle();
                txtTarih.DateTime = DateTime.Now;
            }
        }

        private void btnOemSil_Click(object sender, EventArgs e)
        {
            try
            {
                int StokID = Sec();

                if (StokID > 0)
                {
                    OemSil(StokID);
                }
                else
                {
                    gridView1.DeleteSelectedRows();
                }
                stokID = -1;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        #endregion


    }
}