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

namespace Envanter.Modul_Stok
{
    public partial class YeniKartEkle : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        public YeniKartEkle()
        {
            InitializeComponent();
        }

        void StokGetir(int StokID)
        {
            try
            {
                Fonksiyonlar.StokKartlari Stok = DB.StokKartlaris.First(s => s.ID == StokID);
                grvKartlar.AddNewRow();
                grvKartlar.SetFocusedRowCellValue("StokAdi", Stok.StokAdi);
                grvKartlar.SetFocusedRowCellValue("ID", Stok.ID);
                grvKartlar.SetFocusedRowCellValue("GrupAdi", Stok.GrupID);
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        //void Kaydet()
        //{
        //    Fonksiyonlar.Stoklar[] Stok = new Fonksiyonlar.Stoklar[grvKartlar.RowCount];
        //    for (int i = 0; i < grvKartlar.RowCount; i++)
        //    {
        //        Stok[i] = new Fonksiyonlar.Stoklar();
        //        Stok[i].BIRIMFIYAT = decimal.Parse(grvKartlar.GetRowCellValue(i, "BIRIMFIYAT").ToString());
        //        Stok[i].FATURAID = Fatura.ID;
        //        Stok[i].GCKODU = "C";
        //        Stok[i].IRSALIYEID = IrsaliyeID;
        //        Stok[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
        //        Stok[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
        //        Stok[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
        //        Stok[i].TIPI = "Satış Faturası";
        //        Stok[i].SAVEDATE = DateTime.Now;
        //        Stok[i].SAVEUSER = AnaForm.UserID;
        //        DB.Stoklars.InsertOnSubmit(Stok[i]);
        //    }
        //    DB.SubmitChanges();
        //}

        private void btnStokKartSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StokID = Formlar.StokListesi(true);
            if (StokID > 0)
            {
                StokGetir(StokID);
            }
            MainForm.Aktarma = -1;
        }
    }
}