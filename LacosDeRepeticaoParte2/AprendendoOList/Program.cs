using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)
        {
            AdicionarItensALista();

            ListaInformacoes();

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que adiciona um item a lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? sim(S) qualquer outra tecla para não");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();
        }

        /// <summary>
        /// Metodo que mostra a lista
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine(item.ToUpper());
        }
    }
}
