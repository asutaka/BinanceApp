﻿using System;
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
        private readonly List<TradeModel> _lstCoin = StaticValues.lstTradeList;
        private frmTradeList()
        {
            InitializeComponent();
            if (_lstCoin == null)
                _lstCoin = new List<TradeModel>();
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
            foreach (var item in _lstCoin)
            {
                pnl.Controls.Add(new userCoinTrade(item));
            }
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_lstCoin.Any(x => x.Coin == cmbCoin.EditValue.ToString()))
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
            //        var user = item as userCoinTrade;
            //        _lstCoin.Add(new CryptonDetailDataModel { S = user.txtCoin.Text });
            //    }
            //}
            var model = new TradeModel { Coin = cmbCoin.EditValue.ToString() };
            _lstCoin.Add(model);
            pnl.Controls.Add(new userCoinTrade(model));
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
                    var user = item as userCoinTrade;

                    _lstCoin.Add(user.tradeModel);
                }
            }
            _lstCoin.UpdateJson(_fileName);
            //Tìm ra ước chung lớn nhất của tất cả các coin trade sau đó cập nhật biến scronjob
            MessageBox.Show("Đã lưu dữ liệu!");
        }
    }
}