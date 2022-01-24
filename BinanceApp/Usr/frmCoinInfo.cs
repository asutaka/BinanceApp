using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BinanceApp.Usr
{
    public partial class frmCoinInfo : XtraForm
    {
        private userCoinTrade _frm;
        private double _currentValue;
        public frmCoinInfo()
        {
            InitializeComponent();
        }

        public frmCoinInfo(userCoinTrade frm)
        {
            InitializeComponent();
            _frm = frm;
            if (_frm.tradeModel.Config == null)
                _frm.tradeModel.Config = new List<TradeDetailModel>();
            InitData();
        }

        private void InitData()
        {
            SetupData();
        }

        private void SetupData()
        {
            var entity = StaticValues.lstCoinFilter.FirstOrDefault(x => x.S == _frm.tradeModel.Coin);
            if (entity != null)
            {
                _currentValue = CommonMethod.GetCurrentValue(entity.S);

                txtCoin.Text = entity.S;
                txtDescription.Text = entity.AN;
                txtValue.Text = _currentValue.ToString("#,##0.#########");
                foreach (var item in _frm.tradeModel.Config)
                {
                    pnlMain.Controls.Add(new userCoinValue(item));
                }
            }
        }

        private void btnAddSignal_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(new userCoinValue(_currentValue));
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            _frm.tradeModel.Config.Clear();
            if (pnlMain.Controls.Count > 0)
            {
                foreach (var item in pnlMain.Controls)
                {
                    var user = item as userCoinValue;
                    if (user.GetValue() > 0)
                    {
                        _frm.tradeModel.Config.Add(new TradeDetailModel { IsAbove = user.IsAbove(), Value = user.GetValue() });
                    }
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}