using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Carteira { get; set; }
        public List<Pessoa> ListaDePessoa { get; set; }
        public Pessoa()
        {

        }

        public List<Pessoa> RetornaListaCrescentePeloNome()
        {
            return ListaDePessoa.OrderBy(x => x.Nome).ToList<Pessoa>();
        }

        public List<Pessoa> RetornaListaDecrescentePelaData()
        {
            return ListaDePessoa.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
        }

        public List<Pessoa> RetornaListaPessoasDinheiroMaiorQue()
        {
            return ListaDePessoa.FindAll(x => x.Carteira > 500);
        }

        public List<Pessoa> RetornaListaDeMaiorDeIdade()
        {
            return ListaDePessoa.
                FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= 18);
        }

        public List<Pessoa> RetornaListaDeMenorDeIdade()
        {
            return ListaDePessoa.
                FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) <= 16);
        }

    }
}
