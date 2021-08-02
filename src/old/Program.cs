using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
// using IronPython.Hosting;
// using Microsoft.Scripting.Hosting;
using WindowsInput;
using WindowsInput.Native;
namespace windows_api
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

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool SetSystemTime(ref SYSTEMTIME time);
    
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool GetSystemTime(ref SYSTEMTIME time); 

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetForegroundWindow(IntPtr hWnd);
}

//-----------------------------------------------------------------------------
string get_steam_direction_path() {}
void set_steam_direction_path(string path){}
game_info[] get_load_games(string steam_direction_path) {}
parse_file_game()
parse_plase_file_gema()
//-----------------------------------------------------------------------------
namespace tt
{
    class Program
    {
    static void ChangeSystemTime(int timeAdd) {
                SYSTEMTIME systemDate = new SYSTEMTIME();
        DateTime date2;
        date2 = DateTime.UtcNow.AddDays(timeAdd);



        
        systemDate.wDay = (short)date2.Day;
        systemDate.wDayOfWeek = (short)date2.DayOfWeek;
        systemDate.wHour = (short)date2.Hour;
        systemDate.wMinute = (short)date2.Minute;
        systemDate.wMonth = (short)date2.Month;
        systemDate.wSecond = (short)date2.Second;
        systemDate.wYear = (short)date2.Year;
        systemDate.wMilliseconds = (short)date2.Millisecond;

        SetSystemTime(ref systemDate);
    }

//         static void Run(string path, int time, int timeAdd, int repeat) {
//             // Process.Start(new ProcessStartInfo("cmd", $"/c start {path}"));

// // var uri = path;
// // var psi = new ProcessStartInfo();
// // psi.UseShellExecute = true;
// // psi.FileName = uri;
// var steam = "C:\\RogderData\\ProgramFiles\\Steam\\steam.exe";
// System.Diagnostics.Process.Start(new ProcessStartInfo("cmd", $"start {steam} {path}"));



//             Process proc = new Process();
//             string name;
//             // if (File.Exists(path)) {
                
//                 // proc.StartInfo.FileName = "cmd";
//                 // proc.StartInfo.Arguments = $"/c start {path}";




//                 proc.StartInfo.FileName = path;
//                 proc.StartInfo.UseShellExecute = true; 

//                 for (int i = 0; i < repeat; i++) {
//                     ChangeSystemTime(timeAdd);

//                     proc.Start();
//                     // name = proc.ProcessName;
//                     // Thread.Sleep(time * 1000);

                   

//                     // foreach (Process j in Process.GetProcessesByName(name)){
//                         // SendText(j.MainWindowHandle, "Hello, world");
//                         // SetForegroundWindow(j.MainWindowHandle);
                        
                        
//                         var sim = new InputSimulator();

//                         sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
//                         Thread.Sleep(3000);
//                         // j.Kill();
//                         proc.Kill(true);

//                     // }

//                     ChangeSystemTime(-timeAdd);
//                 }

                
//             // } else {
//             //     //создать ошибку
//             // }
//         }

        static void Main(string[] args)
        {
            // SYSTEMTIME time = new SYSTEMTIME();
            // GetSystemTime(ref time);

            // Console.WriteLine(time.wDay);
            // Console.WriteLine(time.wMonth);
            // Console.WriteLine(time.wYear);
            // time.wDay = 23;
            // Console.WriteLine(SetSystemTime(ref time));


            // Process proc = new Process();
            // proc.StartInfo.FileName = "D:\\Windows 10 Data\\Games\\SteamLibrary\\steamapps\\common\\Raksasi\\raksasi.exe";
            // proc.Start();
            // Console.WriteLine(proc.ProcessName);
            // // Process.Start("D:\\Windows 10 Data\\Games\\SteamLibrary\\steamapps\\common\\Raksasi\\raksasi.exe");
            // Console.WriteLine(proc.Id);
            // Console.WriteLine("Hello World!");
            // Thread.Sleep(10000);
            // foreach (Process i in Process.GetProcessesByName(proc.ProcessName)){
            //     Console.WriteLine(i.Id);
            //     i.Kill();
            // }

string[] dirs = Directory.GetFiles(@"D:\Windows 10 Data\Games\SteamLibrary\steamapps\common\Warhammer Vermintide 2", "*.exe", SearchOption.AllDirectories);


            // Run(
            //     // "D:\\Program files\\SteamLibrary\\steamapps\\common\\CrushCrush\\CrushCrush.exe",
            //     "D:\\Program files\\SteamLibrary\\steamapps\\common\\Raksasi\\raksasi.exe",
            //     // "steam://rungameid/1016600",
            //     30,
            //     7,
            //     2
            // );
foreach(string i in dirs)
    Console.WriteLine(i);

    var fi1 = new FileInfo(@"D:\Windows 10 Data\Games\SteamLibrary\steamapps\common\Magicka 2\engine\Magicka2.exe");
    var result = Path.GetFileNameWithoutExtension(@"D:\Windows 10 Data\Games\SteamLibrary\steamapps\common\Magicka 2\engine\Magicka2.exe");
Process localById = Process.GetProcessById(3556);
ProcessStartInfo startInfo = new ProcessStartInfo(@"D:\Windows 10 Data\Games\SteamLibrary\steamapps\common\Raksasi\raksasi.exe");

            Console.ReadKey();
        }
    }
}
namespace test // TODO требуется переименовать в что-то конкретное
{
    class Steam // TODO проверить на корректность названия(возможно переименовать) интерфейс??
    {
        public string get_steam_direction_path()
        {
            return steam_direction_path;
        }
    }

}