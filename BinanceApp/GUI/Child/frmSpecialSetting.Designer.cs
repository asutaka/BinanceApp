
namespace BinanceApp.GUI.Child
{
    partial class frmSpecialSetting
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
            this.chkTop30 = new DevExpress.XtraEditors.ToggleSwitch();
            this.chkMCDX = new DevExpress.XtraEditors.ToggleSwitch();
            this.chkSpecial = new DevExpress.XtraEditors.ToggleSwitch();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkTop30.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMCDX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSpecial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTop30
            // 
            this.chkTop30.Location = new System.Drawing.Point(151, 62);
            this.chkTop30.Name = "chkTop30";
            this.chkTop30.Properties.OffText = "Tắt";
            this.chkTop30.Properties.OnText = "Sử dụng";
            this.chkTop30.Size = new System.Drawing.Size(111, 18);
            this.chkTop30.TabIndex = 2;
            // 
            // chkMCDX
            // 
            this.chkMCDX.Location = new System.Drawing.Point(151, 113);
            this.chkMCDX.Name = "chkMCDX";
            this.chkMCDX.Properties.OffText = "Tắt";
            this.chkMCDX.Properties.OnText = "Sử dụng";
            this.chkMCDX.Size = new System.Drawing.Size(111, 18);
            this.chkMCDX.TabIndex = 3;
            // 
            // chkSpecial
            // 
            this.chkSpecial.Location = new System.Drawing.Point(151, 158);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Properties.OffText = "Tắt";
            this.chkSpecial.Properties.OnText = "Sử dụng";
            this.chkSpecial.Size = new System.Drawing.Size(111, 18);
            this.chkSpecial.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Top 30";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(45, 115);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tiềm năng";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(45, 160);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(47, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Đặc biệt";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(529, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy bỏ";
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkAndSave.Location = new System.Drawing.Point(414, 314);
            this.btnOkAndSave.Name = "btnOkAndSave";
            this.btnOkAndSave.Size = new System.Drawing.Size(109, 32);
            this.btnOkAndSave.TabIndex = 16;
            this.btnOkAndSave.Text = "Lưu cấu hình";
            // 
            // frmSpecialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkAndSave);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chkSpecial);
            this.Controls.Add(this.chkMCDX);
            this.Controls.Add(this.chkTop30);
            this.Name = "frmSpecialSetting";
            this.Text = "Thiết lập đặc biệt";
            ((System.ComponentModel.ISupportInitialize)(this.chkTop30.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMCDX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSpecial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ToggleSwitch chkTop30;
        public DevExpress.XtraEditors.ToggleSwitch chkMCDX;
        public DevExpress.XtraEditors.ToggleSwitch chkSpecial;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
    }
}