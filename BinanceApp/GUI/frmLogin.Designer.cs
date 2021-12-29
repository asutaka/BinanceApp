
namespace BinanceApp.GUI
{
    partial class frmLogin
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
            this.userLogin1 = new BinanceApp.UserControl.userLogin();
            this.SuspendLayout();
            // 
            // userLogin1
            // 
            this.userLogin1.Location = new System.Drawing.Point(2, 4);
            this.userLogin1.Name = "userLogin1";
            this.userLogin1.Size = new System.Drawing.Size(592, 150);
            this.userLogin1.TabIndex = 3;
            this.userLogin1.Visible = false;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 159);
            this.Controls.Add(this.userLogin1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.userLogin userLogin1;
    }
}