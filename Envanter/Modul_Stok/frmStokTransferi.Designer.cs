namespace Envanter.Modul_Stok
{
    partial class frmStokTransferi
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokTransferi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.X = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOemSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stokTransferiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetler = new Envanter.DataSetler();
            this.oemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStokEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.DepoBilgisi = new DevExpress.XtraTab.XtraTabPage();
            this.txtHareketTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtKaynakDepo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtHedefDepo = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOemSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTransferiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.DepoBilgisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHareketTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaynakDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.colOemID,
            this.colStokAdi,
            this.colSeriNo,
            this.colGrupAdi,
            this.colPartNo,
            this.X});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 51;
            this.ID.MinWidth = 21;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 31;
            // 
            // colOemID
            // 
            this.colOemID.Caption = "OemID";
            this.colOemID.FieldName = "OemID";
            this.colOemID.Name = "colOemID";
            this.colOemID.OptionsColumn.AllowEdit = false;
            this.colOemID.OptionsColumn.AllowFocus = false;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 21;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.AllowFocus = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 244;
            // 
            // colSeriNo
            // 
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.MaxWidth = 111;
            this.colSeriNo.MinWidth = 21;
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            this.colSeriNo.OptionsColumn.AllowFocus = false;
            this.colSeriNo.OptionsColumn.FixedWidth = true;
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 2;
            this.colSeriNo.Width = 110;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.MaxWidth = 103;
            this.colGrupAdi.MinWidth = 21;
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.OptionsColumn.AllowFocus = false;
            this.colGrupAdi.OptionsColumn.FixedWidth = true;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 4;
            this.colGrupAdi.Width = 100;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.MaxWidth = 103;
            this.colPartNo.MinWidth = 21;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.OptionsColumn.AllowEdit = false;
            this.colPartNo.OptionsColumn.AllowFocus = false;
            this.colPartNo.OptionsColumn.FixedWidth = true;
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 3;
            this.colPartNo.Width = 95;
            // 
            // X
            // 
            this.X.Caption = "X";
            this.X.ColumnEdit = this.btnOemSil;
            this.X.MaxWidth = 17;
            this.X.MinWidth = 17;
            this.X.Name = "X";
            this.X.OptionsColumn.FixedWidth = true;
            this.X.Visible = true;
            this.X.VisibleIndex = 5;
            this.X.Width = 17;
            // 
            // btnOemSil
            // 
            this.btnOemSil.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnOemSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnOemSil.Name = "btnOemSil";
            this.btnOemSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOemSil.Click += new System.EventHandler(this.btnOemSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stokTransferiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnOemSil});
            this.gridControl1.Size = new System.Drawing.Size(615, 399);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stokTransferiBindingSource
            // 
            this.stokTransferiBindingSource.DataMember = "StokTransferi";
            this.stokTransferiBindingSource.DataSource = this.dataSetler;
            // 
            // dataSetler
            // 
            this.dataSetler.DataSetName = "DataSetler";
            this.dataSetler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oemBindingSource
            // 
            this.oemBindingSource.DataMember = "Oem";
            this.oemBindingSource.DataSource = this.dataSetler;
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokEkle.ImageOptions.Image")));
            this.btnStokEkle.Location = new System.Drawing.Point(455, 91);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(77, 20);
            this.btnStokEkle.TabIndex = 5;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDegistir.ImageOptions.Image")));
            this.btnDegistir.Location = new System.Drawing.Point(538, 48);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(77, 18);
            this.btnDegistir.TabIndex = 7;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
            this.btnYeni.Location = new System.Drawing.Point(538, 93);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(77, 18);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(538, 71);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 18);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(538, 25);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 18);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 28);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Hareket Tipi :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 96);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Tarih :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 73);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Hedef Depo :";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = "";
            this.txtTarih.Location = new System.Drawing.Point(88, 93);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.BeepOnError = false;
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.MaskSettings.Set("mask", "d");
            this.txtTarih.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.txtTarih.Size = new System.Drawing.Size(171, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 50);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Kaynak Depo :";
            // 
            // DepoBilgisi
            // 
            this.DepoBilgisi.Controls.Add(this.gridControl1);
            this.DepoBilgisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepoBilgisi.Name = "DepoBilgisi";
            this.DepoBilgisi.Size = new System.Drawing.Size(615, 399);
            this.DepoBilgisi.Text = "Depo Bilgisi";
            // 
            // txtHareketTipi
            // 
            this.txtHareketTipi.EditValue = "Giriş";
            this.txtHareketTipi.Location = new System.Drawing.Point(88, 25);
            this.txtHareketTipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHareketTipi.Name = "txtHareketTipi";
            this.txtHareketTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHareketTipi.Properties.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış",
            "İkame",
            "Depoya Transfer"});
            this.txtHareketTipi.Size = new System.Drawing.Size(171, 20);
            this.txtHareketTipi.TabIndex = 0;
            this.txtHareketTipi.SelectedIndexChanged += new System.EventHandler(this.txtHareketTipi_SelectedIndexChanged);
            // 
            // txtKaynakDepo
            // 
            this.txtKaynakDepo.Location = new System.Drawing.Point(88, 48);
            this.txtKaynakDepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKaynakDepo.Name = "txtKaynakDepo";
            this.txtKaynakDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKaynakDepo.Size = new System.Drawing.Size(171, 20);
            this.txtKaynakDepo.TabIndex = 1;
            this.txtKaynakDepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKaynakDepo_ButtonClick);
            // 
            // txtHedefDepo
            // 
            this.txtHedefDepo.EditValue = " ";
            this.txtHedefDepo.Location = new System.Drawing.Point(88, 71);
            this.txtHedefDepo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHedefDepo.Name = "txtHedefDepo";
            this.txtHedefDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHedefDepo.Size = new System.Drawing.Size(171, 20);
            this.txtHedefDepo.TabIndex = 2;
            this.txtHedefDepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHedefDepo_ButtonClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 117);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.DepoBilgisi;
            this.xtraTabControl1.Size = new System.Drawing.Size(621, 427);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.DepoBilgisi});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnStokEkle);
            this.groupControl1.Controls.Add(this.btnDegistir);
            this.groupControl1.Controls.Add(this.btnYeni);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.txtHareketTipi);
            this.groupControl1.Controls.Add(this.txtKaynakDepo);
            this.groupControl1.Controls.Add(this.txtHedefDepo);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 117);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Transfer Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(265, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(265, 45);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(185, 66);
            this.txtAciklama.TabIndex = 4;
            // 
            // frmStokTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 544);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmStokTransferi.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokTransferi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stok Transferi";
            this.Load += new System.EventHandler(this.frmStokTransferi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOemSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTransferiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.DepoBilgisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHareketTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKaynakDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHedefDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource oemBindingSource;
        private DataSetler dataSetler;
        private DevExpress.XtraEditors.SimpleButton btnStokEkle;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabPage DepoBilgisi;
        private DevExpress.XtraEditors.ComboBoxEdit txtHareketTipi;
        private DevExpress.XtraEditors.ButtonEdit txtKaynakDepo;
        private DevExpress.XtraEditors.ButtonEdit txtHedefDepo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOemSil;
        private DevExpress.XtraGrid.Columns.GridColumn X;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colOemID;
        private System.Windows.Forms.BindingSource stokTransferiBindingSource;
    }
}