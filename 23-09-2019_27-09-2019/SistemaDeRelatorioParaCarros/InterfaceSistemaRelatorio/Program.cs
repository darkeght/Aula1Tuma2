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

            MostraMenuRelatorio();
        }

        private static void MostraMenuRelatorio()
        {
            Console.Clear();

            Console.WriteLine("Menu de relatorios");
            Console.WriteLine("1 - Relatorio por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while(menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());

                switch (menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            //Obtemos a informação do mês
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            //Passamos o mes na mesma função para obter as vendas
                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            //Aqui imprimimos as informações para o usuario
                            listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaDoPeriodoEscolhido
                                //Somamos todos os registro multiplicando as valor venda vezes a quantidade 
                                .Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaDoPeriodoEscolhido
                                //Média de todos os registro multiplicando as valor venda vezes a quantidade 
                                .Average(x => x.Valor * x.Quantidade);

                            //Mostramos o mes escolhido e o valor total neste mês gerado
                            Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");
                            //Mostramos o mes escolhido e o valor médio de vendas no mes gerado
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                }
            }

        }

        public static void ImprimeInformacoes(Venda vendas)
        {
            Console.WriteLine(
                string.Format("Id {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,3} Data {4,12}"
                ,vendas.Id
                ,vendas.Carro
                ,vendas.Valor.ToString("C")
                ,vendas.Quantidade
                ,vendas.Data.ToShortDateString()));
        }
    }
}
