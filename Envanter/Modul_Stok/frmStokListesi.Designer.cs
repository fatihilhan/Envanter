namespace Envanter.Modul_Stok
{
    partial class frmStokListesi
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression7 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression8 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule9 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression9 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule10 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression10 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule11 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression11 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule12 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression12 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.colDurum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.stoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetler = new Envanter.DataSetler();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stoklarStokDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDepo = new DevExpress.XtraEditors.LookUpEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.stoklarTableAdapter = new Envanter.DataSetlerTableAdapters.StokMasterTableAdapter();
            this.stokDetayTableAdapter1 = new Envanter.DataSetlerTableAdapters.StokDetayTableAdapter();
            this.colSubID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOemID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarStokDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colDurum1
            // 
            this.colDurum1.FieldName = "Durum";
            this.colDurum1.MaxWidth = 90;
            this.colDurum1.Name = "colDurum1";
            this.colDurum1.OptionsColumn.AllowEdit = false;
            this.colDurum1.OptionsColumn.AllowFocus = false;
            this.colDurum1.OptionsColumn.FixedWidth = true;
            this.colDurum1.Visible = true;
            this.colDurum1.VisibleIndex = 5;
            this.colDurum1.Width = 90;
            // 
            // gvDetail
            // 
            this.gvDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colGrupAdi1,
            this.colStokAdi1,
            this.colSeriNo1,
            this.colPartNo1,
            this.colDurum1,
            this.colAciklama1});
            gridFormatRule7.Column = this.colDurum1;
            gridFormatRule7.Name = "Tested Ok";
            formatConditionRuleExpression7.Expression = "[Durum] = \'Tested OK\'";
            formatConditionRuleExpression7.PredefinedName = "Green Fill";
            gridFormatRule7.Rule = formatConditionRuleExpression7;
            gridFormatRule8.Column = this.colDurum1;
            gridFormatRule8.Name = "Defective";
            formatConditionRuleExpression8.Expression = "[Durum] = \'Defective\'";
            formatConditionRuleExpression8.PredefinedName = "Red Fill";
            gridFormatRule8.Rule = formatConditionRuleExpression8;
            gridFormatRule9.Column = this.colDurum1;
            gridFormatRule9.Name = "Unknown";
            formatConditionRuleExpression9.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            formatConditionRuleExpression9.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression9.Expression = "[Durum] = \'Unknown\'";
            formatConditionRuleExpression9.PredefinedName = "Yellow Fill, Yellow Text";
            gridFormatRule9.Rule = formatConditionRuleExpression9;
            this.gvDetail.FormatRules.Add(gridFormatRule7);
            this.gvDetail.FormatRules.Add(gridFormatRule8);
            this.gvDetail.FormatRules.Add(gridFormatRule9);
            this.gvDetail.GridControl = this.Liste;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvDetail.OptionsPrint.PrintFooter = false;
            this.gvDetail.OptionsPrint.PrintGroupFooter = false;
            this.gvDetail.OptionsPrint.PrintHeader = false;
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.MaxWidth = 75;
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.AllowFocus = false;
            this.colID1.OptionsColumn.FixedWidth = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colGrupAdi1
            // 
            this.colGrupAdi1.FieldName = "GrupAdi";
            this.colGrupAdi1.MaxWidth = 150;
            this.colGrupAdi1.Name = "colGrupAdi1";
            this.colGrupAdi1.OptionsColumn.AllowEdit = false;
            this.colGrupAdi1.OptionsColumn.AllowFocus = false;
            this.colGrupAdi1.Visible = true;
            this.colGrupAdi1.VisibleIndex = 1;
            this.colGrupAdi1.Width = 80;
            // 
            // colStokAdi1
            // 
            this.colStokAdi1.FieldName = "StokAdi";
            this.colStokAdi1.Name = "colStokAdi1";
            this.colStokAdi1.OptionsColumn.AllowEdit = false;
            this.colStokAdi1.OptionsColumn.AllowFocus = false;
            this.colStokAdi1.Visible = true;
            this.colStokAdi1.VisibleIndex = 2;
            this.colStokAdi1.Width = 232;
            // 
            // colSeriNo1
            // 
            this.colSeriNo1.FieldName = "SeriNo";
            this.colSeriNo1.MaxWidth = 200;
            this.colSeriNo1.Name = "colSeriNo1";
            this.colSeriNo1.OptionsColumn.AllowEdit = false;
            this.colSeriNo1.OptionsColumn.AllowFocus = false;
            this.colSeriNo1.OptionsColumn.FixedWidth = true;
            this.colSeriNo1.Visible = true;
            this.colSeriNo1.VisibleIndex = 3;
            this.colSeriNo1.Width = 90;
            // 
            // colPartNo1
            // 
            this.colPartNo1.FieldName = "PartNo";
            this.colPartNo1.Name = "colPartNo1";
            this.colPartNo1.OptionsColumn.AllowEdit = false;
            this.colPartNo1.OptionsColumn.AllowFocus = false;
            this.colPartNo1.OptionsColumn.FixedWidth = true;
            this.colPartNo1.Visible = true;
            this.colPartNo1.VisibleIndex = 4;
            this.colPartNo1.Width = 90;
            // 
            // colAciklama1
            // 
            this.colAciklama1.FieldName = "Aciklama";
            this.colAciklama1.Name = "colAciklama1";
            this.colAciklama1.OptionsColumn.AllowEdit = false;
            this.colAciklama1.OptionsColumn.AllowFocus = false;
            this.colAciklama1.Visible = true;
            this.colAciklama1.VisibleIndex = 6;
            this.colAciklama1.Width = 189;
            // 
            // Liste
            // 
            this.Liste.DataSource = this.stoklarBindingSource;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.gvDetail;
            gridLevelNode2.RelationName = "Stoklar_StokDetay";
            this.Liste.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.Liste.Location = new System.Drawing.Point(5, 0);
            this.Liste.MainView = this.gvMain;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(859, 578);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain,
            this.gvDetail});
            // 
            // stoklarBindingSource
            // 
            this.stoklarBindingSource.DataMember = "StokMaster";
            this.stoklarBindingSource.DataSource = this.dataSetler;
            // 
            // dataSetler
            // 
            this.dataSetler.DataSetName = "DataSetler";
            this.dataSetler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokAdi,
            this.colGrupAdi,
            this.colSeriNo,
            this.colPartNo,
            this.colDurum,
            this.colAciklama,
            this.colDepoAdi});
            gridFormatRule10.Column = this.colDurum;
            gridFormatRule10.Name = "Tested OK";
            formatConditionRuleExpression10.Expression = "[Durum] = \'Tested OK\'";
            formatConditionRuleExpression10.PredefinedName = "Green Fill";
            gridFormatRule10.Rule = formatConditionRuleExpression10;
            gridFormatRule11.Column = this.colDurum;
            gridFormatRule11.Name = "Defective";
            formatConditionRuleExpression11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression11.Appearance.Options.UseFont = true;
            formatConditionRuleExpression11.Expression = "[Durum] = \'Defective\'";
            formatConditionRuleExpression11.PredefinedName = "Red Fill";
            gridFormatRule11.Rule = formatConditionRuleExpression11;
            gridFormatRule12.Column = this.colDurum;
            gridFormatRule12.Name = "Unknown";
            formatConditionRuleExpression12.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            formatConditionRuleExpression12.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression12.Expression = "[Durum] = \'Unknown\'";
            formatConditionRuleExpression12.PredefinedName = "Yellow Fill, Yellow Text";
            gridFormatRule12.Rule = formatConditionRuleExpression12;
            this.gvMain.FormatRules.Add(gridFormatRule10);
            this.gvMain.FormatRules.Add(gridFormatRule11);
            this.gvMain.FormatRules.Add(gridFormatRule12);
            this.gvMain.GridControl = this.Liste;
            this.gvMain.GroupPanelText = "Gruplamak istediğiniz kategoriyi buraya sürükleyin";
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsDetail.ShowDetailTabs = false;
            this.gvMain.OptionsPrint.ExpandAllDetails = true;
            this.gvMain.OptionsPrint.PrintDetails = true;
            this.gvMain.OptionsSelection.MultiSelect = true;
            this.gvMain.OptionsView.ShowAutoFilterRow = true;
            this.gvMain.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gvMain_CellMerge);
            this.gvMain.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvMain_CustomDrawCell);
            this.gvMain.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gvMain.ColumnFilterChanged += new System.EventHandler(this.gvMain_ColumnFilterChanged);
            this.gvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvMain_MouseDown);
            this.gvMain.DoubleClick += new System.EventHandler(this.gvMain_DoubleClick);
            // 
            // colID
            // 
            this.colID.Caption = "Stok ID";
            this.colID.FieldName = "ID";
            this.colID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colID.ImageOptions.Image")));
            this.colID.MaxWidth = 100;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStokAdi.ImageOptions.Image")));
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.AllowFocus = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 190;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGrupAdi.ImageOptions.Image")));
            this.colGrupAdi.MaxWidth = 150;
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.OptionsColumn.AllowFocus = false;
            this.colGrupAdi.OptionsColumn.FixedWidth = true;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 2;
            this.colGrupAdi.Width = 120;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSeriNo.ImageOptions.Image")));
            this.colSeriNo.MaxWidth = 200;
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.AllowFocus = false;
            this.colSeriNo.OptionsColumn.FixedWidth = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 3;
            this.colSeriNo.Width = 120;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPartNo.ImageOptions.Image")));
            this.colPartNo.MaxWidth = 120;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowEdit = false;
            this.colPartNo.OptionsColumn.AllowFocus = false;
            this.colPartNo.OptionsColumn.FixedWidth = true;
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 4;
            this.colPartNo.Width = 90;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDurum.ImageOptions.Image")));
            this.colDurum.MaxWidth = 75;
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.OptionsColumn.AllowFocus = false;
            this.colDurum.OptionsColumn.FixedWidth = true;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 5;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAciklama.ImageOptions.Image")));
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowFocus = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            this.colAciklama.Width = 96;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDepoAdi.ImageOptions.Image")));
            this.colDepoAdi.MaxWidth = 75;
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.OptionsColumn.AllowFocus = false;
            this.colDepoAdi.OptionsColumn.FixedWidth = true;
            this.colDepoAdi.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 7;
            // 
            // stoklarStokDetayBindingSource
            // 
            this.stoklarStokDetayBindingSource.DataMember = "Stoklar_StokDetay";
            this.stoklarStokDetayBindingSource.DataSource = this.stoklarBindingSource;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 578);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.ImageOptions.Image = global::Envanter.Properties.Resources.Sil32x32;
            this.btnTemizle.Location = new System.Drawing.Point(98, 236);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 35);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(11, 74);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(168, 20);
            this.txtStokKodu.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::Envanter.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 236);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(81, 35);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(11, 164);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(168, 20);
            this.txtSeriNo.TabIndex = 2;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 119);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(168, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Seri No";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.btnPrint);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtPartNo);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtSeriNo);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.cbxDepo);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(191, 550);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(11, 508);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(168, 35);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(11, 210);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(168, 20);
            this.txtPartNo.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Depo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 191);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Part No";
            // 
            // cbxDepo
            // 
            this.cbxDepo.Location = new System.Drawing.Point(11, 29);
            this.cbxDepo.Name = "cbxDepo";
            this.cbxDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepo.Properties.DropDownRows = 4;
            this.cbxDepo.Properties.NullText = "";
            this.cbxDepo.Properties.PopupSizeable = false;
            this.cbxDepo.Size = new System.Drawing.Size(168, 20);
            this.cbxDepo.TabIndex = 3;
            this.cbxDepo.EditValueChanged += new System.EventHandler(this.cbxDepo_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(197, 578);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitterControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1066, 578);
            this.splitContainerControl1.SplitterPosition = 197;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // stoklarTableAdapter
            // 
            this.stoklarTableAdapter.ClearBeforeFill = true;
            // 
            // stokDetayTableAdapter1
            // 
            this.stokDetayTableAdapter1.ClearBeforeFill = true;
            // 
            // colSubID
            // 
            this.colSubID.FieldName = "ID";
            this.colSubID.MaxWidth = 40;
            this.colSubID.Name = "colSubID";
            this.colSubID.OptionsColumn.AllowEdit = false;
            this.colSubID.OptionsColumn.AllowFocus = false;
            this.colSubID.OptionsColumn.FixedWidth = true;
            this.colSubID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colSubID.Visible = true;
            this.colSubID.VisibleIndex = 0;
            this.colSubID.Width = 40;
            // 
            // colOemID1
            // 
            this.colOemID1.FieldName = "ID";
            this.colOemID1.Name = "colOemID1";
            this.colOemID1.OptionsColumn.AllowEdit = false;
            this.colOemID1.OptionsColumn.AllowFocus = false;
            this.colOemID1.OptionsColumn.FixedWidth = true;
            // 
            // colSubStokAdi
            // 
            this.colSubStokAdi.FieldName = "StokAdi";
            this.colSubStokAdi.Name = "colSubStokAdi";
            this.colSubStokAdi.OptionsColumn.AllowEdit = false;
            this.colSubStokAdi.OptionsColumn.AllowFocus = false;
            this.colSubStokAdi.Visible = true;
            this.colSubStokAdi.VisibleIndex = 1;
            this.colSubStokAdi.Width = 250;
            // 
            // colSubGrupAdi
            // 
            this.colSubGrupAdi.FieldName = "GrupAdi";
            this.colSubGrupAdi.MaxWidth = 150;
            this.colSubGrupAdi.Name = "colSubGrupAdi";
            this.colSubGrupAdi.OptionsColumn.AllowEdit = false;
            this.colSubGrupAdi.OptionsColumn.AllowFocus = false;
            this.colSubGrupAdi.OptionsColumn.FixedWidth = true;
            this.colSubGrupAdi.Visible = true;
            this.colSubGrupAdi.VisibleIndex = 2;
            // 
            // colSubSeriNo
            // 
            this.colSubSeriNo.FieldName = "SeriNo";
            this.colSubSeriNo.MaxWidth = 150;
            this.colSubSeriNo.Name = "colSubSeriNo";
            this.colSubSeriNo.OptionsColumn.AllowEdit = false;
            this.colSubSeriNo.OptionsColumn.AllowFocus = false;
            this.colSubSeriNo.OptionsColumn.FixedWidth = true;
            this.colSubSeriNo.Visible = true;
            this.colSubSeriNo.VisibleIndex = 3;
            // 
            // colSubPartNo
            // 
            this.colSubPartNo.FieldName = "PartNo";
            this.colSubPartNo.MaxWidth = 90;
            this.colSubPartNo.Name = "colSubPartNo";
            this.colSubPartNo.OptionsColumn.AllowEdit = false;
            this.colSubPartNo.OptionsColumn.AllowFocus = false;
            this.colSubPartNo.OptionsColumn.FixedWidth = true;
            this.colSubPartNo.Visible = true;
            this.colSubPartNo.VisibleIndex = 4;
            this.colSubPartNo.Width = 90;
            // 
            // colSubDurum
            // 
            this.colSubDurum.FieldName = "Durum";
            this.colSubDurum.MaxWidth = 75;
            this.colSubDurum.Name = "colSubDurum";
            this.colSubDurum.OptionsColumn.AllowEdit = false;
            this.colSubDurum.OptionsColumn.AllowFocus = false;
            this.colSubDurum.OptionsColumn.FixedWidth = true;
            this.colSubDurum.Visible = true;
            this.colSubDurum.VisibleIndex = 5;
            // 
            // colSubAciklama
            // 
            this.colSubAciklama.FieldName = "Aciklama";
            this.colSubAciklama.Name = "colSubAciklama";
            this.colSubAciklama.OptionsColumn.AllowEdit = false;
            this.colSubAciklama.OptionsColumn.AllowFocus = false;
            this.colSubAciklama.Visible = true;
            this.colSubAciklama.VisibleIndex = 6;
            this.colSubAciklama.Width = 236;
            // 
            // frmStokListesi
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1066, 578);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmStokListesi.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoklarStokDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txtPartNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DataSetler dataSetler;
        private System.Windows.Forms.BindingSource stoklarBindingSource;
        private DataSetlerTableAdapters.StokMasterTableAdapter stoklarTableAdapter;
        private DataSetlerTableAdapters.StokDetayTableAdapter stokDetayTableAdapter1;
        private DevExpress.XtraEditors.LookUpEdit cbxDepo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colSubID;
        private DevExpress.XtraGrid.Columns.GridColumn colOemID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSubGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSubSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSubPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSubDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colSubAciklama;
        private System.Windows.Forms.BindingSource stoklarStokDetayBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum1;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama1;
    }
}