using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });

            cestaDeFrutas.
                //Neste ponto ordenamos os valores de forma decrescente pelo nome
                OrderByDescending(x => x.Nome).ToList<Fruta>().
                ForEach(i => 
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));

            Console.WriteLine("-----------------------------");

            cestaDeFrutas.
                //Aqui ordenamos os valores pelo id de forma crescente 
                OrderBy(x => x.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));

            Console.WriteLine("----------------------------- Filtro Peso");

            var filtroCesta = cestaDeFrutas
                //Aqui filtramos os registro maiores de 100 gramas
                .Where(x => x.Peso > 100)
                //Ordernamos estes valores pelo nome
                .OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>()
               .ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Peso {i.Peso}"));

            //frutinha recebe cada fruta de nossa cesta 
            (from frutinha in cestaDeFrutas //<- aqui temos a coleção de frutas
                              where frutinha.Peso > 100 //<- aqui escolhemos somente frutas com mais de 100g
                              select frutinha)//<- Neste ponto eu junto as informações que filtrei e retorno
                              .ToList<Fruta>()//<- Convertemos para uma lista amiga novamente 
                              .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));//<- imprimimos estas informações pelo console 

            Console.ReadKey();
        }
    }
}
