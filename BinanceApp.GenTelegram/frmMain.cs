using BinanceApp.Common;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTelegram;

namespace BinanceApp.GenTelegram
{
    public partial class frmMain : Form
    {
        private static string _phone_number = string.Empty, _session_pathname = string.Empty, _verification_code = string.Empty;
        private static string Config(string what)
        {
            switch (what)
            {
                case "api_id": return ConstantValue.apiIdBot1;
                case "api_hash": return ConstantValue.apiHashBot1;
                case "phone_number": return $"+{_phone_number}";
                case "session_pathname": return _session_pathname;
                case "verification_code": return _verification_code;
                default: return null;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private bool CheckValid()
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Chưa nhập SĐT!");
                return false;
            }
            try
            {
                _phone_number = txtPhone.Text.PhoneFormat(false);
                if (string.IsNullOrWhiteSpace(_phone_number))
                {
                    MessageBox.Show("SĐT không hợp lệ!");
                    return false;
                }
                _session_pathname = $"{_phone_number}.session";
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"GenTelegram|CheckValid: {ex.Message}");
                MessageBox.Show("SĐT không hợp lệ!");
                return false;
            }
            return true;
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            VerifyCode().GetAwaiter().GetResult();
        }

        private async Task VerifyCode()
        {
            try
            {
                _verification_code = txtCode.Text.Trim();
                var client = new Client(Config);
                await client.ConnectAsync();
                var user = await client.LoginUserIfNeeded();
                NLogLogger.LogInfo($"You are logged-in as {user.username ?? user.first_name + " " + user.last_name} (id {user.id})");
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }

        private async Task RequestCode()
        {
            if (!CheckValid())
                return;
            var root = Directory.GetCurrentDirectory();
            var path = $"{root}/{_session_pathname}";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //Send code
                var client = new Client(Config);
                //await client.ConnectAsync();
                await client.LoginUserIfNeeded();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"GenTelegram|btnGenerateCode_Click: {ex.Message}");
                MessageBox.Show("Lỗi khi Request Code");
            }
        }

        private void btnRequestCode_Click(object sender, EventArgs e)
        {
            RequestCode().GetAwaiter().GetResult();
        }
    }
}
