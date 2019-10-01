using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var classePessoa = new Pessoa();

            #region Pra isso que utiliza
            classePessoa.ListaDePessoa = new List<Pessoa>();

            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 1, Nome = "Spears  ", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            classePessoa.ListaDePessoa.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
            #endregion

            classePessoa.RetornaListaCrescentePeloNome()
                .ForEach(i => ImprimeInformacao(i));

            classePessoa.RetornaListaDecrescentePelaData()
                .ForEach(i => ImprimeInformacao(i));

            classePessoa.RetornaListaPessoasDinheiroMaiorQue()
                .ForEach(i => ImprimeInformacao(i));

            classePessoa.RetornaListaDeMaiorDeIdade()
                .ForEach(i => ImprimeInformacao(i));

            classePessoa.RetornaListaDeMenorDeIdade()
                .ForEach(i => ImprimeInformacao(i));

            Console.ReadKey();
        }

        private static void ImprimeInformacao(Pessoa pessoa)
        {
            Console.WriteLine($"Id {pessoa.Id} Nome {pessoa.Nome} DataNascimento {pessoa.DataNascimento.ToShortDateString()} Carteira {pessoa.Carteira.ToString("N2")}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
