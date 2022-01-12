using BinanceApp.Common;
using BinanceApp.Common.Telegram;
using Quartz;
using System;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution]
    public class SendNotiJob : IJob
    {
        private bool isPrepare;
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(StaticValues.profile.Phone))
                    return;
                var val = StaticValues.lNotify.Dequeue();
                if (string.IsNullOrWhiteSpace(val))
                    return;
                var result = TeleClient.SendMessage(StaticValues.profile.Phone, val);
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"SendNotiJob:Execute: {ex.Message}");
            }
        }
    }
}

