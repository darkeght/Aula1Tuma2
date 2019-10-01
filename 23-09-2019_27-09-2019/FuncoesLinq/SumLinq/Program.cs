using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamamos nossa função 
            SomarInteiroPrimitivos();

            SomaInteirosLista();

            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra numeros inteiros por um tipo primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes 
            //valores
            int[] colecaoInteiros =
                //alocamos memoria para nossa coleção de valor e informamos 
                //a quantidade de memoria que vamos ocupar 
                //memoriaOcupadaInt * quantidadeInformada
                new int[5]
            //Aqui carregamos nossa coleção de valores
            { 1,2,3,4,5 };

            //Aqui somamos os valores em nossa lista
            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma todos os valores em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {//Nossa coleção de valores
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Metodo que soma a quantidade de bala das crianças 
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memoria
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da minha lista 
                new Crianca()
                {
                    Nome = "Joazinho",//neste caso apenas uma propriedade de outra
                    Balas = 9 
                },//virgula separamos um objeto de outro 
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };

            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda");
            Console.WriteLine(
                //Soma nossa quantidade de balas
                criancas.Sum(x => x.Balas));
        }
    }
}
