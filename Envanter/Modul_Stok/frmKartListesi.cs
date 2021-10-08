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
using DevExpress.Utils.Extensions;
using static Envanter.Fonksiyonlar.Instances;

namespace Envanter.Modul_Stok
{
    public partial class frmKartListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int SecimID = -1;
        public int OemID = -1;

        public frmKartListesi()
        {
            InitializeComponent();
        }

        private void frmKartListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var srg = from s in DB.VW_Oems
                      where s.OemID == null
                      && s.Tipi.Equals((int)StokDurum.Giris)
                      && s.ID != OemID
                      select s;

            grdKartlar.DataSource = srg.ToList();
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(grvKartlar.GetFocusedRowCellValue("ID").ToString());
                grvKartlar.DeleteSelectedRows();

                var srg = from s in DB.VW_Oems
                          where s.ID == SecimID
                          select s;

                foreach (Fonksiyonlar.VW_Oem item in srg)
                {
                    grvSecilen.AddNewRow();
                    grvSecilen.SetFocusedRowCellValue("ID", item.ID);
                    grvSecilen.SetFocusedRowCellValue("StokAdi", item.StokAdi);
                    grvSecilen.SetFocusedRowCellValue("SeriNo", item.SeriNo);
                    grvSecilen.SetFocusedRowCellValue("GrupAdi", item.GrupAdi);
                    grvSecilen.SetFocusedRowCellValue("PartNo", item.PartNo);
                    grvSecilen.UpdateCurrentRow();
                }
            }
            catch (Exception ex)
            {
                SecimID = -1;
                Mesajlar.Hata(ex);
            }
        }

        string StokKartAdi(int StokID)
        {
            int StokKartID = int.Parse(DB.Stoklars.First(s => s.ID == StokID).StokKartID.ToString());
            string StokAdi= DB.StokKartlaris.First(s => s.ID == StokKartID).StokAdi;
            return StokAdi;
        }

        void Ekle(int ID)
        {
            try
            {
                // Seçilen kartları ana parçaya bağlıyoruz.
                for (int i = 0; i < grvSecilen.RowCount; i++)
                {
                    int oemID = int.Parse(grvSecilen.GetRowCellValue(i, "ID").ToString());
                    Fonksiyonlar.Stoklar oem = DB.Stoklars.First(s => s.ID == oemID);
                    oem.OemID = ID;
                    oem.Tipi = (int)StokDurum.Oem;

                    //Hareket kaydı oluşturma
                    Fonksiyonlar.StokHareketleri hareket = new Fonksiyonlar.StokHareketleri();
                    hareket.StokID = oem.ID;
                    hareket.Tur = "Oem";
                    hareket.Tarih = DateTime.Now;
                    hareket.Aciklama = ID + " kodlu " + StokKartAdi(oem.OemID.Value) + " stoğuna takıldı.";
                    hareket.SaveDate = DateTime.Now;
                    hareket.SaveUser = MainForm.UserID;
                    DB.StokHareketleris.InsertOnSubmit(hareket);
                }
                DB.SubmitChanges();

                this.Close();
        }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
}

        private void grdKartlar_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            SecimID = -1;
        }

        private void grdSecilenKartlar_DoubleClick(object sender, EventArgs e)
        {
            grvSecilen.DeleteSelectedRows();
            SecimID = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle(OemID);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}