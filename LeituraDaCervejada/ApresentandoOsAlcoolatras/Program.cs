using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionarCervejas(new Cerveja()
            {
                Id = cervejaController.GetCervejas().Count + 1,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 8,
                Valor = 0.98
            });

            cervejaController.GetCervejas().
                ForEach(x =>
           Console.WriteLine($"Id {x.Id} Nome {x.Nome} Litro {x.Litros} Valor {x.Valor} Álcool {x.Alcool}"));


            Console.WriteLine("Total litros " + cervejaController.TotalLitroCervejas());
            Console.WriteLine("Total Valor " + cervejaController.ValorTotalCervejas().ToString("C"));

            Console.ReadKey();
        }
    }
}
