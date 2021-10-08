namespace Envanter.Modul_Stok
{
    partial class frmKartListesi
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
            this.components = new System.ComponentModel.Container();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdKartlar = new DevExpress.XtraGrid.GridControl();
            this.oemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetler = new Envanter.DataSetler();
            this.grvKartlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdSecilenKartlar = new DevExpress.XtraGrid.GridControl();
            this.kartListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvSecilen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecilenKartlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSecilen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grdKartlar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(632, 377);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Eklenebilir Kartlar";
            // 
            // grdKartlar
            // 
            this.grdKartlar.DataSource = this.oemBindingSource;
            this.grdKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKartlar.Location = new System.Drawing.Point(2, 20);
            this.grdKartlar.MainView = this.grvKartlar;
            this.grdKartlar.Name = "grdKartlar";
            this.grdKartlar.Size = new System.Drawing.Size(628, 355);
            this.grdKartlar.TabIndex = 0;
            this.grdKartlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKartlar});
            this.grdKartlar.DoubleClick += new System.EventHandler(this.grdKartlar_DoubleClick);
            // 
            // oemBindingSource
            // 
            this.oemBindingSource.DataMember = "Oem";
            this.oemBindingSource.DataSource = this.dataSetler;
            // 
            // dataSetler
            // 
            this.dataSetler.DataSetName = "DataSetler";
            this.dataSetler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grvKartlar
            // 
            this.grvKartlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokAdi,
            this.colSeriNo,
            this.colGrupAdi,
            this.colPartNo});
            this.grvKartlar.GridControl = this.grdKartlar;
            this.grvKartlar.Name = "grvKartlar";
            this.grvKartlar.OptionsView.ShowAutoFilterRow = true;
            this.grvKartlar.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ReadOnly = true;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 252;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.FixedWidth = true;
            this.colSeriNo.OptionsColumn.ReadOnly = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 3;
            this.colSeriNo.Width = 96;
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
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowEdit = false;
            this.colPartNo.OptionsColumn.FixedWidth = true;
            this.colPartNo.OptionsColumn.ReadOnly = true;
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 4;
            this.colPartNo.Width = 96;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdSecilenKartlar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 377);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(632, 251);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Seçilen Kartlar";
            // 
            // grdSecilenKartlar
            // 
            this.grdSecilenKartlar.DataSource = this.kartListesiBindingSource;
            this.grdSecilenKartlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSecilenKartlar.Location = new System.Drawing.Point(2, 20);
            this.grdSecilenKartlar.MainView = this.grvSecilen;
            this.grdSecilenKartlar.Name = "grdSecilenKartlar";
            this.grdSecilenKartlar.Size = new System.Drawing.Size(628, 229);
            this.grdSecilenKartlar.TabIndex = 1;
            this.grdSecilenKartlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSecilen});
            this.grdSecilenKartlar.DoubleClick += new System.EventHandler(this.grdSecilenKartlar_DoubleClick);
            // 
            // kartListesiBindingSource
            // 
            this.kartListesiBindingSource.DataMember = "KartListesi";
            this.kartListesiBindingSource.DataSource = this.dataSetler;
            // 
            // grvSecilen
            // 
            this.grvSecilen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grvSecilen.GridControl = this.grdSecilenKartlar;
            this.grvSecilen.Name = "grvSecilen";
            this.grvSecilen.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "StokAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 241;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "SeriNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 96;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "GrupAdi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 104;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "PartNo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 96;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnVazgec);
            this.groupControl3.Controls.Add(this.btnEkle);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 568);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(632, 60);
            this.groupControl3.TabIndex = 0;
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
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
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
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmKartListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVazgec;
            this.ClientSize = new System.Drawing.Size(632, 628);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKartListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kart Listesi";
            this.Load += new System.EventHandler(this.frmKartListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSecilenKartlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSecilen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grdKartlar;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKartlar;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.BindingSource oemBindingSource;
        private DataSetler dataSetler;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl grdSecilenKartlar;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSecilen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource kartListesiBindingSource;
    }
}