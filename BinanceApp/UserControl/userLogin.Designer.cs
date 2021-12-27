
namespace BinanceApp.UserControl
{
    partial class userLogin
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
            this.picGoogleSignIn = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoogleSignIn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picGoogleSignIn
            // 
            this.picGoogleSignIn.EditValue = global::BinanceApp.Properties.Resources.GoogleSignIn;
            this.picGoogleSignIn.Location = new System.Drawing.Point(108, 38);
            this.picGoogleSignIn.Name = "picGoogleSignIn";
            this.picGoogleSignIn.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picGoogleSignIn.Properties.Appearance.Options.UseBackColor = true;
            this.picGoogleSignIn.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picGoogleSignIn.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picGoogleSignIn.Size = new System.Drawing.Size(354, 78);
            this.picGoogleSignIn.TabIndex = 2;
            this.picGoogleSignIn.Click += new System.EventHandler(this.picGoogleSignIn_Click);
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picGoogleSignIn);
            this.Name = "userLogin";
            this.Size = new System.Drawing.Size(592, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picGoogleSignIn.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picGoogleSignIn;
    }
}
