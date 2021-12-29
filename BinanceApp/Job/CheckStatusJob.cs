using BinanceApp.Common;
using BinanceApp.GUI;
using BinanceApp.Model.ENTITY;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Job
{
    public class CheckStatusJob : IJob
    {
        private const string _fileName = "user.json";
        public void Execute(IJobExecutionContext context)
        {
            if (StaticValues.IsExecCheckCodeActive)
                return;
            StaticValues.IsExecCheckCodeActive = true;
            var time = CommonMethod.GetTimeAsync().GetAwaiter().GetResult();

            var objUser = new UserModel().LoadJsonFile(_fileName);
            var jsonModel = Security.Decrypt(objUser.Code);
            if (string.IsNullOrWhiteSpace(jsonModel))
            {
                StaticValues.IsCodeActive = false;
            }
            else
            {
                var model = JsonConvert.DeserializeObject<GenCodeModel>(jsonModel);
                if (!StaticValues.profile.Email.Contains(model.Email) || model.Expired <= time)
                {
                    StaticValues.IsCodeActive = false;
                }
                else
                {
                    StaticValues.IsCodeActive = true;
                }
            }

            if (!StaticValues.IsCodeActive)
            {
                //về màn hình đăng nhập
                if(StaticValues.frmMonitorObj != null)
                {
                    StaticValues.frmMonitorObj.KillAllSchedule();
                }
                var objLogin = new frmLogin();
                objLogin.Show();
            }
            StaticValues.IsExecCheckCodeActive = false;
        }
    }
}
