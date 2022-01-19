using BinanceApp.Common;
using Quartz;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution] /*impt: no multiple instances executed concurrently*/
    public class Top30BottomValueScheduleJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            foreach (var item in StaticValues.lstCryptonRank)
            {
                item.BottomRecent = CommonMethod.GetBottomValue(item.Coin);
            }
        }
    }
}
