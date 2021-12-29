using BinanceApp.Common;
using BinanceApp.GUI;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BinanceApp.UserControl
{
    public partial class userMonitorSchedule : XtraUserControl
    {
        private AuthResponse access;
        private frmMain _frm;
        public userMonitorSchedule()
        {
            InitializeComponent();
        }
        public RichTextBox GetRichTextBox()
        {
            return txtLog;
        }
        public CheckBox GetCheckBox()
        {
            return chkBox;
        }
    }
}
