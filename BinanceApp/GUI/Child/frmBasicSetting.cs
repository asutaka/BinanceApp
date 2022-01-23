using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using DevExpress.XtraEditors;

namespace BinanceApp.GUI.Child
{
    public partial class frmBasicSetting : XtraForm
    {
        private const string _fileName = "basic_setting.json";
        public frmBasicSetting()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            LoadDataTimeZone();
            LoadDataCandleStick();
            SetupData();
        }
        private void LoadDataTimeZone()
        {
            cmbTimeZone.ValueMember = "Id";
            cmbTimeZone.DisplayMember = "Name";
            cmbTimeZone.DataSource = SeedData.GetDataTimeZone();
        }
        private void LoadDataCandleStick()
        {
            cmbCandleStick.ValueMember = "Id";
            cmbCandleStick.DisplayMember = "Name";
            cmbCandleStick.DataSource = SeedData.GetDataCandleStick();
        }
        private void SetupData()
        {
            var model = new BasicSettingModel().LoadJsonFile(_fileName);
            cmbTimeZone.SelectedIndex = model.TimeZone;
            nmDefaultInterval.Value = model.Interval;
            cmbCandleStick.SelectedIndex = model.ListModel.First(x => x.Indicator == (int)enumChooseData.CandleStick_1).Period;
            nmWeight.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.Volumne).Period;
            nmMA.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.MA).Period;
            nmEMA.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.EMA).Period;
            nmHighMACD.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.MACD).High;
            nmLowMACD.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.MACD).Low;
            nmSignal.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.MACD).Signal;
            nmRSI.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.RSI).Period;
            nmADX.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.ADX).Period;
            nmMCDX.Value = model.ListModel.First(x => x.Indicator == (int)enumChooseData.MCDX).Signal;
        }
        private bool IsValid()
        {
            if (nmHighMACD.Value >= 100
                || nmLowMACD.Value >= 100
                || nmSignal.Value >= 100)
            {
                MessageBox.Show("MACD không cho phép chu kỳ lớn hơn 100", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            new BasicSettingModel
            {
                TimeZone = cmbTimeZone.SelectedIndex,
                Interval = (int)nmDefaultInterval.Value,
                ListModel = new List<GeneralModel>
                {
                    new GeneralModel{ Indicator = (int)enumChooseData.MA, Period = (int)nmMA.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.EMA, Period = (int)nmEMA.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.Volumne, Period = (int)nmWeight.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.CandleStick_1, Period = cmbCandleStick.SelectedIndex },
                    new GeneralModel{ Indicator = (int)enumChooseData.CandleStick_2, Period = cmbCandleStick.SelectedIndex },
                    new GeneralModel{ Indicator = (int)enumChooseData.MACD, High = (int)nmHighMACD.Value, Low = (int)nmLowMACD.Value, Signal = (int)nmSignal.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.RSI, Period = (int)nmRSI.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.ADX, Period = (int)nmADX.Value },
                    new GeneralModel{ Indicator = (int)enumChooseData.CurrentValue, Period = 0 },
                    new GeneralModel{ Indicator = (int)enumChooseData.MCDX, Signal = (int)nmMCDX.Value },
                }
            }.UpdateJson(_fileName);
            MessageBox.Show("Đã lưu dữ liệu!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }
    }
}