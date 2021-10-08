using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envanter.Fonksiyonlar
{
    class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool stokSec = false, bool transferSec = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();

            if (stokSec)
            {
                frm.StokSec = stokSec;
                frm.ShowDialog(); //Eğer seçim için çağrılmışsa ayrı bir pencerede açılmasını sağlıyoruz.
            }
            else if (transferSec)
            {
                frm.transferSec = transferSec;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
            return MainForm.Aktarma;
        }

        public void KartListesi(int StokID)
        {
            Modul_Stok.frmKartListesi frm = new Modul_Stok.frmKartListesi();

            frm.OemID = StokID;
            frm.ShowDialog();
        }

        public int DepoListesi(bool depoSec = false)
        {
            Modul_Stok.frmDepoTanimlama frm = new Modul_Stok.frmDepoTanimlama();

            if (depoSec)
            {
                frm.depoSec = depoSec;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return MainForm.Aktarma;
        }

        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();

            if (Secim) frm.Secim = Secim; //Seçim için açılsa da açılmasa da seçimden gelen değeri buraya aktardık.
            frm.ShowDialog();
            return MainForm.Aktarma;
        }

        public int StokHareketleri(bool Secim = false)
        {
            Modul_Stok.frmStokHareketleri frm = new Modul_Stok.frmStokHareketleri();

            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
            return MainForm.Aktarma;
        }

        public void StokTransferi(bool Ac = false)
        {
            Modul_Stok.frmStokTransferi frm = new Modul_Stok.frmStokTransferi();

            frm.ShowDialog();
        }
        public void Stoklar(bool Ac = false)
        {
            Modul_Stok.frmStoklar frm = new Modul_Stok.frmStoklar();

            frm.ShowDialog();
        }

        public int StokKartlari(bool Secim = false)
        {
            Modul_Stok.frmStokKartlari frm = new Modul_Stok.frmStokKartlari();

            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return MainForm.Aktarma;
        }


        public void StokFoto(int id)
        {
            Modul_Stok.frmStokFoto frm = new Modul_Stok.frmStokFoto();

            frm.StokID = id;
            frm.ShowDialog();
        }
        #endregion

        #region Cari Formlar
        public void CariKartAc()
        {
            Modul_Cari.frmCariAcilisKarti frm = new Modul_Cari.frmCariAcilisKarti();

            frm.ShowDialog();
        }

        public void KurumEkle()
        {
            Modul_Cari.frmKurumlar frm = new Modul_Cari.frmKurumlar();

            frm.ShowDialog();
        }

        public int CariListesi(bool secim = false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();

            if (secim)
            {
                frm.Secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
            return MainForm.Aktarma;
        }

        public int KurumListesi(bool secim = false)
        {
            Modul_Cari.frmKurumListesi frm = new Modul_Cari.frmKurumListesi();

            if (secim)
            {
                frm.Secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
            return MainForm.Aktarma;
        }
        #endregion
    }
}
