using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using BinanceApp.Usr;
using DevExpress.XtraEditors;

namespace BinanceApp.GUI.Child
{
    public partial class frmAdvanceSetting : XtraForm
    {
        private readonly string _fileName;
        public frmAdvanceSetting(int numConfig)
        {
            InitializeComponent();
            _fileName = $"advance_setting{ numConfig }.json";
            this.Text = $"Thiết lập nâng cao {numConfig}";
            InitData(numConfig);
        }
       
        private void InitData(int numConfig)
        {
            LoadPriority();
            SetupData();
        }

        private void SetupData()
        {
            var model = new AdvanceSettingModel().LoadJsonFile(_fileName);
            if (model.LstInterval == null
                || model.LstInterval.Count == 0)
                return;
            chkState.IsOn = model.IsActive;
            cmbPriority.SelectedIndex = model.Priority;
            txtPoint.Value = model.Point;
            LoadGuiData(pnl1, model.LstIndicator15M);
            LoadGuiData(pnl2, model.LstIndicator1H);
            LoadGuiData(pnl3, model.LstIndicator4H);
            LoadGuiData(pnl4, model.LstIndicator1D);
            LoadGuiData(pnl5, model.LstIndicator1W);
            LoadGuiData(pnl6, model.LstIndicator1M);
        }

        private void LoadPriority()
        {
            cmbPriority.Properties.BeginUpdate();
            foreach (DataRow row in SeedData.GetDataPriority().Rows)
            {
                cmbPriority.Properties.Items.Add(row["Name"]);
            }
            cmbPriority.SelectedIndex = 1;
            cmbPriority.Properties.EndUpdate();
        }
        private void LoadGuiData(FlowLayoutPanel flow, List<IndicatorModel> lstModel)
        {
            flow.Controls.Clear();
            if (lstModel == null || !lstModel.Any())
                return;

            foreach (var item in lstModel)
            {
                var objUserSetting = new userSetting();
                objUserSetting.chkState.IsOn = true;
                objUserSetting.cmbOperator.SelectedIndex = item.Operator;
                objUserSetting.nmResult.Value = item.Result;
                objUserSetting.cmbUnit.SelectedIndex = item.Unit;
                objUserSetting.nmPoint.Value = item.Point;
                MatchingData(item.Element1, objUserSetting.cmbOptionFirst, objUserSetting.cmbResultFirst, objUserSetting.nmResultFirst);
                MatchingData(item.Element2, objUserSetting.cmbOptionLast, objUserSetting.cmbResultLast, objUserSetting.nmResultLast);
                flow.Controls.Add(objUserSetting);
            }
        }
        private void MatchingData(ElementModel model, System.Windows.Forms.ComboBox cmbSrc, System.Windows.Forms.ComboBox cmbDest, NumericUpDown numDest)
        {
            if (model == null)
                return;
            var modelOutput = model.To<GeneralModel>();
            cmbSrc.SelectedIndex = modelOutput.Indicator;
            numDest.Value = modelOutput.Period;
            if(modelOutput.Indicator == (int)enumChooseData.CandleStick_1
                || modelOutput.Indicator == (int)enumChooseData.CandleStick_2)
            {
                cmbDest.SelectedIndex = modelOutput.Period;
            }
        }
        private void StandardizedData(ElementModel model)
        {
            GeneralModel objBasicModel = StaticValues.basicModel.ListModel.First(x => x.Indicator == model.Id);
            if (model.Id == (int)enumChooseData.MACD)
            {
                model.Value = int.Parse($"{objBasicModel.High.To2Digit()}{objBasicModel.Low.To2Digit()}{objBasicModel.Signal.To2Digit()}");
            }
            else if (model.Id == (int)enumChooseData.MA
                || model.Id == (int)enumChooseData.EMA
                || model.Id == (int)enumChooseData.CandleStick_1
                || model.Id == (int)enumChooseData.CandleStick_2) { }
            else
            {
                model.Value = objBasicModel.Period;
            }
        }
        private bool IsValidData()
        {
            return true;
        }
        private List<IndicatorModel> BuildIndicatorData(FlowLayoutPanel flow)
        {
            var lstSetting = new List<IndicatorModel>();
            foreach (var item in flow.Controls)
            {
                var objSetting = item as userSetting;
                if (objSetting.chkState.IsOn && objSetting.nmPoint.Value > 0)
                {
                    int firstValue = 0;
                    if (objSetting.nmResultFirst.Visible)
                        firstValue = (int)objSetting.nmResultFirst.Value;
                    if (objSetting.cmbResultFirst.Visible)
                        firstValue = objSetting.cmbResultFirst.SelectedIndex;

                    var model = new IndicatorModel
                    {
                        Element1 = new ElementModel { Id = objSetting.cmbOptionFirst.SelectedIndex, Value = firstValue },
                        Operator = objSetting.cmbOperator.SelectedIndex,
                        Result = objSetting.nmResult.Value,
                        Unit = objSetting.cmbUnit.SelectedIndex,
                        Point = objSetting.nmPoint.Value
                    };
                    StandardizedData(model.Element1);
                    if (objSetting.cmbOptionLast.SelectedIndex > -1)
                    {
                        int lastValue = 0;
                        if (objSetting.nmResultLast.Visible)
                            lastValue = (int)objSetting.nmResultLast.Value;
                        if (objSetting.cmbResultLast.Visible)
                            lastValue = objSetting.cmbResultLast.SelectedIndex;
                        model.Element2 = new ElementModel { Id = objSetting.cmbOptionLast.SelectedIndex, Value = lastValue };
                        StandardizedData(model.Element2);
                    }
                    lstSetting.Add(model);
                }
            }
            return lstSetting;
        }
        private AdvanceSettingModel BuildModel()
        {
            var model = new AdvanceSettingModel { IsActive = chkState.IsOn, Priority = cmbPriority.SelectedIndex, Point = txtPoint.Value, LstInterval = new List<int>() };
            if(pnl1.Controls.Count > 0)
            {
                model.LstIndicator15M = BuildIndicatorData(pnl1);
                model.LstElement15M = model.LstIndicator15M.Select(x => x.Element1)
                                        .Union(model.LstIndicator15M.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.ThirteenMinute);
            }
            if (pnl2.Controls.Count > 0)
            {
                model.LstIndicator1H = BuildIndicatorData(pnl2);
                model.LstElement1H = model.LstIndicator1H.Select(x => x.Element1)
                                        .Union(model.LstIndicator1H.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.OneHour);
            }
            if (pnl3.Controls.Count > 0)
            {
                model.LstIndicator4H = BuildIndicatorData(pnl3);
                model.LstElement4H = model.LstIndicator4H.Select(x => x.Element1)
                                        .Union(model.LstIndicator4H.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.FourHour);
            }
            if (pnl4.Controls.Count > 0)
            {
                model.LstIndicator1D = BuildIndicatorData(pnl4);
                model.LstElement1H = model.LstIndicator1D.Select(x => x.Element1)
                                        .Union(model.LstIndicator1D.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.OneDay);
            }
            if (pnl5.Controls.Count > 0)
            {
                model.LstIndicator1W = BuildIndicatorData(pnl5);
                model.LstElement1W = model.LstIndicator1W.Select(x => x.Element1)
                                        .Union(model.LstIndicator1W.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.OneWeek);
            }
            if (pnl6.Controls.Count > 0)
            {
                model.LstIndicator1M = BuildIndicatorData(pnl6);
                model.LstElement1M = model.LstIndicator1M.Select(x => x.Element1)
                                        .Union(model.LstIndicator1M.Where(x => x.Element2 != null).Select(x => x.Element2))
                                        .Distinct().ToList();
                model.LstInterval.Add((int)enumTimeZone.OneMonth);
            }
            return model;
        }
        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
                return;
            var model = BuildModel();
            model.UpdateJson(_fileName);
            MessageBox.Show("Đã lưu dữ liệu!");
        }

        private void btnAddSignal_Click(object sender, EventArgs e)
        {
            var index = tabMain.SelectedPageIndex;
            if (index == 0)
                pnl1.Controls.Add(new userSetting());
            else if (index == 1)
                pnl2.Controls.Add(new userSetting());
            else if (index == 2)
                pnl3.Controls.Add(new userSetting());
            else if (index == 3)
                pnl4.Controls.Add(new userSetting());
            else if (index == 4)
                pnl5.Controls.Add(new userSetting());
            else if (index == 5)
                pnl6.Controls.Add(new userSetting());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }
    }
}