using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using BinanceApp.Model.ENUM;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace BinanceApp.GenCode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool CheckValid()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Chưa nhập email");
                return false;
            }
            else if(!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            return true;
        }
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValid())
                    return;
                var dtExpired = DateTime.Now.AddHours(1);
                var optionTime = (int)enumOptionTime.ThreeDays;
                if (rbt3day.Checked)
                {
                    optionTime = (int)enumOptionTime.ThreeDays;
                    dtExpired = dtExpired.AddDays(3);
                }
                else if (rbt1month.Checked)
                {
                    optionTime = (int)enumOptionTime.AMonth;
                    dtExpired = dtExpired.AddMonths(1);
                }
                else if (rbt3month.Checked)
                {
                    optionTime = (int)enumOptionTime.ThreeMonths;
                    dtExpired = dtExpired.AddMonths(3);
                }
                else if (rbt6month.Checked)
                {
                    optionTime = (int)enumOptionTime.SixMonths;
                    dtExpired = dtExpired.AddMonths(6);
                }
                else if (rbt1year.Checked)
                {
                    optionTime = (int)enumOptionTime.AYear;
                    dtExpired = dtExpired.AddYears(1);
                }
                var indexMail = txtEmail.Text.IndexOf("@gmail.com");
                var model = new GenCodeModel
                {
                    Email = txtEmail.Text.Substring(0, indexMail).Trim(),
                    OptionTime = optionTime,
                    Expired = dtExpired.DateToInt()
                };
                var jsonModel = JsonConvert.SerializeObject(model);
                var code = Security.Encrypt(jsonModel);
                txtCode.Text = code;
                NLogLogger.LogInfo($"Date: { DateTime.Now } | Model Info: { jsonModel } | Code: { code }");
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"GenerateCode: {ex.Message}");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCode.Text))
                    return;
                Clipboard.SetText(txtCode.Text);
                NLogLogger.LogInfo($"Date: { DateTime.Now } | Copy Code: { txtCode.Text }");
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"Copy: {ex.Message}");
            }
        }
    }
}
