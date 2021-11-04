using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABA9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var win1 = new InWindowWindow(1600, 900, 50, "12,24;18,25");
            var win2 = new FullscreenWindow(1600, 900);
            var user1 = new user();
            user1.squeeze += win1.Squeeze;
            user1.squeeze += win2.Squeeze;
            user1.DoSqueeze(0.5f);
            Console.WriteLine($"{win1} \n{win2}");
            user1.move += win1.Move;
            user1.DoMove("18,19;24,15");
            Console.WriteLine($"{win1} \n{win2}");
            Second();
        }

        private static void Second()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Func<string, string> A;
            var str = "abc   ,. de f,,,, GH";
            Console.WriteLine($"\n\n\nString: {str}");

            A = (st) => Regex.Replace(st, "[.,;:]", string.Empty);
            str = A(str);
            Console.WriteLine($"{str}");

            A = (st) => st + "!"; ;
            str = A(str);
            Console.WriteLine($"{str}");

            A = (st) => st.ToUpper();
            str = A(str);
            Console.WriteLine($"{str}");

            A = (st) => st.Replace(" ", string.Empty);
            str = A(str);
            Console.WriteLine($"{str}");
        }
    }
}