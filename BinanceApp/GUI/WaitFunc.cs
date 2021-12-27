using System.Threading;

namespace BinanceApp.GUI
{
    class WaitFunc
    {
        frmWaitForm loadingForm;
        Thread loadthread;
        private string _mes = string.Empty;
        public void Show(string mes = "")
        {
            _mes = mes;
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }
        public void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new ThreadStart(loadingForm.Close));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void LoadingProcessEx()
        {
            loadingForm = new frmWaitForm(_mes);
            loadingForm.ShowDialog();
        }
    }
}
