using BinanceApp.Common;
using System;
using System.IO;
using System.Windows.Forms;

namespace BinanceApp.GenTelegram
{
    public partial class frmMain : Form
    {
        private string _phone = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }
        private bool CheckValid()
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Chưa nhập SĐT");
                return false;
            }
            try
            {
                _phone = txtPhone.Text.PhoneFormat();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"GenTelegram|CheckValid: {ex.Message}");
                return false;
            }
            return true;
        }
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            var outputModel = new VerifyCodeModel();
            try
            {
                _logger.LogInformation($"verifyCode| {JsonConvert.SerializeObject(param)}");
                if (string.IsNullOrWhiteSpace(param.Phone))
                {
                    outputModel.Code = (int)enumNotifyResponseStatus.InvalidPhoneNumber;
                    outputModel.Status = enumNotifyResponseStatus.InvalidPhoneNumber.ToDisplayStatus();
                    return outputModel;
                }
                var phone = param.Phone.PhoneFormat(false);
                var entity = _context.Bots.FirstOrDefault(x => x.Phone == phone);
                if (entity != null)
                {
                    _api_id0 = entity.ApiId.ToString();
                    _api_hash0 = entity.ApiHash;
                    _phone_number0 = entity.Phone;
                    _session_pathname0 = $"{entity.Phone}.session";
                    _verification_code0 = param.Code.ToString();
                    var client = new Client(ConfigInternal);
                    await client.ConnectAsync();
                    var user = await client.LoginUserIfNeeded();
                    _logger.LogInformation($"You are logged-in as {user.username ?? user.first_name + " " + user.last_name} (id {user.id})");
                    outputModel.Code = (int)enumNotifyResponseStatus.Success;
                    outputModel.Status = enumNotifyResponseStatus.Success.ToDisplayStatus();
                }
                else
                {
                    outputModel.Code = (int)enumNotifyResponseStatus.InvalidPhoneNumber;
                    outputModel.Status = enumNotifyResponseStatus.InvalidPhoneNumber.ToDisplayStatus();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                outputModel.Code = (int)enumNotifyResponseStatus.ErrorAnUnknownError;
                outputModel.Status = enumNotifyResponseStatus.ErrorAnUnknownError.ToDisplayStatus();
            }
            return outputModel;
        }

        private void btnRequestCode_Click(object sender, EventArgs e)
        {
            var root = Directory.GetCurrentDirectory();
            var path = $"{root}/{_phone}.session";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                //Send code
                var entity = _context.Bots.FirstOrDefault(x => x.Phone == phone);
                if (entity != null)
                {
                    _api_id0 = entity.ApiId.ToString();
                    _api_hash0 = entity.ApiHash;
                    _phone_number0 = entity.Phone;
                    _session_pathname0 = $"{entity.Phone}.session";
                    var client = new Client(ConfigInternal);
                    await client.ConnectAsync();
                    await client.LoginUserIfNeeded();
                }
                return new ResponseResultModel
                {
                    Code = 0,
                    Message = "success"
                };
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"GenTelegram|btnGenerateCode_Click: {ex.Message}");
                MessageBox.Show("Lỗi khi Request Code");
            }
        }
    }
}
