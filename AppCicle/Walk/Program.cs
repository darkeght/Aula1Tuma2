using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Walk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FirstFrame(500);
                SecondFrame(500);
                ThirdFrame(500);
            }
        }

        private static void FirstFrame(int perform)
        {
            Console.Clear();
            Console.WriteLine(" (* )>");
            Console.WriteLine("  |/");
            Console.WriteLine(" /|  ");
            Console.WriteLine("  |\\");

            Thread.Sleep(perform);
        }

        private static void SecondFrame(int perform)
        {
            Console.Clear();
            Console.WriteLine(" (* )>");
            Console.WriteLine("__|__");
            Console.WriteLine("  |  ");
            Console.WriteLine("  |  ");

            Thread.Sleep(perform);
        }

        private static void ThirdFrame(int perform)
        {
            Console.Clear();
            Console.WriteLine(" (- )>");
            Console.WriteLine(" \\|  ");
            Console.WriteLine("  |\\");
            Console.WriteLine(" /|  ");

            Thread.Sleep(perform);
        }
    }
}
