
namespace BinanceApp.GUI
{
    partial class frmMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnListFollow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnConfigFx = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnConfigNotify = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBlackList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTop30 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListTrade = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRealTime = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtnListFollow,
            this.barButtonItem2,
            this.barBtnInfo,
            this.barBtnDashboard,
            this.barBtnConfigFx,
            this.barBtnConfigNotify,
            this.barBtnBlackList,
            this.barBtnTop30,
            this.barBtnListTrade,
            this.barBtnRealTime});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1022, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnListFollow
            // 
            this.barBtnListFollow.Caption = "Danh sách theo dõi";
            this.barBtnListFollow.Id = 1;
            this.barBtnListFollow.Name = "barBtnListFollow";
            this.barBtnListFollow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hỗ trợ";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = global::BinanceApp.Properties.Resources.telegram_64x64;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barBtnInfo
            // 
            this.barBtnInfo.Caption = "Tài khoản";
            this.barBtnInfo.Id = 3;
            this.barBtnInfo.Name = "barBtnInfo";
            this.barBtnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnInfo_ItemClick);
            // 
            // barBtnDashboard
            // 
            this.barBtnDashboard.Caption = "Dashboard";
            this.barBtnDashboard.Id = 4;
            this.barBtnDashboard.Name = "barBtnDashboard";
            // 
            // barBtnConfigFx
            // 
            this.barBtnConfigFx.Caption = "Cấu hình chỉ báo";
            this.barBtnConfigFx.Id = 5;
            this.barBtnConfigFx.Name = "barBtnConfigFx";
            this.barBtnConfigFx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnConfigFx_ItemClick);
            // 
            // barBtnConfigNotify
            // 
            this.barBtnConfigNotify.Caption = "Cấu hình thông báo";
            this.barBtnConfigNotify.Id = 6;
            this.barBtnConfigNotify.Name = "barBtnConfigNotify";
            // 
            // barBtnBlackList
            // 
            this.barBtnBlackList.Caption = "Danh sách đen";
            this.barBtnBlackList.Id = 7;
            this.barBtnBlackList.Name = "barBtnBlackList";
            this.barBtnBlackList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBlackList_ItemClick);
            // 
            // barBtnTop30
            // 
            this.barBtnTop30.Caption = "Top30";
            this.barBtnTop30.Id = 8;
            this.barBtnTop30.Name = "barBtnTop30";
            this.barBtnTop30.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTop30_ItemClick);
            // 
            // barBtnListTrade
            // 
            this.barBtnListTrade.Caption = "Danh sách Trade";
            this.barBtnListTrade.Id = 9;
            this.barBtnListTrade.Name = "barBtnListTrade";
            this.barBtnListTrade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListTrade_ItemClick);
            // 
            // barBtnRealTime
            // 
            this.barBtnRealTime.Caption = "Thời gian thực";
            this.barBtnRealTime.Id = 10;
            this.barBtnRealTime.Name = "barBtnRealTime";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnInfo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thông tin";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDashboard);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnTop30);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnRealTime);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thống kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnListTrade);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnListFollow);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnBlackList);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Sở hữu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnConfigFx);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnConfigNotify);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Cài đặt";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 743);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1022, 24);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // tabControl
            // 
            this.tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 158);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1022, 585);
            this.tabControl.TabIndex = 2;
            this.tabControl.CloseButtonClick += new System.EventHandler(this.tabControl_CloseButtonClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 767);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnListFollow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barBtnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem barBtnDashboard;
        private DevExpress.XtraBars.BarButtonItem barBtnConfigFx;
        private DevExpress.XtraBars.BarButtonItem barBtnConfigNotify;
        private DevExpress.XtraBars.BarButtonItem barBtnBlackList;
        private DevExpress.XtraBars.BarButtonItem barBtnTop30;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem barBtnListTrade;
        private DevExpress.XtraBars.BarButtonItem barBtnRealTime;
    }
}