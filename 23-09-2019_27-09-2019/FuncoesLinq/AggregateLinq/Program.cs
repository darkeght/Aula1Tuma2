using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes
                //No Aggregate temos o nome atual que estamos lendo
                //e o proximo nome da lista 
                .Aggregate((nome1, nome2) => nome1 + ";\r\n" + nome2);
                //No passo seguinte temos o nome 'proximo' vira o atual
                //e pega o proximo da lista após o atual

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
