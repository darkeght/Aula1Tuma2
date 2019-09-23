using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que controla as informações dos nossos livros
    /// </summary>
    public class LivrosController
    {
        private int IdContador = 1;
        /// <summary>
        /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()
        {
            //criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();

            //Adicionamos os livros 
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                //Informo apenas o nome do livro para adicionar
                Nome = "Meu Primeiro Livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro"
            });
        }
        //Aqui crio uma propriedade para acessar o a lista de livros disponiveis no sistema
        private List<Livro> ListaDeLivros { get; set; }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do 
        /// construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista.
            parametroLivro.Id = IdContador++;
            ListaDeLivros.Add(parametroLivro);
        }
        /// <summary>
        /// Metodo que retorna a lista de livros
        /// </summary>
        /// <returns>Lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }

    }
}
