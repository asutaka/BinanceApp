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
    public partial class frmTradeList : XtraForm
    {
        private const string _fileName = "tradelist.json";
        private readonly TradeListModel _tradeList = StaticValues.tradeList;
        private frmTradeList()
        {
            InitializeComponent();
            InitData();
        }

        private static frmTradeList _instance = null;
        public static frmTradeList Instance()
        {
            _instance = _instance ?? new frmTradeList();
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
            foreach (var item in _tradeList.lData)
            {
                pnl.Controls.Add(new userCoinTrade(item));
            }
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_tradeList.lData.Any(x => x.Coin == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue.ToString()} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }

            var model = new TradeModel { Coin = cmbCoin.EditValue.ToString() };
            _tradeList.lData.Add(model);
            pnl.Controls.Add(new userCoinTrade(model));
            cmbCoin.EditValue = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            _tradeList.lData.Clear();
            if (pnl.Controls.Count > 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var user = item as userCoinTrade;

                    _tradeList.lData.Add(user.tradeModel);
                }
            }
            var lInterval = _tradeList.lData.OrderBy(x => x.Interval).Select(x => x.Interval).Distinct().Take(2);
            if(lInterval != null && lInterval.Any())
            {
                var intervalVal = 0;
                if(lInterval.Count() == 1)
                {
                    intervalVal = lInterval.First();
                }
                else
                {
                    intervalVal = CommonMethod.GCD(lInterval.First(), lInterval.Last());
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
                _tradeList.CronValue = dicInterval[intervalVal];
                if(_tradeList.CronValue < 60)
                {
                    _tradeList.Cron = $"0 0/{_tradeList.CronValue} * * * ?"; ;
                }
                else if(_tradeList.CronValue < 1440)
                {
                    _tradeList.Cron = $"0 0 0/{_tradeList.CronValue} * * ?"; ;
                }
                else
                {
                    _tradeList.Cron = $"0 0 0 * * ?"; ;
                }
            }
            else
            {
                _tradeList.CronValue = 1;
                _tradeList.Cron = "0 * * * * ?"; ;
            }
            _tradeList.UpdateJson(_fileName);
            //Tìm ra ước chung lớn nhất của tất cả các coin trade sau đó cập nhật biến scronjob
            MessageBox.Show("Đã lưu dữ liệu!");
        }
    }
}