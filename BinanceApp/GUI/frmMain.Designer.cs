
using DevExpress.LookAndFeel;

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
            this.barBtnStart = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStop = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupSupport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barBtnRealTime,
            this.barBtnStart,
            this.barBtnStop});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
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
            this.barBtnListFollow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListFollow_ItemClick);
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
            this.barBtnRealTime.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRealTime_ItemClick);
            // 
            // barBtnStart
            // 
            this.barBtnStart.Caption = "Start";
            this.barBtnStart.Id = 11;
            this.barBtnStart.Name = "barBtnStart";
            this.barBtnStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStart_ItemClick);
            // 
            // barBtnStop
            // 
            this.barBtnStop.Caption = "Stop";
            this.barBtnStop.Enabled = false;
            this.barBtnStop.Id = 12;
            this.barBtnStop.Name = "barBtnStop";
            this.barBtnStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStop_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroup1,
            this.ribbonGroup2,
            this.ribbonGroupSupport,
            this.ribbonGroup3,
            this.ribbonGroup4,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.ItemLinks.Add(this.barBtnInfo);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Thông tin";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.ItemLinks.Add(this.barBtnDashboard);
            this.ribbonGroup2.ItemLinks.Add(this.barBtnTop30);
            this.ribbonGroup2.ItemLinks.Add(this.barBtnRealTime);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Thống kê";
            // 
            // ribbonGroupSupport
            // 
            this.ribbonGroupSupport.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonGroupSupport.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonGroupSupport.ItemLinks.Add(this.barButtonItem2);
            this.ribbonGroupSupport.Name = "ribbonGroupSupport";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.ItemLinks.Add(this.barBtnListTrade);
            this.ribbonGroup3.ItemLinks.Add(this.barBtnListFollow);
            this.ribbonGroup3.ItemLinks.Add(this.barBtnBlackList);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Sở hữu";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.ItemLinks.Add(this.barBtnConfigFx);
            this.ribbonGroup4.ItemLinks.Add(this.barBtnConfigNotify);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Cài đặt";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStart);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStop);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Action";
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
            this.tabControl.LookAndFeel.SkinName = "McSkin";
            this.tabControl.LookAndFeel.UseDefaultLookAndFeel = false;
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupSupport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtnListFollow;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barBtnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem barBtnDashboard;
        private DevExpress.XtraBars.BarButtonItem barBtnConfigFx;
        private DevExpress.XtraBars.BarButtonItem barBtnConfigNotify;
        private DevExpress.XtraBars.BarButtonItem barBtnBlackList;
        private DevExpress.XtraBars.BarButtonItem barBtnTop30;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroup4;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem barBtnListTrade;
        private DevExpress.XtraBars.BarButtonItem barBtnRealTime;
        private DevExpress.XtraBars.BarButtonItem barBtnStart;
        private DevExpress.XtraBars.BarButtonItem barBtnStop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}