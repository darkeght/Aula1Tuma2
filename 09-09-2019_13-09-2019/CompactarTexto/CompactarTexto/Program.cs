using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Oi meu nome Felipe e logo eu Felipe tenho vontade de codar muito porque eu Felipe gosto de codar durante minha vida";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("Felipe", "1").Replace("codar", "2").Replace("eu","3")
               .Replace(" ","");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");


            primeiroTexto = primeiroTexto.Replace("1","Felipe").Replace("2","codar").Replace("3","eu");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");

            Console.ReadKey();
        }
    }
}
