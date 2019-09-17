using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("( * )>");
            Console.WriteLine("  |  ");
            Console.WriteLine(" /|\\");
            Console.WriteLine("  |  ");
            Console.WriteLine(" /\\  ");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo principal de inicialização do sitema
        /// </summary>
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
   /// <summary>
        /// Metodo que converte moeda em real para um alvo espeficido
        /// para converter digite os alvos:
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimaEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimaEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimaEmYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecimaEmBitCoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Nenhuma opção válida informada");
                    break;
            }
        }

        /// <summary>
        /// Metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em Dolar</returns>
        private static string FormataNumeroDecimaEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// Metodo que converte meu numero em real para Euro
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em euro</returns>
        private static string FormataNumeroDecimaEmEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro ");
        }
        /// <summary>
        /// Metodo que converte meu numero real para Yen
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em Yen</returns>
        private static string FormataNumeroDecimaEmYen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Metodo que converte meu numero real em BitCon
        /// </summary>
        /// <param name="meuNumero">Meu numero em real</param>
        /// <returns>Retorna meu numero formatado em BitCoin</returns>
        private static string FormataNumeroDecimaEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "BTC ");
        }
    }
}
