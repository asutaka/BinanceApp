using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmSpecialSetting : XtraForm
    {
        private readonly string _fileName = $"special_setting.json";
        public frmSpecialSetting()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            LoadPriority(cmbPriorityTop30);
            LoadPriority(cmbPriorityMCDX);
            LoadPriority(cmbPrioritySpecial);
            SetupData();
        }

        private void SetupData()
        {
            var model = new SpecialSettingModel().LoadJsonFile(_fileName);
            if (model == null)
                return;
            cmbPriorityTop30.SelectedIndex = model.PriorityTop30;
            chkStateTop30.IsOn = model.IsActiveTop30;
            cmbPriorityMCDX.SelectedIndex = model.PriorityMCDX;
            chkStateMCDX.IsOn = model.IsActiveMCDX;
            cmbPrioritySpecial.SelectedIndex = model.PrioritySpecial;
            chkStateSpecial.IsOn = model.IsActiveSpecial;
        }

        private void LoadPriority(ComboBoxEdit cmb)
        {
            cmb.Properties.BeginUpdate();
            foreach (DataRow row in SeedData.GetDataPriority().Rows)
            {
                cmb.Properties.Items.Add(row["Name"]);
            }
            cmb.SelectedIndex = 1;
            cmb.Properties.EndUpdate();
        }

        private void btnOkAndSave_Click(object sender, EventArgs e)
        {
            var model = new SpecialSettingModel { 
                IsActiveTop30 = chkStateTop30.IsOn,
                PriorityTop30 = cmbPriorityTop30.SelectedIndex,
                IsActiveMCDX = chkStateMCDX.IsOn,
                PriorityMCDX = cmbPriorityMCDX.SelectedIndex,
                IsActiveSpecial = chkStateSpecial.IsOn,
                PrioritySpecial = cmbPrioritySpecial.SelectedIndex
            };
            model.UpdateJson(_fileName);
            MessageBox.Show("Đã lưu dữ liệu!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetupData();
        }
    }
}