namespace Envanter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokKartlari = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barBtnCariKartAc = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCariListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKurumlar = new DevExpress.XtraBars.BarButtonItem();
            this.batBtnDepoTanimlama = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barTxtDatabase = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ALC = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.barTxtUser = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtnStoklar,
            this.barBtnStokListesi,
            this.barBtnStokGruplari,
            this.barBtnStokHareketleri,
            this.barBtnStokKartlari,
            this.skinDropDownButtonItem1,
            this.barBtnCariKartAc,
            this.barBtnCariListesi,
            this.barBtnKurumlar,
            this.batBtnDepoTanimlama,
            this.barButtonItem1,
            this.barTxtDatabase,
            this.barTxtUser});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.QuickToolbarItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbon.Size = new System.Drawing.Size(876, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnStoklar
            // 
            this.barBtnStoklar.Caption = "Stoklar";
            this.barBtnStoklar.Id = 4;
            this.barBtnStoklar.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Stok_Acilis_Karti_Icon;
            this.barBtnStoklar.LargeWidth = 60;
            this.barBtnStoklar.Name = "barBtnStoklar";
            this.barBtnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStoklar_ItemClick);
            // 
            // barBtnStokListesi
            // 
            this.barBtnStokListesi.Caption = "Stok Listesi";
            this.barBtnStokListesi.Id = 5;
            this.barBtnStokListesi.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Stok_Liste;
            this.barBtnStokListesi.Name = "barBtnStokListesi";
            this.barBtnStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokListesi_ItemClick);
            // 
            // barBtnStokGruplari
            // 
            this.barBtnStokGruplari.Caption = "Stok Grupları";
            this.barBtnStokGruplari.Id = 6;
            this.barBtnStokGruplari.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Stok_Grup32x32;
            this.barBtnStokGruplari.Name = "barBtnStokGruplari";
            this.barBtnStokGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokGruplari_ItemClick);
            // 
            // barBtnStokHareketleri
            // 
            this.barBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.barBtnStokHareketleri.Id = 7;
            this.barBtnStokHareketleri.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Stok_Hareket;
            this.barBtnStokHareketleri.Name = "barBtnStokHareketleri";
            this.barBtnStokHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokHareketleri_ItemClick);
            // 
            // barBtnStokKartlari
            // 
            this.barBtnStokKartlari.Caption = "Stok Kartları";
            this.barBtnStokKartlari.Id = 8;
            this.barBtnStokKartlari.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Stok32x32;
            this.barBtnStokKartlari.Name = "barBtnStokKartlari";
            this.barBtnStokKartlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKartlari_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 9;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barBtnCariKartAc
            // 
            this.barBtnCariKartAc.Caption = "Cari Açılış Kartı";
            this.barBtnCariKartAc.Id = 10;
            this.barBtnCariKartAc.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Cari_Kart32x32;
            this.barBtnCariKartAc.Name = "barBtnCariKartAc";
            this.barBtnCariKartAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariKartAc_ItemClick);
            // 
            // barBtnCariListesi
            // 
            this.barBtnCariListesi.Caption = "Cari Listesi";
            this.barBtnCariListesi.Id = 11;
            this.barBtnCariListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCariListesi.ImageOptions.Image")));
            this.barBtnCariListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCariListesi.ImageOptions.LargeImage")));
            this.barBtnCariListesi.Name = "barBtnCariListesi";
            this.barBtnCariListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCariListesi_ItemClick);
            // 
            // barBtnKurumlar
            // 
            this.barBtnKurumlar.Caption = "Kurumlar";
            this.barBtnKurumlar.Id = 12;
            this.barBtnKurumlar.ImageOptions.LargeImage = global::Envanter.Properties.Resources.Banka_Acilis_Karti;
            this.barBtnKurumlar.Name = "barBtnKurumlar";
            this.barBtnKurumlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHastaneler_ItemClick);
            // 
            // batBtnDepoTanimlama
            // 
            this.batBtnDepoTanimlama.Caption = "Depo Tanımlama";
            this.batBtnDepoTanimlama.Id = 13;
            this.batBtnDepoTanimlama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("batBtnDepoTanimlama.ImageOptions.Image")));
            this.batBtnDepoTanimlama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("batBtnDepoTanimlama.ImageOptions.LargeImage")));
            this.batBtnDepoTanimlama.Name = "batBtnDepoTanimlama";
            this.batBtnDepoTanimlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batBtnDepoTanimlama_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Stok Transferi";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barTxtDatabase
            // 
            this.barTxtDatabase.Caption = "Database: ";
            this.barTxtDatabase.Id = 15;
            this.barTxtDatabase.Name = "barTxtDatabase";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnStokKartlari);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnStokGruplari);
            this.ribbonPageGroup2.ItemLinks.Add(this.batBtnDepoTanimlama);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Stok Tanımları";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cari";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnCariKartAc);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnKurumlar);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnCariListesi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Cari İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Onarım";
            this.ribbonPage3.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Elektronik";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Coil";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barTxtDatabase);
            this.ribbonStatusBar.ItemLinks.Add(this.barTxtUser);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(876, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barTxtUser
            // 
            this.barTxtUser.Caption = "Kullanıcı: ";
            this.barTxtUser.Id = 17;
            this.barTxtUser.Name = "barTxtUser";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 534);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Renova Envanter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnStoklar;
        private DevExpress.XtraBars.BarButtonItem barBtnStokListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnStokGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Alerter.AlertControl ALC;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKartlari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnCariKartAc;
        private DevExpress.XtraBars.BarButtonItem barBtnCariListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnKurumlar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem batBtnDepoTanimlama;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarStaticItem barTxtDatabase;
        private DevExpress.XtraBars.BarStaticItem barTxtUser;
    }
}