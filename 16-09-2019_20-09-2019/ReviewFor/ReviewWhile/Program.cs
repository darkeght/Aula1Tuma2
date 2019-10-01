using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto:");
            var conteudoDoTexto = Console.ReadLine();

            var count = 0;

            while(count < conteudoDoTexto.Length)
            {
                Console.WriteLine(conteudoDoTexto[count]);
                count++;
            }

            Console.ReadKey();
        }
    }
}
