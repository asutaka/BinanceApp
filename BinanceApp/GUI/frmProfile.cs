using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class frmProfile : XtraForm
    {
        private ProfileModel _profile = StaticValues.profile;
        private const string _fileName = "user.json";
        private BackgroundWorker _bkgr = new BackgroundWorker();
        private WaitFunc _frmWaitForm = new WaitFunc();
        public frmProfile()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _bkgr.DoWork += bkgrCheckStatus_DoWork;
            _bkgr.RunWorkerCompleted += bkgrCheckStatus_RunWorkerCompleted;
            if (CommonMethod.CheckFileExist(_fileName))
            {
                var objUser = new UserModel().LoadJsonFile(_fileName);
                
                StaticValues.profile.Phone = objUser.Phone;
                txtPhone.Text = objUser.Phone;

                if (!string.IsNullOrWhiteSpace(objUser.Code))
                {
                    StaticValues.profile.Code = objUser.Code;
                    txtCode.Text = objUser.Code;
                }
            }

            lblUserName.Text = _profile.Name;
            lblEmail.Text = _profile.Email;
            lblLocale.Text = _profile.Locale;
            if(!string.IsNullOrWhiteSpace(_profile.Picture))
                picAvatar.Load(_profile.Picture);
            btnOk.Focus();
        }

        private void StateEdit(bool isEdit)
        {
            btnEdit.Visible = !isEdit;
            btnSave.Visible = isEdit;
            btnCancel.Visible = isEdit;
            txtPhone.Properties.ReadOnly = !isEdit;
            if(isEdit)
                txtPhone.Focus();
        }

        private bool UpdateUserModel()
        {
            var model = new UserModel
            {
                Phone = txtPhone.Text.Trim().PhoneFormat(),
                Code = txtCode.Text.Trim()
            };
            var isUpdate = model.UpdateJson(_fileName);
            if (isUpdate)
            {
                StaticValues.profile.Phone = model.Phone;
                StaticValues.profile.Code = model.Code;
            }
            return isUpdate;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnPaste_Click(object sender, System.EventArgs e)
        {
            btnOk.Focus();
            btnPaste.Enabled = false;
            if(string.IsNullOrWhiteSpace(Clipboard.GetText().Trim())
                || Clipboard.GetText().Trim().Equals(txtCode.Text.Trim()))
            {
                btnPaste.Enabled = true;
            }
            else
            {
                txtCode.Text = Clipboard.GetText().Trim();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            StateEdit(true);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            StateEdit(false);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            StateEdit(false);
            if (!UpdateUserModel())
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
            txtPhone.Text = StaticValues.profile.Phone;
        }

        private void txtCode_EditValueChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                return;
            }
            if (StaticValues.IsExecCheckCodeActive)
                return;
            StaticValues.IsExecCheckCodeActive = true;

            picStatus.Image = Properties.Resources.yellow;
            _bkgr.RunWorkerAsync();
        }

        private void bkgrCheckStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            _frmWaitForm.Show("Kiểm tra trạng thái");
            btnPaste.Enabled = false;
            var time = CommonMethod.GetTimeAsync().GetAwaiter().GetResult();
            var jsonModel = Security.Decrypt(txtCode.Text.Trim());
            if (string.IsNullOrWhiteSpace(jsonModel))
            {
                StaticValues.IsCodeActive = false;
            }
            else
            {
                var model = JsonConvert.DeserializeObject<GenCodeModel>(jsonModel);
                if(!_profile.Email.Contains(model.Email) || model.Expired <= time)
                {
                    StaticValues.IsCodeActive = false;
                }
                else
                {
                    StaticValues.IsCodeActive = true;
                }
            }
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }

        private void bkgrCheckStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picStatus.Image = StaticValues.IsCodeActive ? Properties.Resources.green : Properties.Resources.red;
            btnPaste.Enabled = true;
            if (!StaticValues.IsCodeActive)
            {
                txtCode.Text = string.Empty;
            }
            else
            {
                UpdateUserModel();
            }
            StaticValues.IsExecCheckCodeActive = false;
        }
    }
}