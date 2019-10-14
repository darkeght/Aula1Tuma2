using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa( // Aqui utilizamos o metodo da controler para 
                new Pessoa() // adicionar a pessoa em nossa lista
                {
                    Nome = "Felipe" // Novo registro
                }); //O metodo AddPessoa tem o SaveChanges que realiza a gravação 
            //das informações em nosso banco de dados

            pessoa.GetPessoas() //Obtemos a lista de pessoas
                .ToList<Pessoa>() //Convertemos para uma lista de pessoas
                .ForEach(x => Console.WriteLine(x.Nome)); //Mostramo em nosso console

            Console.ReadKey();
        }
    }
}
