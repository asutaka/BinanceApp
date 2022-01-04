
namespace BinanceApp.Usr
{
    partial class frmCoinFollowInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFrequency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.chkState = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnAddSignal = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFrequency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFrequency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkState);
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrequency.Location = new System.Drawing.Point(542, 21);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFrequency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFrequency.Size = new System.Drawing.Size(119, 20);
            this.cmbFrequency.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tần suất";
            // 
            // chkState
            // 
            this.chkState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkState.Location = new System.Drawing.Point(681, 19);
            this.chkState.Name = "chkState";
            this.chkState.Properties.OffText = "Tắt";
            this.chkState.Properties.OnText = "Bật thông báo";
            this.chkState.Size = new System.Drawing.Size(139, 24);
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
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Location = new System.Drawing.Point(2, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(848, 370);
            this.pnlMain.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOkAndSave);
            this.groupControl2.Location = new System.Drawing.Point(2, 435);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(848, 78);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Tùy chọn ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(129, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOkAndSave.Location = new System.Drawing.Point(14, 34);
            this.btnOkAndSave.Name = "btnOkAndSave";
            this.btnOkAndSave.Size = new System.Drawing.Size(109, 32);
            this.btnOkAndSave.TabIndex = 16;
            this.btnOkAndSave.Text = "Lưu cấu hình";
            this.btnOkAndSave.Click += new System.EventHandler(this.btnOkAndSave_Click);
            // 
            // frmCoinFollowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 515);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frmCoinFollowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Coin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFrequency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFrequency;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.ToggleSwitch chkState;
        private DevExpress.XtraEditors.SimpleButton btnAddSignal;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
    }
}