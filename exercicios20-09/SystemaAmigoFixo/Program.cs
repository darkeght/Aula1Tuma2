using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemaAmigoFixo.Models;

namespace SystemaAmigoFixo
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new List<Amigos>();

            listaAmigos.Add( new Amigos() {
                Nome = "Pedro",
                TempoAmizade = 5
            });

            listaAmigos.Add(new Amigos()
            {
                Nome = "Maria",
                TempoAmizade = 10
            });

            listaAmigos.Add(new Amigos()
            {
                Nome = "Paulo",
                TempoAmizade = 3
            });

            listaAmigos.ForEach(amigo => Console.WriteLine($"Nome: {amigo.Nome} tempo Amizade {amigo.TempoAmizade}"));
            Console.ReadKey();
        }
    }
}
