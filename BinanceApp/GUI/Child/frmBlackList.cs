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
    public partial class frmBlackList : XtraForm
    {
        private const string _fileName = "blacklist.json";
        private readonly List<CryptonDetailDataModel> _lstCoin = StaticValues.lstBlackList;
        private frmBlackList()
        {
            InitializeComponent();
            if (_lstCoin == null)
                _lstCoin = new List<CryptonDetailDataModel>();
            InitData();
        }

        private static frmBlackList _instance = null;
        public static frmBlackList Instance()
        {
            _instance = _instance ?? new frmBlackList();
            return _instance;
        }

        private void InitData()
        {
            cmbCoin.Properties.ValueMember = "S";
            cmbCoin.Properties.DisplayMember = "S";
            cmbCoin.Properties.DataSource = StaticValues.lstCoin;
            SetupData();
        }

        private void SetupData()
        {
            pnl.Controls.Clear();
            foreach (var item in _lstCoin)
            {
                pnl.Controls.Add(new userCoinTrace(item.S));
            }
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_lstCoin.Any(x => x.S == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue.ToString()} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }
            //_lstCoin.Clear();
            //if(pnl.Controls.Count > 0)
            //{
            //    foreach (var item in pnl.Controls)
            //    {
            //        var user = item as userCoinTrace;
            //        _lstCoin.Add(new CryptonDetailDataModel { S = user.txtCoin.Text });
            //    }
            //}
            _lstCoin.Add(new CryptonDetailDataModel { S = cmbCoin.EditValue.ToString() });
            pnl.Controls.Add(new userCoinTrace(cmbCoin.EditValue.ToString()));
            cmbCoin.EditValue = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            _lstCoin.Clear();
            if (pnl.Controls.Count > 0)
            {
                foreach (var item in pnl.Controls)
                {
                    var user = item as userCoinTrace;
                    if (!string.IsNullOrWhiteSpace(user.txtCoin.Text))
                    {
                        _lstCoin.Add(new CryptonDetailDataModel { S = user.txtCoin.Text });
                    }
                }
            }
            _lstCoin.UpdateJson(_fileName);
            MessageBox.Show("Đã lưu dữ liệu!");
        }
    }
}