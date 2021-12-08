using System.Threading;
using System.Diagnostics;
using System.Reflection;

first();
//second();
static void first()
{
    //1. Определите и выведите на консоль/в файл все запущенные процессы:id, имя, приоритет,
    //время запуска, текущее состояние, сколько всего времени использовал процессор и т.д.
    var allProcess = Process.GetProcesses();
    foreach (var process in allProcess)
        try
        {
            Console.WriteLine(
                $"ID: {process.Id}  Name: {process.ProcessName} Priority: {process.BasePriority} " +
                $"VirtualMemorySize64: {process.VirtualMemorySize64}");
            Console.WriteLine(
                $"Start time : {process.StartTime}  Total processor time: {process.TotalProcessorTime}\n");
        }
        catch
        {
        }
}

static void second()
{
    var domain = AppDomain.CurrentDomain;
    Console.WriteLine($"Name: {domain.FriendlyName}\n");
    Console.WriteLine($"Config datails: {domain.SetupInformation}\n");
    Console.WriteLine($"Base Directory: {domain.BaseDirectory}\n");
    Console.WriteLine("Assemblies: \n");

    domain.GetAssemblies().ToList().ForEach(x => Console.WriteLine(x.FullName));

    //TODO неясно,правильно ли сделано,хотя тут по всей лабе проверить что либо трудняво
}