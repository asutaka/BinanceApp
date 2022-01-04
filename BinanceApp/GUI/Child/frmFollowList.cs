using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;
using BinanceApp.Model.ENTITY;
using BinanceApp.Common;
using BinanceApp.Usr;

namespace BinanceApp.GUI.Child
{
    public partial class frmFollowList : XtraForm
    {
        private const string _fileName = "followlist.json";
        public FollowModel _model = StaticValues.followList;
        private frmFollowList()
        {
            InitializeComponent();
            if (_model == null)
                _model = new FollowModel {
                    Coins = new List<string>(),
                    Follows = new List<FollowFxModel>()
                };
            InitData();
        }

        private static frmFollowList _instance = null;
        public static frmFollowList Instance()
        {
            _instance = _instance ?? new frmFollowList();
            return _instance;
        }

        private void InitData()
        {
            cmbCoin.Properties.ValueMember = "S";
            cmbCoin.Properties.DisplayMember = "S";
            cmbCoin.Properties.DataSource = StaticValues.lstCoinFilter;
            SetupData();
        }

        private void SetupData()
        {
            pnl.Controls.Clear();
            foreach (var item in _model.Coins)
            {
                pnl.Controls.Add(new userCoinTrace(item));
            }
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_model.Coins.Any(x => x == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }
            _model.Coins.Add(cmbCoin.EditValue.ToString());
            pnl.Controls.Add(new userCoinTrace(cmbCoin.EditValue.ToString()));
            cmbCoin.EditValue = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            _model.Coins.Clear();
            if (pnl.Controls.Count > 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var user = item as userCoinTrace;
                    if (!string.IsNullOrWhiteSpace(user.txtCoin.Text))
                    {
                        _model.Coins.Add(user.txtCoin.Text);
                    }
                }
            }
            _model.UpdateJson(_fileName);
            MessageBox.Show("Đã lưu dữ liệu!");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var obj = new frmCoinFollowInfo(_model);
            if (obj.ShowDialog() == DialogResult.OK)
            {
                _model = obj.GetModel();
            }
        }
    }
}