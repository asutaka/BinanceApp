using BinanceApp.Model.ENTITY;
using System.Windows.Forms;

namespace BinanceApp.Usr
{
    public partial class userCoinFollow : UserControl
    {
        private readonly FollowFxModel _model;
        public userCoinFollow()
        {
            InitializeComponent();
            _model = new FollowFxModel();
        }

        public userCoinFollow(FollowFxModel model)
        {
            InitializeComponent();
            _model = model;
            InitData();
        }

        private void InitData()
        {
            chkIsTop30.IsOn = _model.IsTop30;
            chkIsMCDX.IsOn  = _model.IsMCDX;
            chkConfig2.IsOn = _model.IsConfig2;
            chkConfig3.IsOn = _model.IsConfig3;
            chkConfig4.IsOn = _model.IsConfig4;
            chkConfig5.IsOn = _model.IsConfig5;
        }

        public bool CheckValid()
        {
            return chkIsTop30.IsOn | chkIsMCDX.IsOn | chkConfig2.IsOn | chkConfig3.IsOn | chkConfig4.IsOn | chkConfig5.IsOn;
        }

        public FollowFxModel GetModel()
        {
            _model.IsTop30 = chkIsTop30.IsOn;
            _model.IsMCDX = chkIsMCDX.IsOn;
            _model.IsConfig2 = chkConfig2.IsOn;
            _model.IsConfig3 = chkConfig3.IsOn;
            _model.IsConfig4 = chkConfig4.IsOn;
            _model.IsConfig5 = chkConfig5.IsOn;
            _model.Title = txtTitle.Text.Trim();
            return _model;
        }

        private void lblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
