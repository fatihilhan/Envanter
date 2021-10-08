namespace Envanter.Modul_Stok
{
    partial class frmStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokHareketleri));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colTur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtHareketID = new DevExpress.XtraEditors.TextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartNo = new DevExpress.XtraEditors.TextEdit();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.stokHareketleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetler = new Envanter.DataSetler();
            this.grvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKurumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHareketID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // colTur
            // 
            this.colTur.FieldName = "Tur";
            this.colTur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTur.ImageOptions.Image")));
            this.colTur.MaxWidth = 70;
            this.colTur.MinWidth = 30;
            this.colTur.Name = "colTur";
            this.colTur.OptionsColumn.AllowEdit = false;
            this.colTur.OptionsColumn.AllowFocus = false;
            this.colTur.OptionsColumn.FixedWidth = true;
            this.colTur.Visible = true;
            this.colTur.VisibleIndex = 2;
            this.colTur.Width = 60;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1396, 736);
            this.splitContainerControl1.SplitterPosition = 197;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(197, 736);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.txtHareketID);
            this.xtraTabPage1.Controls.Add(this.btnPrint);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtPartNo);
            this.xtraTabPage1.Controls.Add(this.txtSeriNo);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(191, 708);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hareket Id";
            // 
            // btnTemizle
            // 
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.ImageOptions.Image = global::Envanter.Properties.Resources.Sil32x32;
            this.btnTemizle.Location = new System.Drawing.Point(98, 196);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 35);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtHareketID
            // 
            this.txtHareketID.Location = new System.Drawing.Point(11, 30);
            this.txtHareketID.Name = "txtHareketID";
            this.txtHareketID.Size = new System.Drawing.Size(171, 20);
            this.txtHareketID.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(11, 666);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(168, 35);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::Envanter.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 196);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(81, 35);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(11, 166);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(171, 20);
            this.txtPartNo.TabIndex = 3;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(11, 120);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(171, 20);
            this.txtSeriNo.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Part No";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 75);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(171, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Seri No";
            // 
            // Liste
            // 
            this.Liste.DataSource = this.stokHareketleriBindingSource;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(5, 0);
            this.Liste.MainView = this.grvMain;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1189, 736);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMain});
            // 
            // stokHareketleriBindingSource
            // 
            this.stokHareketleriBindingSource.DataMember = "StokHareketleri";
            this.stokHareketleriBindingSource.DataSource = this.dataSetler;
            // 
            // dataSetler
            // 
            this.dataSetler.DataSetName = "DataSetler";
            this.dataSetler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grvMain
            // 
            this.grvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStokID,
            this.colTarih,
            this.colTur,
            this.colDepoAdi,
            this.colKurumAdi,
            this.colGrupAdi,
            this.colStokAdi,
            this.colPartNo,
            this.colSeriNo,
            this.colAciklama});
            gridFormatRule1.Column = this.colTur;
            gridFormatRule1.Name = "Giris";
            formatConditionRuleExpression1.Expression = "[Tur] = \'Giriş\'";
            formatConditionRuleExpression1.PredefinedName = "Green Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.colTur;
            gridFormatRule2.Name = "Cikis";
            formatConditionRuleExpression2.Expression = "[Tur] = \'Çıkış\'";
            formatConditionRuleExpression2.PredefinedName = "Red Fill";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.Column = this.colTur;
            gridFormatRule3.Name = "Ikame";
            formatConditionRuleExpression3.Expression = "[Tur] = \'İkame\'";
            formatConditionRuleExpression3.PredefinedName = "Yellow Fill, Yellow Text";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.Column = this.colTur;
            gridFormatRule4.Name = "Oem";
            formatConditionRuleExpression4.Expression = "[Tur] = \'Oem\'";
            formatConditionRuleExpression4.PredefinedName = "Green Bold Text";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.grvMain.FormatRules.Add(gridFormatRule1);
            this.grvMain.FormatRules.Add(gridFormatRule2);
            this.grvMain.FormatRules.Add(gridFormatRule3);
            this.grvMain.FormatRules.Add(gridFormatRule4);
            this.grvMain.GridControl = this.Liste;
            this.grvMain.Name = "grvMain";
            this.grvMain.OptionsSelection.MultiSelect = true;
            this.grvMain.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.Caption = "Har. ID";
            this.colID.FieldName = "ID";
            this.colID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colID.ImageOptions.Image")));
            this.colID.MaxWidth = 75;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStokID.ImageOptions.Image")));
            this.colStokID.MaxWidth = 70;
            this.colStokID.Name = "colStokID";
            this.colStokID.OptionsColumn.AllowEdit = false;
            this.colStokID.OptionsColumn.AllowFocus = false;
            this.colStokID.OptionsColumn.FixedWidth = true;
            this.colStokID.Visible = true;
            this.colStokID.VisibleIndex = 1;
            this.colStokID.Width = 70;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTarih.ImageOptions.Image")));
            this.colTarih.MaxWidth = 90;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.AllowFocus = false;
            this.colTarih.OptionsColumn.FixedWidth = true;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            this.colTarih.Width = 90;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDepoAdi.ImageOptions.Image")));
            this.colDepoAdi.MaxWidth = 100;
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.OptionsColumn.AllowFocus = false;
            this.colDepoAdi.OptionsColumn.FixedWidth = true;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 4;
            this.colDepoAdi.Width = 80;
            // 
            // colKurumAdi
            // 
            this.colKurumAdi.FieldName = "KurumAdi";
            this.colKurumAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colKurumAdi.ImageOptions.Image")));
            this.colKurumAdi.MaxWidth = 250;
            this.colKurumAdi.Name = "colKurumAdi";
            this.colKurumAdi.OptionsColumn.AllowEdit = false;
            this.colKurumAdi.OptionsColumn.AllowFocus = false;
            this.colKurumAdi.OptionsColumn.FixedWidth = true;
            this.colKurumAdi.Visible = true;
            this.colKurumAdi.VisibleIndex = 5;
            this.colKurumAdi.Width = 180;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colGrupAdi.ImageOptions.Image")));
            this.colGrupAdi.MaxWidth = 110;
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.OptionsColumn.AllowFocus = false;
            this.colGrupAdi.OptionsColumn.FixedWidth = true;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 6;
            this.colGrupAdi.Width = 110;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colStokAdi.ImageOptions.Image")));
            this.colStokAdi.MinWidth = 90;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.AllowFocus = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 7;
            this.colStokAdi.Width = 90;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPartNo.ImageOptions.Image")));
            this.colPartNo.MaxWidth = 100;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowEdit = false;
            this.colPartNo.OptionsColumn.AllowFocus = false;
            this.colPartNo.OptionsColumn.FixedWidth = true;
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 8;
            this.colPartNo.Width = 100;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSeriNo.ImageOptions.Image")));
            this.colSeriNo.MaxWidth = 120;
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.AllowFocus = false;
            this.colSeriNo.OptionsColumn.FixedWidth = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 9;
            this.colSeriNo.Width = 120;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAciklama.ImageOptions.Image")));
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowFocus = false;
            this.colAciklama.OptionsColumn.FixedWidth = true;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 350;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 736);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // frmStokHareketleri
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1396, 736);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stok Hareketleri";
            this.Load += new System.EventHandler(this.frmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHareketID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.TextEdit txtHareketID;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPartNo;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMain;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DataSetler dataSetler;
        private System.Windows.Forms.BindingSource stokHareketleriBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTur;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKurumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
    }
}