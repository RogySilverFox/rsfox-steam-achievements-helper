using System.IO;
using System.Diagnostics;

class Test
{
    string _gameName;
    int _steamAppID;
    string _gameDirPath;
    string[] _gameFilesExe;

    public Test(string gameName, int steamAppID, string gameDirPath)
    {
        _gameName = gameName;
        _steamAppID = steamAppID;
        _gameDirPath = gameDirPath;
        _gameFilesExe = _GetGameFilesExe(gameDirPath);
    }

    public void CompleteTasks()
    {
        string steamExePath = @"C:\Program Files (x86)\steam.exe";
        _StartGame(_steamAppID, steamExePath);
        // _CloseGame(_gameFilesExe);
    }

    string[] _GetGameFilesExe(string gameDirPath)
    {
        return Directory.Exists(gameDirPath) ?
            Directory.GetFiles(gameDirPath, "*.exe", SearchOption.AllDirectories):
            new string[] {};
    }

    void _StartGame(int steamAppID, string steamExePath)
    {
        // Process.Start($"steam://rungameid/{steamAppID}");
        System.Diagnostics.Process.Start(
            new ProcessStartInfo("cmd", $"start \"{steamExePath}\" steam://rungameid/{steamAppID}")
        );
    }
}