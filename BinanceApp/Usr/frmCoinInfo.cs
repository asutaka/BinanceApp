using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BinanceApp.Usr
{
    public partial class frmCoinInfo : XtraForm
    {
        private userCoinTrade _frm;
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
            LoadInternalNotify();
            SetupData();
        }

        private void LoadInternalNotify()
        {
            cmbFrequency.Properties.BeginUpdate();
            foreach (DataRow row in SeedData.GetDataInternalNotify().Rows)
            {
                cmbFrequency.Properties.Items.Add(row["Name"]);
            }
            cmbFrequency.SelectedIndex = 0;
            cmbFrequency.Properties.EndUpdate();
        }

        private void SetupData()
        {
            var entity = StaticValues.lstCoinFilter.FirstOrDefault(x => x.S == _frm.tradeModel.Coin);
            if (entity != null)
            {
                txtCoin.Text = entity.S;
                txtDescription.Text = entity.AN;
                txtValue.Text = CommonMethod.GetCurrentValue(entity.S).ToString("#,##0.#########");
                cmbFrequency.SelectedIndex = _frm.tradeModel.Interval;
                chkState.IsOn = _frm.tradeModel.IsNotify;
                foreach (var item in _frm.tradeModel.Config)
                {
                    pnlMain.Controls.Add(new userCoinValue(item));
                }
            }
        }

        private void btnAddSignal_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(new userCoinValue());
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            _frm.tradeModel.Interval = cmbFrequency.SelectedIndex;
            _frm.tradeModel.IsNotify = chkState.IsOn;
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