using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
using CodeFirstTeste.Controller;

namespace ConsoleApp1
{
    class Program
    {
        static  CervejaController Controller = new CervejaController(); 

        static void Main(string[] args)
        {
            Controller.AddCerveja(new Cerveja() { Nome = "Alguma coisa" });

            Console.ReadKey();
        }
    }
}
