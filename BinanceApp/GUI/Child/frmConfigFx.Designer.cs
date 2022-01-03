
namespace BinanceApp.GUI.Child
{
    partial class frmConfigFx
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnBasic = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(2, 89);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(999, 614);
            this.pnlMain.TabIndex = 0;
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(10, 35);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(90, 35);
            this.btnBasic.TabIndex = 1;
            this.btnBasic.Text = "Thiết lập cơ bản";
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnConfig1
            // 
            this.btnConfig1.Location = new System.Drawing.Point(180, 35);
            this.btnConfig1.Name = "btnConfig1";
            this.btnConfig1.Size = new System.Drawing.Size(90, 35);
            this.btnConfig1.TabIndex = 2;
            this.btnConfig1.Text = "Thiết lập 1";
            this.btnConfig1.Click += new System.EventHandler(this.btnConfig1_Click);
            // 
            // btnConfig2
            // 
            this.btnConfig2.Location = new System.Drawing.Point(359, 35);
            this.btnConfig2.Name = "btnConfig2";
            this.btnConfig2.Size = new System.Drawing.Size(90, 35);
            this.btnConfig2.TabIndex = 3;
            this.btnConfig2.Text = "Thiết lập 2";
            this.btnConfig2.Click += new System.EventHandler(this.btnConfig2_Click);
            // 
            // btnConfig3
            // 
            this.btnConfig3.Location = new System.Drawing.Point(539, 35);
            this.btnConfig3.Name = "btnConfig3";
            this.btnConfig3.Size = new System.Drawing.Size(90, 35);
            this.btnConfig3.TabIndex = 4;
            this.btnConfig3.Text = "Thiết lập 3";
            this.btnConfig3.Click += new System.EventHandler(this.btnConfig3_Click);
            // 
            // btnConfig4
            // 
            this.btnConfig4.Location = new System.Drawing.Point(719, 35);
            this.btnConfig4.Name = "btnConfig4";
            this.btnConfig4.Size = new System.Drawing.Size(90, 35);
            this.btnConfig4.TabIndex = 5;
            this.btnConfig4.Text = "Thiết lập 4";
            this.btnConfig4.Click += new System.EventHandler(this.btnConfig4_Click);
            // 
            // btnConfig5
            // 
            this.btnConfig5.Location = new System.Drawing.Point(897, 35);
            this.btnConfig5.Name = "btnConfig5";
            this.btnConfig5.Size = new System.Drawing.Size(90, 35);
            this.btnConfig5.TabIndex = 6;
            this.btnConfig5.Text = "Thiết lập 5";
            this.btnConfig5.Click += new System.EventHandler(this.btnConfig5_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnBasic);
            this.groupControl1.Controls.Add(this.btnConfig1);
            this.groupControl1.Controls.Add(this.btnConfig5);
            this.groupControl1.Controls.Add(this.btnConfig3);
            this.groupControl1.Controls.Add(this.btnConfig2);
            this.groupControl1.Controls.Add(this.btnConfig4);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(999, 87);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Cấu hình";
            // 
            // frmConfigFx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 707);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnlMain);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmConfigFx";
            this.Text = "Cấu hình chỉ báo";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.SimpleButton btnBasic;
        private DevExpress.XtraEditors.SimpleButton btnConfig1;
        private DevExpress.XtraEditors.SimpleButton btnConfig2;
        private DevExpress.XtraEditors.SimpleButton btnConfig3;
        private DevExpress.XtraEditors.SimpleButton btnConfig4;
        private DevExpress.XtraEditors.SimpleButton btnConfig5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}