using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace BinanceApp.Common
{
    public class ChromeWrapper
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        private static uint WM_KEYDOWN = 0x100, WM_KEYUP = 0x101;

        public ChromeWrapper(){}
        public void SendKey(char key, Process process_chrome)
        {
            try
            {
                if (process_chrome.MainWindowHandle != IntPtr.Zero)
                {
                    SendMessage(process_chrome.MainWindowHandle, ChromeWrapper.WM_KEYDOWN, (IntPtr)key, IntPtr.Zero);
                    Thread.Sleep(30);
                    SendMessage(process_chrome.MainWindowHandle, ChromeWrapper.WM_KEYUP, (IntPtr)key, IntPtr.Zero);
                }
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e, $"ChromeWrapper:SendKey: {e.Message}");
            }
        }
    }
}
