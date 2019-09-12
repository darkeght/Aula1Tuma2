using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Meu nome é Felipe Junior e minha mãe escolheu colocar Junior em meu nome porque achava legal.";

            var countFind = 0;

            Console.WriteLine("Encontre a palavra de até 3 caracteres:");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length -2); i++)
            {
                var palavraParaComparar = nome[i].ToString() +
                                          nome[i + 1].ToString() +
                                          nome[i + 2].ToString();

                if (palavra == palavraParaComparar)
                    countFind++;
            }

            Console.WriteLine($"Quantidade total de '{palavra}' {countFind}");

            Console.ReadKey();
        }
    }
}
