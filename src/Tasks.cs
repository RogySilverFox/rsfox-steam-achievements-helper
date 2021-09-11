using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using WindowsAPI;

class Tasks
{
    public static void ChangeSystemTime(int daysCount)
    {
        SYSTEMTIME systemDate = new SYSTEMTIME();
        DateTime date = DateTime.UtcNow.AddDays(daysCount);
        
        systemDate.wDay = (short)date.Day;
        systemDate.wDayOfWeek = (short)date.DayOfWeek;
        systemDate.wHour = (short)date.Hour;
        systemDate.wMinute = (short)date.Minute;
        systemDate.wMonth = (short)date.Month;
        systemDate.wSecond = (short)date.Second;
        systemDate.wYear = (short)date.Year;
        systemDate.wMilliseconds = (short)date.Millisecond;

        WindowsAPI.WindowsAPI.SetSystemTime(ref systemDate);
    }

    public static void DelayTime(int millisecondsCount)
    {
        Thread.Sleep(millisecondsCount);
    }

    public static void PushButton()
    {
        // press only Enter
        var inputSimulator = new InputSimulator();
        inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN).Sleep(1000);
    }
}