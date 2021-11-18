//Пункт назначения,
//Номер рейса, Тип самолета, Время вылета, Дни недели.
namespace LABA3
{
    public partial class Airline
    {
        //поля
        private static string origin_country;

        private static int count;
        private const int MAX_NUM = 9999;
        private readonly int ID;

        //
        private string destination;

        private int num;
        private string type;
        private int time;
        private string weekdays;

        public string Destination
        { get => destination; set { destination = value; } }

        public int Num
        {
            get { return num; }
            set
            {
                if (value >= 0 && value <= MAX_NUM)
                    num = value;
                else
                    Console.WriteLine("Неверный номер!");
            }
        }

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        public int Time
        {
            get { return time; }
            set
            {
                if (value < 24)

                    time = value;
                else
                {
                    Console.WriteLine("Неверный формат!");
                }
            }
        }

        public string Weekdays
        {
            get { return weekdays; }
            set { weekdays = value; }
        }

        public int Count
        {
            get { return count; }
        }

        //конструкторы
        static Airline()
        {
            origin_country = "Belarus";
            count = 0;
        }

        public Airline()
        {
            ID = GetHashCode();
            Airline.count++;
            this.destination = "UNDEFINED";
            this.type = "UNDEFINED";
            this.weekdays = "UNDEFINED";
        }

        private Airline(int id)
        {
            this.ID = id;
            Airline.count++;
        }

        public Airline(string destination, int num, string type = "UNDEFINED", int time = 0, string weekdays = "UNDEFINED")
        {
            if (num < MAX_NUM && time < 24)
            {
                this.destination = destination;
                this.num = num;
                this.type = type;
                this.time = time;
                this.weekdays = weekdays;
                this.ID = GetHashCode();
                Airline.count++;
            }
            else
                throw new Exception("Некорректный ввод!");
        }

        //метод
        public void ChandeDestination(ref string destination)
        {
            this.destination = destination;
        }
    }
}