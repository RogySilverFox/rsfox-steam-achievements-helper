//https://www.youtube.com/watch?v=9vW6LJThpBM
using System;
// using Steamworks; 

namespace rsfox_steam_achievements_helper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int steamAppID = int(args[0]);
            // string steamAppID = "40700";
            // Environment.SetEnvironmentVariable("SteamAppID", steamAppID);
            // bool isSteamInit = SteamAPI.Init();
            
            // if (!isSteamInit) 
            // {
            //     Console.WriteLine("Steam not active!!!");
            //     return;
            // }

            // string achievementName;
            // for (uint i = 0; i < SteamUserStats.GetNumAchievements(); i++)
            // {
            //     achievementName = SteamUserStats.GetAchievementName(i);
            //     SteamUserStats.GetAchievement(achievementName, out bool opened);
            //     if (!opened) SteamUserStats.SetAchievement(achievementName);
            // }
            // SteamUserStats.StoreStats();

            string gameName = "CrushCrush";
            int steamAppID = 459820;
            string gameDirPath = @"D:\Program files\SteamLibrary\steamapps\common\CrushCrush";
            string steamExePath = @"C:\Program Files (x86)\steam.exe";
            uint tasksRepeatCount = 1;
            
            if (args.Length == 1)
            {
                try
                {
                    tasksRepeatCount = uint.Parse(args[0]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{args[0]}'");
                }
            }

            Test test = new Test(gameName, steamAppID, gameDirPath);
            test.CompleteTasks(steamExePath, tasksRepeatCount);
        }
    }
}
