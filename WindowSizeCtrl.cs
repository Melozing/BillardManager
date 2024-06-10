using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillardManager
{
    public static class WindowSizeCtrl
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        public static void MoveWindow(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public static FormWindowState MinimizeAndScale(FormWindowState windowState)
        {
            if (windowState == FormWindowState.Normal)
            {
                return FormWindowState.Maximized;
            }
            else
            {
                return FormWindowState.Normal;
            }
        }

        public static void MinimizeForm(ref Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
