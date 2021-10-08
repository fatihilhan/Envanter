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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;
using Envanter.Fonksiyonlar;
using static Envanter.Fonksiyonlar.Instances;

namespace Envanter.Modul_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Database = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        #region Variables
        public bool StokSec = false;
        public bool transferSec = false;
        public int[] selected;
        int secimID = -1;
        int depoID = -1;
        bool expandedRow = false;

        #endregion

        #region Constructors
        public frmStokListesi()
        {
            InitializeComponent();
            txtStokAdi.Select();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            List<DepoGetir> depos = new List<DepoGetir>();
            foreach (var qr in Database.VW_KullaniciDepos)
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
            depoID = int.Parse(cbxDepo.GetColumnValue("DepoId").ToString());
            Listele();
        }
        #endregion

        #region Methods
        void Listele()
        {
            if (StokSec)
            {
                StokListele();
            }
            else if (transferSec)
            {
                TransferListele();
            }
            else
            {
                OemListele();
            }
        }

        private void OemListele()
        {
            stoklarTableAdapter.FillByDepo(dataSetler.StokMaster, depoID);
            stokDetayTableAdapter1.Fill(dataSetler.StokDetay);
            colGrupAdi.GroupIndex = 0;
        }

        void StokListele()
        {
            colGrupAdi.GroupIndex = 0;
            colStokAdi.GroupIndex = 1;

            var qr = from s in Database.VW_Oems
                     join d in Database.Depolars on s.DepoID equals d.ID
                     where s.DepoID == depoID
                     && s.StokAdi.Contains(txtStokAdi.Text.ToLower())
                     && s.ID.ToString().Contains(txtStokKodu.Text)
                     && s.SeriNo.Contains(txtSeriNo.Text.ToLower())
                     && s.PartNo.Contains(txtPartNo.Text.ToLower())
                     && s.Tipi.Equals((int)StokDurum.Giris)
                     select new
                     {
                         ID = s.ID,
                         OemID = s.OemID,
                         StokAdi = s.StokAdi,
                         GrupAdi = s.GrupAdi,
                         SeriNo = s.SeriNo,
                         PartNo = s.PartNo,
                         Durum = s.Durum,
                         Aciklama = s.Aciklama,
                         DepoAdi= d.DepoAdi
                     };

            Liste.DataSource = qr;
        }
        void TransferListele()
        {
            var qr = from s in Database.VW_Oems
                     join d in Database.Depolars on s.DepoID equals d.ID
                     where s.DepoID == depoID
                     && s.StokAdi.Contains(txtStokAdi.Text.ToLower())
                     && s.ID.ToString().Contains(txtStokKodu.Text)
                     && s.SeriNo.Contains(txtSeriNo.Text.ToLower())
                     && s.PartNo.Contains(txtPartNo.Text.ToLower())
                     && s.Tipi.Equals((int)StokDurum.Cikis)
                     select new
                     {
                         ID = s.ID,
                         OemID = s.OemID,
                         StokAdi = s.StokAdi,
                         GrupAdi = s.GrupAdi,
                         SeriNo = s.SeriNo,
                         PartNo = s.PartNo,
                         Durum = s.Durum,
                         Aciklama = s.Aciklama,
                         DepoAdi = d.DepoAdi
                     };

            Liste.DataSource = qr;
        }

        void Sec()
        {
            try
            {
                secimID = int.Parse(gvMain.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception ex)
            {
                secimID = -1;
                Mesajlar.Hata(ex);
            }
        }
        #endregion

        #region Events
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtPartNo.Text = "";
            txtSeriNo.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Liste.ShowRibbonPrintPreview();
        }

        private void gvMain_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = gvMain.CalcHitInfo((e as MouseEventArgs).Location); //grup satirina tikli olup olmadigi bilgisini almak icin GridHitInfo sinifini kullaniyoruz.
            if (hitInfo.InRowCell && view.IsMasterRow(hitInfo.RowHandle) && expandedRow == false)
            {
                view.ExpandMasterRow(hitInfo.RowHandle);    // oemleri gorebilmek icin master row a cift tik yapinca, detail view acilir.
                expandedRow = true;
            }
            else if (expandedRow == true)
            {
                view.CollapseMasterRow(hitInfo.RowHandle);
                expandedRow = false;
            }

            if (!hitInfo.InGroupRow && (StokSec || transferSec)) //grup satirina tiklanmadiysa ve secim true ise
            {
                Sec();
                MainForm.Aktarma = secimID;
                this.Close();
            }
        }

        // Gridte gruplama yapildiginda grubun yaninda Adet bilgisi gosterilir.
        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} ({2} Adet)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void gvMain_CellMerge(object sender, CellMergeEventArgs e)  //ayni icerikteki hucreleri birlestirmek icin kullandim ama calismadi
        {
            GridView view = sender as GridView;
            if (gvMain == null) return;
            if (e.Column == colGrupAdi)
            {
                string text1 = view.GetRowCellDisplayText(e.RowHandle1, colGrupAdi);
                string text2 = view.GetRowCellDisplayText(e.RowHandle2, colGrupAdi);
                e.Merge = (text1 == text2);
                e.Handled = true;
            }
        }

        private void cbxDepo_EditValueChanged(object sender, EventArgs e)
        {
            depoID = int.Parse(cbxDepo.GetColumnValue("DepoId").ToString());
        }

        private void gvMain_MouseDown(object sender, MouseEventArgs e)  //tek tikla master rowu genisletmek icin
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = gvMain.CalcHitInfo((e as MouseEventArgs).Location); //grup satirina tikli olup olmadigi bilgisini almak icin GridHitInfo sinifini kullaniyoruz.
            if (hitInfo.InRowCell && view.IsMasterRow(hitInfo.RowHandle) && expandedRow == false)
            {
                gvMain.ExpandMasterRow(hitInfo.RowHandle);    // oemleri gorebilmek icin master row a cift tik yapinca, detail view acilir.
                expandedRow = true;
            }
            else if (expandedRow == true)
            {
                gvMain.CollapseMasterRow(hitInfo.RowHandle);
                expandedRow = false;
            }
        }

        private void gvMain_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) //oemi olmayan stoklarin yanindaki arti isaretini kaldirdik.
        {
            GridView view = sender as GridView;
            if (e.Column.VisibleIndex == 0 && view.OptionsDetail.SmartDetailExpandButtonMode != DetailExpandButtonMode.AlwaysEnabled)
            {
                bool isMasterRowEmpty;
                if (view.OptionsDetail.SmartDetailExpandButtonMode == DetailExpandButtonMode.CheckAllDetails)
                {
                    isMasterRowEmpty = true;
                    for (int i = 0; i < view.GetRelationCount(e.RowHandle); i++)
                    {
                        if (!view.IsMasterRowEmptyEx(e.RowHandle, i))
                        {
                            isMasterRowEmpty = false;
                            break;
                        }
                    }
                }
                else
                    isMasterRowEmpty = view.IsMasterRowEmpty(e.RowHandle);
                if (isMasterRowEmpty)
                    (e.Cell as GridCellInfo).CellButtonRect = Rectangle.Empty;
            }
        }

        private void gvMain_ColumnFilterChanged(object sender, EventArgs e)
        {
            gvDetail.FindFilterText = gvMain.FindFilterText; //detail viewda da arama yapmak icin ekledim ama ise yaramazsa silebilirim.
        }

        #endregion    
    }
}