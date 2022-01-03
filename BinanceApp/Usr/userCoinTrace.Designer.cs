namespace BinanceApp.Usr
{
    partial class userCoinTrace
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
            this.lblClose = new System.Windows.Forms.LinkLabel();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(379, 15);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 13);
            this.lblClose.TabIndex = 13;
            this.lblClose.TabStop = true;
            this.lblClose.Text = "Close";
            this.lblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClose_LinkClicked);
            // 
            // txtCoin
            // 
            this.txtCoin.BackColor = System.Drawing.Color.White;
            this.txtCoin.Location = new System.Drawing.Point(7, 12);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.ReadOnly = true;
            this.txtCoin.Size = new System.Drawing.Size(100, 20);
            this.txtCoin.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(113, 12);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 15;
            // 
            // userCoinTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCoin);
            this.Controls.Add(this.lblClose);
            this.Name = "userCoinTrace";
            this.Size = new System.Drawing.Size(416, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblClose;
        public System.Windows.Forms.TextBox txtCoin;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
