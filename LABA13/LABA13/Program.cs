// See https://aka.ms/new-console-template for more information
global using System.Reflection;
using LABA13;

var fileinfo = new ZDAFileInfo(new FileInfo(@"E:\source\bruhzinga\OOP\LABA13\LABA13\Log.txt"));
var driver = new ZDADiskInfo();
var dir = new ZDADirInfo(@"E:\source\bruhzinga\OOP\LABA13\LABA13");
var manager = new ZDAFileManager();

#region Subscriptions

driver.Update += ZDAlog.WriteToFile;
fileinfo.Update += ZDAlog.WriteToFile;
dir.Update += ZDAlog.WriteToFile;

#endregion Subscriptions

Console.ForegroundColor = ConsoleColor.Green;
driver.ShowFreeSpaceOnDrive("D");
driver.ShowFileSystemnfo();
driver.ShowInfoForAll();

Console.ForegroundColor = ConsoleColor.Red;
fileinfo.ShowFullPath();
fileinfo.ShowSizeNameExtension();
fileinfo.ShowDates();

Console.ForegroundColor = ConsoleColor.Blue;
dir.CountFiles();
dir.CreationDate();
dir.CountSubDirs();

Console.ForegroundColor = ConsoleColor.Cyan;
manager.Task1(@"D:\");
manager.Task2(@"E:\source\MAD-2021\MAD-2021", ".cpp");
manager.Task3();

Console.ForegroundColor = ConsoleColor.DarkGreen;
ZDAlog.Logmanager.GetLogOfTime("11:41");
ZDAlog.Logmanager.GetLogOfWord("session");
ZDAlog.Logmanager.Count();
ZDAlog.WriteEndSession();