using DevExpress.Printing.Core.PdfExport.Metafile;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter.Fonksiyonlar
{
    class Mesajlar
    {
        MainForm MesajForm = new MainForm();

        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("Yeni Kayıt Girişi", Mesaj);
            // MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult YeniKayit()
        {
            return XtraMessageBox.Show("Yaptığınız değişiklikler kaybolacaktır. Devam etmek istiyor musunuz?", "Yeni Kayıt İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Guncelle()
        {
            return XtraMessageBox.Show("Seçili kayıt kalıcı olarak güncellenecektir.\nGüncelleme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt güncellenmiştir.");
            // MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Sil()
        {
            return XtraMessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir.\nSilme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Hata(Exception Hata)
        {
            //MesajForm.Mesaj("Hata oluştu", Hata.Message);
            XtraMessageBox.Show(Hata.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FormAcilis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu açıldı.");
        }
        public void FormKapanis(string FormAdi)
        {
            MesajForm.Mesaj("", FormAdi + " formu kapatıldı.");
        }

    }
}
