using System;
using System.Runtime.InteropServices;

namespace WindowsAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEMTIME
    {
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;
    }
    
    class WindowsAPI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME time);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetSystemTime(ref SYSTEMTIME time); 

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}