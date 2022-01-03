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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.chkState = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnAddSignal = new DevExpress.XtraEditors.SimpleButton();
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtPoint = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab5.SuspendLayout();
            this.tab6.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOkAndSave.Location = new System.Drawing.Point(12, 35);
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
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.tabMain);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(927, 614);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Thiết lập";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPoint);
            this.groupBox1.Controls.Add(this.cmbPriority);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkState);
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Location = new System.Drawing.Point(5, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbPriority
            // 
            this.cmbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPriority.Location = new System.Drawing.Point(650, 22);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPriority.Size = new System.Drawing.Size(119, 20);
            this.cmbPriority.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Độ ưu tiên";
            // 
            // chkState
            // 
            this.chkState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkState.Location = new System.Drawing.Point(800, 19);
            this.chkState.Name = "chkState";
            this.chkState.Properties.OffText = "Tắt";
            this.chkState.Properties.OnText = "Sử dụng";
            this.chkState.Size = new System.Drawing.Size(111, 24);
            this.chkState.TabIndex = 5;
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Location = new System.Drawing.Point(0, 20);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSignal.TabIndex = 3;
            this.btnAddSignal.Text = "Thêm tín hiệu";
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
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
            this.tabMain.Location = new System.Drawing.Point(2, 84);
            this.tabMain.Name = "tabMain";
            this.tabMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tab1,
            this.tab2,
            this.tab3,
            this.tab4,
            this.tab5,
            this.tab6});
            this.tabMain.RegularSize = new System.Drawing.Size(923, 527);
            this.tabMain.SelectedPage = this.tab2;
            this.tabMain.Size = new System.Drawing.Size(923, 527);
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
            this.pnl4.AutoScroll = true;
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
            this.tab3.Size = new System.Drawing.Size(899, 407);
            // 
            // pnl3
            // 
            this.pnl3.AutoScroll = true;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(899, 407);
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
            this.pnl5.AutoScroll = true;
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
            this.pnl6.AutoScroll = true;
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
            this.tab2.Size = new System.Drawing.Size(923, 506);
            // 
            // pnl2
            // 
            this.pnl2.AutoScroll = true;
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(923, 506);
            this.pnl2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(127, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOkAndSave);
            this.groupControl2.Location = new System.Drawing.Point(0, 619);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(927, 78);
            this.groupControl2.TabIndex = 25;
            this.groupControl2.Text = "Tùy chọn ";
            // 
            // txtPoint
            // 
            this.txtPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoint.Location = new System.Drawing.Point(444, 22);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(120, 21);
            this.txtPoint.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Điểm xác nhận";
            // 
            // frmAdvanceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 700);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmAdvanceSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập nâng cao";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab5.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPoint;
    }
}