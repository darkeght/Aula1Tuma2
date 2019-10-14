using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace InterfaceAlunos
{
    class Program
    {
        //Inicio meu controle de alunos 
        static AlunosController alunos = new AlunosController();
        static void Main(string[] args)
        {
            alunos.AddAluno(new Aluno()
            {
                Nome =  "Riachsond",
                Idade = 8
            });

            alunos
                .GetAlunos() // Aqui obtemos a lista de alunos da nossa controller
                .ToList<Aluno>() //Converto os alunos para uma lista
                .ForEach //Uso o ForEach da lista para mostrar os alunos
                (x => Console.WriteLine($"Nome {x.Nome} e Idade {x.Idade}"));

            Console.ReadKey();
        }
    }
}
