using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[2];

            arrayLinear[0] = "Felipe";
            arrayLinear[1] = "Giomar";

            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Giomar",
                "Euricledson"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);
            var keypress = Console.ReadKey().KeyChar.ToString();
        }
    }
}
