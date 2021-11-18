namespace LABA3
{
    public partial class Airline
    {
        public void ShowCount()
        {
            Console.WriteLine($"Текущее количество рейсов: {count}\n");
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Airline airline = obj as Airline;
            if (airline == null)
            {
                return false;
            }
            return airline.ID == this.ID;
        }

        public override string ToString()
        {
            return $"\nID: {this.ID}\n" +
                $"destination: {this.destination}\n" +
                $"num: {this.num}\n" +
                $"type: {this.type}\n" +
                $"time: {this.time}\n" +
                $"weekdays: {this.weekdays}";
        }

        public override int GetHashCode()
        {
            return num * 25;
        }
    }
}