//https://www.youtube.com/watch?v=9vW6LJThpBM
using System;
using Steamworks; 

namespace rsfox_steam_achievements_helper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int steamAppID = int(args[0]);
            string steamAppID = "40700";
            Environment.SetEnvironmentVariable("SteamAppID", steamAppID);
            bool isSteamInit = SteamAPI.Init();
            
            if (!isSteamInit) 
            {
                Console.WriteLine("Steam not active!!!");
                return;
            }

            string achievementName;
            for (uint i = 0; i < SteamUserStats.GetNumAchievements(); i++)
            {
                achievementName = SteamUserStats.GetAchievementName(i);
                SteamUserStats.GetAchievement(achievementName, out bool opened);
                if (!opened) SteamUserStats.SetAchievement(achievementName);
            }
            SteamUserStats.StoreStats();
        }
    }
}
