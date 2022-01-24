using System;
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
            cmbCoin.Properties.DisplayMember = "AN";
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
            chkState.IsOn = _tradeList.IsNotify;
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_tradeList.lData.Any(x => x.Coin == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            StaticValues.IsTradeListChange = true;
            _tradeList.lData.Clear();
            if (pnl.Controls.Count > 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var user = item as userCoinTrade;

                    _tradeList.lData.Add(user.tradeModel);
                }
            }
            _tradeList.IsNotify = chkState.IsOn;
            _tradeList.UpdateJson(_fileName);
            StaticValues.IsTradeListChange = false;
            MessageBox.Show("Đã lưu dữ liệu!");
        }
    }
}