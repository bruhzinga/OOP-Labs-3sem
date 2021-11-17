using LABA11;
using LABA3;

First();
Second();

static void First()
{
    Action<IEnumerable<string>> Show = (n) =>
    {
        foreach (var i in n)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    };
    string[] months =
                    {
    "January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December" };
    var n = 6;
    var nlenth = months.Where(x => x.Length == n);
    Show(nlenth);

    var SummerOrWinter = months
        .Where(x => Array.IndexOf(months, x) < 2 ||
        Array.IndexOf(months, x) > 4 && Array.IndexOf(months, x) < 8 ||
        Array.IndexOf(months, x) == 11);
    Show(SummerOrWinter);
    var AlphabetOrder = months
        .OrderBy(x => x);
    Show(AlphabetOrder);
    var ContainsUAndMoreThan4 = months
        .Where((x) => x.Contains("u") && x.Length <= 4);
    Show(ContainsUAndMoreThan4);
}

static void Second()
{
    Action<IEnumerable<Airline>> Show = (n) =>
    {
        foreach (var item in n)
        {
            Console.WriteLine(item.ToString());
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("//////////////////////////////////////////////");
        Console.ResetColor();
        ;
    };
    var airs = new List<Airline>
    {
    new Airline("MOSCOW", 12, "HEAVY", 10, "wednesday"),
    new Airline("MOSCOW", 25, "HEAVY", 15, "saturday"),
    new Airline("LAS VEGAS", 5, "LIGHT",12,"saturday"),
    new Airline("KABUL", 1, "HEAVY", 11, "wednesday"),
    new Airline("NEW YORK", 13, "LIGHT", 23, "sunday"),
    new Airline("MOSCOW", 15, "HEAVY", 22, "monday")
    };

    var exerise = airs
        .Where(air => air.Destination == "MOSCOW");
    Show(exerise);

    exerise = airs
        .Where(air => air.Weekdays == "wednesday");
    Show(exerise);
    exerise = airs
        .Where(air => air.Weekdays == "saturday")
        .OrderBy(airs => airs.Time)
        .Take(1);
    Show(exerise);
    exerise = airs
        .Where(air => air.Weekdays == "wednesday" || air.Weekdays == "saturday")
        .OrderBy(airs => airs.Time)
        .TakeLast<Airline>(1);
    Show(exerise);
    exerise = airs
        .OrderBy(airs => airs.Time);
    Show(exerise);
    var exersise2 = airs
        .Where(air => air.Destination == "MOSCOW")
        .OrderByDescending(airs => airs.Time)
        .Skip(1)
        .TakeLast(2)
        .Sum(airs => airs.Num);
    Console.WriteLine(exersise2);

    var passangers = new List<Passanger>
    {
        new Passanger("IVAN",12),
        new Passanger("HOVA",25),
        new Passanger("DIMA",5)
    };
    var result = airs
        .Join(passangers,
                plane => plane.Num,
                pass => pass.PlaneID,
                (plane, pass) => new { plane = plane, passanger = pass });
    foreach (var item in result)
    {
        Console.WriteLine(item.plane);
        Console.WriteLine(item.passanger.Name);
    }
}