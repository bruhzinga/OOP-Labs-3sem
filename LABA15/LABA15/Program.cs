using System.Threading;
using System.Diagnostics;
using System.Reflection;

//first();
//second();
//third();
//fourth();
//fifth();
sixth();

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
}

static void third()
{
    /* Создайте в отдельном потоке следующую задачу расчета(можно сделать sleep для
     задержки) и записи в файл и на консоль простых чисел от 1 до n(задает пользователь).
 Вызовите методы управления потоком(запуск, приостановка, возобновление и т.д.) Во
 время выполнения выведите информацию о статусе потока, имени, приоритете, числовой
 идентификатор и т.д.*/

    var first = new Thread(ShowSimpleNumbers);
    first.Name = "SimpleNumbersThread";
    first.Start();
    first.Join();

    static void ShowThreadInfo(object thread)
    {
        var currentThread = thread as Thread;
        Console.WriteLine($"Name: {currentThread.Name}");
        Console.WriteLine($"Id: {currentThread.ManagedThreadId}");
        Console.WriteLine($"Priority: {currentThread.Priority}");
        Console.WriteLine($"Status: {currentThread.ThreadState}");
    }

    static void ShowSimpleNumbers()
    {
        var first = new Thread(ShowThreadInfo);
        first.Start(Thread.CurrentThread);
        first.Join();

        Console.WriteLine("INTER N!!!!!!!!!!!!!!!!!!!!!!!!");
        int n = int.Parse(Console.ReadLine());

        for (var i = 1; i <= n; i++)
        {
            var isSimple = true;
            for (var j = 2; j <= i / 2; j++)
                if (i % j == 0)
                {
                    isSimple = false;
                    break;
                }

            if (isSimple)
            {
                Console.Write($"{i} ");
                Thread.Sleep(100);
            }
        }
    }
}

static void fourth()
{
    /*Создайте два потока.Первый выводит четные числа, второй нечетные до n и
записывают их в общий файл и на консоль. Скорость расчета чисел у потоков – разная.
a.Поменяйте приоритет одного из потоков.
b.Используя средства синхронизации организуйте работу потоков, таким образом,
чтобы
i.выводились сначала четные, потом нечетные числа
ii.последовательно выводились одно четное, другое нечетное.*/
    int n = int.Parse(Console.ReadLine());
    void normal()
    {
        var first = new Thread(ShowEven);
        var second = new Thread(ShowOdd);
        second.Priority = ThreadPriority.Highest;
        first.Start();
        second.Start();
    }
    // normal();
    //FirstlyEvenSecondlyOdd();
    Alternating();

    void ShowEven()
    {
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }

    void ShowOdd()
    {
        for (int i = 0; i < n; i++)
        {
            if (i % 2 != 0) Console.WriteLine(i);
            Thread.Sleep(200);
        }
    }

    void FirstlyEvenSecondlyOdd()
    {
        var even = new Thread(ShowEven);
        var odd = new Thread(ShowOdd);
        even.Start();
        even.Join();
        odd.Start();
    }
    void Alternating()
    {
        var mutex = new Mutex();
        var even = new Thread(ShowEven);
        var odd = new Thread(ShowOdd);
        even.Start();
        odd.Start();

        void ShowEven()
        {
            for (int i = 0; i < n; i++)
            {
                mutex.WaitOne();
                if (i % 2 == 0) Console.WriteLine(i);
                Thread.Sleep(100);
                mutex.ReleaseMutex();
            }
        }
        void ShowOdd()
        {
            for (int i = 0; i < n; i++)
            {
                mutex.WaitOne();
                if (i % 2 != 0) Console.WriteLine(i);
                Thread.Sleep(200);
                mutex.ReleaseMutex();
            }
        }
    }
}
void fifth()
{
    /* Придумайте и реализуйте повторяющуюся задачу на основе класса Timer*/

    int num = 10;
    // устанавливаем метод обратного вызова
    TimerCallback tm = new TimerCallback(Count);
    // создаем таймер
    Timer timer = new Timer(tm, num, 0, 2000);

    Console.ReadLine();

    static void Count(object obj)
    {
        int x = (int)obj;
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}

void sixth()
{
    var storage = new Storage(20);
    var worker = new Thread(unload);
    var worker2 = new Thread(unload);
    var worker3 = new Thread(unload);

    worker.Start();
    worker2.Start();
    worker3.Start();

    void unload()
    {
        while (storage.storage > 0)
        {
            var mutex = new Mutex();
            mutex.WaitOne();
            storage.Unload();
            Random rnd = new Random();
            Thread.Sleep(rnd.Next(1000));
            mutex.ReleaseMutex();
        }
    }
}

internal class Storage
{
    public int storage;

    public Storage(int size)
    {
        storage = size;
    }

    public void Unload()
    {
        storage--;
        Console.WriteLine($"Current storage is {storage}");
    }
}