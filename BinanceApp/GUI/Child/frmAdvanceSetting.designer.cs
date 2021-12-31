namespace BinanceApp.GUI.Child
{
    partial class frmAdvanceSetting
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
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tab1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl5 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab6 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl6 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnl2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddSignal = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chkState = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab5.SuspendLayout();
            this.tab6.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkAndSave.Location = new System.Drawing.Point(666, 555);
            this.btnOkAndSave.Name = "btnOkAndSave";
            this.btnOkAndSave.Size = new System.Drawing.Size(109, 32);
            this.btnOkAndSave.TabIndex = 11;
            this.btnOkAndSave.Text = "Lưu cấu hình";
            this.btnOkAndSave.Click += new System.EventHandler(this.btnOkAndSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.chkState);
            this.groupControl1.Controls.Add(this.tabMain);
            this.groupControl1.Controls.Add(this.btnAddSignal);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(899, 529);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Thiết lập";
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tab1);
            this.tabMain.Controls.Add(this.tab4);
            this.tabMain.Controls.Add(this.tab3);
            this.tabMain.Controls.Add(this.tab5);
            this.tabMain.Controls.Add(this.tab6);
            this.tabMain.Controls.Add(this.tab2);
            this.tabMain.Location = new System.Drawing.Point(0, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tab1,
            this.tab2,
            this.tab3,
            this.tab4,
            this.tab5,
            this.tab6});
            this.tabMain.RegularSize = new System.Drawing.Size(899, 484);
            this.tabMain.SelectedPage = this.tab2;
            this.tabMain.Size = new System.Drawing.Size(899, 484);
            this.tabMain.TabIndex = 4;
            this.tabMain.Text = "tabPane1";
            this.tabMain.TransitionType = DevExpress.Utils.Animation.Transitions.Cover;
            // 
            // tab1
            // 
            this.tab1.AutoScroll = true;
            this.tab1.Caption = "15 phút";
            this.tab1.Controls.Add(this.pnl1);
            this.tab1.Name = "tab1";
            this.tab1.Properties.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.tab1.Size = new System.Drawing.Size(749, 455);
            // 
            // pnl1
            // 
            this.pnl1.AutoScroll = true;
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(749, 455);
            this.pnl1.TabIndex = 2;
            // 
            // tab4
            // 
            this.tab4.Caption = "1 ngày";
            this.tab4.Controls.Add(this.pnl4);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(739, 433);
            // 
            // pnl4
            // 
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl4.Location = new System.Drawing.Point(0, 0);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(739, 433);
            this.pnl4.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.Caption = "4 giờ";
            this.tab3.Controls.Add(this.pnl3);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(739, 433);
            // 
            // pnl3
            // 
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(739, 433);
            this.pnl3.TabIndex = 0;
            // 
            // tab5
            // 
            this.tab5.Caption = "1 tuần";
            this.tab5.Controls.Add(this.pnl5);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(739, 433);
            // 
            // pnl5
            // 
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl5.Location = new System.Drawing.Point(0, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(739, 433);
            this.pnl5.TabIndex = 0;
            // 
            // tab6
            // 
            this.tab6.Caption = "1 tháng";
            this.tab6.Controls.Add(this.pnl6);
            this.tab6.Name = "tab6";
            this.tab6.Size = new System.Drawing.Size(899, 455);
            // 
            // pnl6
            // 
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl6.Location = new System.Drawing.Point(0, 0);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(899, 455);
            this.pnl6.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Caption = "1 giờ";
            this.tab2.Controls.Add(this.pnl2);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(899, 455);
            // 
            // pnl2
            // 
            this.pnl2.AutoScroll = true;
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(899, 455);
            this.pnl2.TabIndex = 0;
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Location = new System.Drawing.Point(5, 31);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSignal.TabIndex = 3;
            this.btnAddSignal.Text = "Thêm tín hiệu";
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(781, 555);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkState
            // 
            this.chkState.Location = new System.Drawing.Point(777, 34);
            this.chkState.Name = "chkState";
            this.chkState.Properties.OffText = "Tắt";
            this.chkState.Properties.OnText = "Sử dụng";
            this.chkState.Size = new System.Drawing.Size(111, 18);
            this.chkState.TabIndex = 5;
            // 
            // frmAdvanceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 594);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkAndSave);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAdvanceSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập nâng cao";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab5.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel pnl1;
        private DevExpress.XtraEditors.SimpleButton btnAddSignal;
        private DevExpress.XtraBars.Navigation.TabPane tabMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab4;
        private System.Windows.Forms.FlowLayoutPanel pnl3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab3;
        private System.Windows.Forms.FlowLayoutPanel pnl4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab5;
        private System.Windows.Forms.FlowLayoutPanel pnl5;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab6;
        private System.Windows.Forms.FlowLayoutPanel pnl6;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab2;
        private System.Windows.Forms.FlowLayoutPanel pnl2;
        public DevExpress.XtraEditors.ToggleSwitch chkState;
    }
}