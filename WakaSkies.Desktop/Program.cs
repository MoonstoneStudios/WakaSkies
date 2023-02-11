using Serilog;
using System.IO;
using System;

// create the logger
CreateLogger();
try
{
    // run the game.
    using var game = new WakaSkies.Desktop.Game1();
    game.Run();
}
catch(Exception e)
{
    // catch any uncaught errors.
    Log.Error("Program - Uncaught error.");
    Log.Error($"Program - Error info: {e.GetType().Name} {e.Message}");
    Log.Error($"Program - Stack trace: {e.StackTrace}");
}

void CreateLogger()
{
    // check if log dir exists.
    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WakaSkies");
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }

    var logs = Directory.GetFiles(path);
    var filePath = path + $"\\log{logs.Length}.txt";

    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.File(filePath, rollingInterval: RollingInterval.Infinite,
            rollOnFileSizeLimit: true, outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] - {Message}\n",
            shared: true)
        .CreateLogger();
}