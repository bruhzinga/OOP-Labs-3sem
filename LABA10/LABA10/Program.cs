using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LABA10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Harry_Potter = new Book(2);
            var Harry_Potter_2 = new Book(1);
            Harry_Potter.Add(12, "NICE");

            var MyList = new List<Book>()
            {
                Harry_Potter,
                Harry_Potter_2
            };
            Second();
            Third();
        }

        private static void Second()
        {
            Action<ArrayList> ShowList = (MyList) =>
            {
                foreach (var i in MyList)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            };
            var UList = new ArrayList()
            {
                12,
                "C# is cool",
                'c',
                12.02f,
                12.12
            };
            UList.Add("I like c#");

            ShowList(UList);
            Action<ArrayList, int> Remover = (MyList, num) =>
              {
                  MyList.RemoveRange(0, num);
              };
            Remover(UList, 3);
            ShowList(UList);

            var SecondList = new Queue(UList);
            foreach (var ins in SecondList)
            {
                Console.WriteLine(ins);
            }
            Func<Queue, object, bool> FindElement = (Mylist, element) =>
               {
                   if (Mylist.Contains(element)) return true;
                   return false;
               };

            Console.WriteLine(FindElement(SecondList, 12.02f));
        }

        private static void Third()
        {
            var OColletion = new ObservableCollection<int>()
            {
                12,
                15,
                1337,
                228,
                420,
            };
            OColletion.CollectionChanged += RegisterChange;
            OColletion.Add(1);
            OColletion.Remove(1337);
        }

        private static void RegisterChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.Write("\n" + $"Add comlete");
                foreach (var item in e.NewItems)
                {
                    Console.Write($" {item} ");
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.Write("\nRemove complete ");
                foreach (var item in e.OldItems)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}