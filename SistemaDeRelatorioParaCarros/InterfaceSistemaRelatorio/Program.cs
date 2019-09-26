using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Controller;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));

            Console.ReadKey();
        }

        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(
                string.Format("Id {0,3} Carro {1,-20}",vendas.Id,vendas.Carro));
        }
    }
}
