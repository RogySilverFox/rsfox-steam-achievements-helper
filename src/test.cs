using System;
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

    public void CompleteTasks(string steamExePath, uint repeatCount)
    {
        Console.WriteLine("-- Start getting achievement --");
        for (uint i = 0; i < repeatCount; i++)
        {
            Console.WriteLine($"Iteration number = {i}");
            _CompleteBeforeTasks();
            _StartGame(_steamAppID, steamExePath);
            _CompleteCurrentTasks();
            _CloseGame(_gameFilesExe);
            _CompleteAfterTasks();

            // TODO Повтор для тупой логики игры гребанный хардкод
            _StartGame(_steamAppID, steamExePath);
            _CompleteCurrentTasks();
            _CloseGame(_gameFilesExe);
        }
        Console.WriteLine("-- End getting achievement --");
    }

    void _CompleteBeforeTasks()
    {
        Tasks.ChangeSystemTime(7);
    }

    void _CompleteCurrentTasks()
    {
        Tasks.DelayTime(5000);
        Tasks.PushButton();
        Tasks.DelayTime(30000);
    }

    void _CompleteAfterTasks()
    {
        Tasks.ChangeSystemTime(-7);
    }

    string[] _GetGameFilesExe(string gameDirPath)
    {
        return Directory.Exists(gameDirPath) ?
            Directory.GetFiles(gameDirPath, "*.exe", SearchOption.AllDirectories):
            new string[] {};
    }

    void _StartGame(int steamAppID, string steamExePath)
    {
        Process processGame = new Process();
        processGame.StartInfo.FileName = "cmd.exe";
        processGame.StartInfo.Arguments = $"/c START \"{steamExePath}\" steam://rungameid/{steamAppID}";
        processGame.Start();
    }

    void _CloseGame(string[] gameFilesExe)
    {
        foreach (string gameExe in gameFilesExe)
            foreach (var gameProcess in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(gameExe)))
                gameProcess.Kill();
    }
}