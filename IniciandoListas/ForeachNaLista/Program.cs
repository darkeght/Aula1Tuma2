using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas 
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData
                .ToLongDateString()));
        }
        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(item => Console.WriteLine(item));
        }
        /// <summary>
        /// Metodo que mostra meus numeros inteiros
        /// </summary>
        private static void ListaDeInteiros()
        {
            var minhalista = new List<int>();

            minhalista.Add(17);
            minhalista.Add(18);
            minhalista.Add(19);
            minhalista.Add(20);

            minhalista.ForEach(meuNumero => Console.WriteLine(meuNumero));
        }
        /// <summary>
        /// minha lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " "+ FormataNumeroDecimaEmDolar(meuDecimal) + " " + 
              FormataNumeroDecimaEmEuro(meuDecimal) + " " +
              FormataNumeroDecimaEmYen(meuDecimal) + " " +
              FormataNumeroDecimaEmBitCoin(meuDecimal)));
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
                .Replace("$","Euro ");
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
