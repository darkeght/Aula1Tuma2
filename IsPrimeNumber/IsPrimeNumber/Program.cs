using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;

            List<int> primeNumbers = new List<int>();

            for (int i = 0; i < 9999999; i++)
                if (IsPrime(i))
                    primeNumbers.Add(i);

            Console.WriteLine(dateNow - DateTime.Now);
            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            if (n > 1 && n % 2 != 0)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }

            return false;
        }
    }
}
