using BinanceApp.Common;
using System;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmConfigFx : DevExpress.XtraEditors.XtraForm
    {
        private frmConfigFx()
        {
            InitializeComponent();
        }

        private static frmConfigFx _instance = null;
        public static frmConfigFx Instance()
        {
            _instance = _instance ?? new frmConfigFx();
            return _instance;
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmBasicSetting());
            });
        }

        private void btnConfig1_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmSpecialSetting());
            });
        }

        private void btnConfig2_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmAdvanceSetting(2));
            });
        }

        private void btnConfig3_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmAdvanceSetting(3));
            });
        }

        private void btnConfig4_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmAdvanceSetting(4));
            });
        }

        private void btnConfig5_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                pnlMain.AddControl(new frmAdvanceSetting(5));
            });
        }
    }
}