// See https://aka.ms/new-console-template for more information
global using System.Reflection;
using LABA13;

var fileinfo = new ZDAFileInfo(new FileInfo(@"E:\source\bruhzinga\OOP\LABA13\LABA13\Log.txt"));
var driver = new ZDADiskInfo();
var Dir = new ZDADirInfo(@"E:\source\bruhzinga\OOP\LABA13\LABA13");

#region Subscriptions

driver.Update += ZDAlog.WriteToFile;
fileinfo.Update += ZDAlog.WriteToFile;
Dir.Update += ZDAlog.WriteToFile;

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
Dir.CountFiles();
Dir.CreationDate();
Dir.CountSubDirs();