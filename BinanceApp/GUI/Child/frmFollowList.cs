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
            var dicInterval = new Dictionary<int, int>();
            dicInterval.Add(0, 1);
            dicInterval.Add(1, 2);
            dicInterval.Add(2, 5);
            dicInterval.Add(3, 10);
            dicInterval.Add(4, 15);
            dicInterval.Add(5, 60);
            dicInterval.Add(6, 120);
            dicInterval.Add(7, 240);
            dicInterval.Add(8, 300);
            dicInterval.Add(9, 720);
            dicInterval.Add(10, 1440);
            var CronValue = dicInterval[_model.Interval];
            if (CronValue < 60)
            {
                _model.Cron = $"0 0/{CronValue} * * * ?"; ;
            }
            else if (CronValue < 1440)
            {
                _model.Cron = $"0 0 0/{CronValue} * * ?"; ;
            }
            else if (CronValue == 1440)
            {
                _model.Cron = $"0 0 0 * * ?"; ;
            }
            else
            {
                _model.Cron = "0 * * * * ?"; ;
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