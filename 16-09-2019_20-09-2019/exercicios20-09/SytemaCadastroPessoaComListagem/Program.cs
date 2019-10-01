using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SytemaCadastroPessoaComListagem.Models;
using System.Timers;
using SystemaAmigoFixo.Models;

namespace SytemaCadastroPessoaComListagem
{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();

        static void Hebeficar(out int idade)
        {
            idade = 16000;
        }

        //b = a;
        //Neste caso, "b" aponta para a mesma área 
        //de memória que "a", OU SEJA,
        //alterar o valor de "b" dentro deste método,
        //afetará a instância de "a" no método Main.
        static void Casar(Amigos b)
        {
            b.Nome += " Bernart";
        }

        // static bool PessoasQueNaoPodemSerPresas(Pessoa pes)
        // {
        //     return pes.Idade < 18;
        // }

        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Sexo = 'M';
            p1.Altura = 2.01;
            p1.Idade = 29;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Elóra";
            p2.Idade = 21;
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ronaldo";
            p3.Idade = 15;
            p3.Sexo = 'M';
            p3.Altura = 1.6;
            pessoas.Add(p3);

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }

            //Lambda = Where/OrderBy/FirstOrDefault
            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();

            pessoas.Where(pes => pes.Idade < 18);
            //Delegate
            //pessoas.Where(PessoasQueNaoPodemSerPresas);

            //delegate e anonymous method


















            List<int> numeros = new List<int>();
            Random rdm = new Random();

            //HashSet<int> dados = new HashSet<int>();
            //dados.Add(30);
            //dados.Add(30);
            for (int w = 0; w < 10; w++)
            {
                //Gera um número aleatório de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);
                //Verifica se a lista não contém este número gerado
                if (!numeros.Contains(valorGeradoAleatoriamente))
                {
                    //Adiciona o número gerado pelo random (que não é repitido)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    w--;
                }
            }

            Console.ReadLine();







            Amigos a = new Amigos();
            a.Nome = "Felipe";
            a.TempoAmizade = 20;
            Casar(a);
            Console.WriteLine(a.Nome);

            int ii = 30;
            Hebeficar(out ii);
            Console.WriteLine(ii);
            int resultadoConversao = 0;
            if (int.TryParse("145", out resultadoConversao))
            {

            }
            else
            {

            }


            List<string> nomes = new
               List<string>();
            nomes.Add("Ronaldo");
            nomes.Add("Rodriga");
            string nomeDela = nomes[1];
            string nomeDele = nomes[0];

            Dictionary<string, string> agendaTelefonica = new Dictionary<string, string>();

            agendaTelefonica.Add("Celo", "999938899");

            agendaTelefonica.Add("Felipe", "999931274");

            string meuCel = agendaTelefonica["Celo"];

            foreach (KeyValuePair<string, string> item in agendaTelefonica)
            {
                Console.WriteLine("O telefone de " + item.Key + " é " + item.Value);
            }



            byte bytE;
            Int16 shorT;
            Int32 inT;
            Int64 lonG;


            Int32 j = 10;
            long l = 100968098654;

            int i = 2147483647;
            i = i + 10;
            Console.WriteLine(i);

            double d = 12.2;
            double resposta = Math.Pow(d, 5);
            double numero = Math.Sqrt(144);

            double x = 10;
            int y = 10;
            //for (int i = 0; i < 100000000; i+//+)
            //{
            //    int.MaxValue
            //}



            Console.WriteLine("Digite 1 para inserir. ");
            //Console.WriteLine("Digite 2 para listar. ");
            var opcao = Console.ReadLine();

            //switch (opcao)
            //{
            //    case "1":
            //        AdicionaLista();
            //        break;
            //    case "2":
            //        listar();
            //        break;
            //    default:

            //}

            while (opcao == "1")
            {
                AdicionaLista();
                Console.WriteLine("Digite 1 para inserir. ");
                opcao = Console.ReadLine();
            }
            listar();
            Console.ReadKey();
        }

        public static void AdicionaLista()
        {
            Pessoa objetoPessoa = new Pessoa();

            Console.WriteLine("Informe nome");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe idade");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sexo");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe altura");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());

            listaPessoa.Add(objetoPessoa);
        }

        public static void listar()
        {
            listaPessoa.ForEach(ob => Console.WriteLine($"Nome {ob.Nome} Idade: {ob.Idade} Sexo: {ob.Sexo} Altura: {ob.Altura}"));
        }
    }
}
