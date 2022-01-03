
namespace BinanceApp.Usr
{
    partial class userCoinTrade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.LinkLabel();
            this.btnConfig = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(112, 11);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 18;
            // 
            // txtCoin
            // 
            this.txtCoin.BackColor = System.Drawing.Color.White;
            this.txtCoin.Location = new System.Drawing.Point(6, 11);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.ReadOnly = true;
            this.txtCoin.Size = new System.Drawing.Size(100, 20);
            this.txtCoin.TabIndex = 17;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(441, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 13);
            this.lblClose.TabIndex = 16;
            this.lblClose.TabStop = true;
            this.lblClose.Text = "Close";
            this.lblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClose_LinkClicked);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(378, 11);
            this.btnConfig.LookAndFeel.SkinName = "McSkin";
            this.btnConfig.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(51, 20);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "cài đặt";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // userCoinTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCoin);
            this.Controls.Add(this.lblClose);
            this.Name = "userCoinTrade";
            this.Size = new System.Drawing.Size(487, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtCoin;
        private System.Windows.Forms.LinkLabel lblClose;
        private DevExpress.XtraEditors.SimpleButton btnConfig;
    }
}
