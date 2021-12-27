using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;

namespace BinanceApp.GUI
{
    public partial class frmProfile : XtraForm
    {
        private ProfileModel _profile = StaticValues.profile;
        public frmProfile()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            lblUserName.Text = _profile.Name;
            lblEmail.Text = _profile.Email;
            lblLocale.Text = _profile.Locale;
            if(!string.IsNullOrWhiteSpace(_profile.Picture))
                picAvatar.Load(_profile.Picture);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}