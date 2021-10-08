namespace Envanter.Modul_Stok
{
    partial class YeniKartEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvKartlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdKartlar = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnStokKartSec = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStokKartSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.ImageOptions.Image = global::Envanter.Properties.Resources.Kaydet24x24;
            this.btnEkle.Location = new System.Drawing.Point(414, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 32);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnVazgec);
            this.groupControl3.Controls.Add(this.btnEkle);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 441);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(632, 60);
            this.groupControl3.TabIndex = 1;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.ImageOptions.Image = global::Envanter.Properties.Resources.Kapat24x24;
            this.btnVazgec.Location = new System.Drawing.Point(523, 23);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(104, 32);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Vazgeç";
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.OptionsColumn.FixedWidth = true;
            this.colGrupAdi.OptionsColumn.ReadOnly = true;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 1;
            this.colGrupAdi.Width = 104;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.FixedWidth = true;
            this.colSeriNo.OptionsColumn.ReadOnly = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 2;
            this.colSeriNo.Width = 96;
            // 
            // colStokAdi
            // 
            this.colStokAdi.ColumnEdit = this.btnStokKartSec;
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ReadOnly = true;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 0;
            this.colStokAdi.Width = 252;
            // 
            // grvKartlar
            // 
            this.grvKartlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokAdi,
            this.colSeriNo,
            this.colGrupAdi,
            this.colPartNo,
            this.Durum});
            this.grvKartlar.GridControl = this.grdKartlar;
            this.grvKartlar.Name = "grvKartlar";
            this.grvKartlar.NewItemRowText = "Eklenecek kartların bilgilerini giriniz..";
            this.grvKartlar.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvKartlar.OptionsView.ShowGroupPanel = false;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowEdit = false;
            this.colPartNo.OptionsColumn.FixedWidth = true;
            this.colPartNo.OptionsColumn.ReadOnly = true;
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 3;
            this.colPartNo.Width = 96;
            // 
            // Durum
            // 
            this.Durum.Caption = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.Visible = true;
            this.Durum.VisibleIndex = 4;
            // 
            // grdKartlar
            // 
            this.grdKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKartlar.Location = new System.Drawing.Point(2, 20);
            this.grdKartlar.MainView = this.grvKartlar;
            this.grdKartlar.Name = "grdKartlar";
            this.grdKartlar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnStokKartSec});
            this.grdKartlar.Size = new System.Drawing.Size(628, 420);
            this.grdKartlar.TabIndex = 0;
            this.grdKartlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKartlar});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grdKartlar);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(632, 442);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kart Bilgileri";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // btnStokKartSec
            // 
            this.btnStokKartSec.AutoHeight = false;
            this.btnStokKartSec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnStokKartSec.Name = "btnStokKartSec";
            this.btnStokKartSec.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnStokKartSec_ButtonClick);
            // 
            // YeniKartEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 501);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "YeniKartEkle";
            this.Text = "Yeni Kart Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStokKartSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKartlar;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraGrid.GridControl grdKartlar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnStokKartSec;
    }
}