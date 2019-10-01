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
            #region Codando muito
            var cestaDeFrutas = new List<Fruta>();

            #region Carregando minha cesta
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
            #endregion

            #region Lista 1
            cestaDeFrutas.
                //Neste ponto ordenamos os valores de forma decrescente pelo nome
                OrderByDescending(x => x.Nome).ToList<Fruta>().
                ForEach(i => 
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            #endregion

            Console.WriteLine("-----------------------------");

            #region Lista 2
            cestaDeFrutas.
                //Aqui ordenamos os valores pelo id de forma crescente 
                OrderBy(x => x.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));
            #endregion

            Console.WriteLine("----------------------------- Filtro Peso");

            #region Lista 3
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
            #endregion

            Console.WriteLine("----------------------------- Filtro Cores");

            // aqui  criamos uma variavel que recebera o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //aqui é feito o filtro das informações por uma "ou --> || <--- " outra cor
                Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome} este aqui");
            //aqui criamos uma variavel que recebera a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFrutas.
                //Find all com esta condição tras frutas de cor amarela "ou" vermelhas
                FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //imprimo com a função do ForEach do linq
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome}"));
            //Aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

            Console.WriteLine("----------------------------- Find com order by");

            var cestaDeFrutasFindOrder = cestaDeFrutas
                //Ordenei minha lista 
                .OrderBy(x => x.Nome)
                //Converti para lista de fruta novamente
                .ToList<Fruta>()
                //Busco minha informação
                .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");


            var totalGramas = cestaDeFrutas.Sum(x => x.Peso);
            var mediaGramas = cestaDeFrutas.Average(x => x.Peso);



            Console.ReadKey();
            #endregion
        }
    }
}
