using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DZ_Api_1
{
    class ApiFunc
    {     
            public enum beepType
            { 
                SimpleBeep = -1,

                OK = 0x00,

                Question = 0x20,

                Exclamation = 0x30,

                Asterisk = 0x40,
            }
            public static void beep(beepType type)
            {
                MessageBeep((uint)type);
            }

        public const UInt32 WM_CLOSE = 0x0010;
        public const int WM_SETTEXT = 0xC;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern bool MessageBeep(uint type);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint dwFreq, uint dwDuration);

    }
}
