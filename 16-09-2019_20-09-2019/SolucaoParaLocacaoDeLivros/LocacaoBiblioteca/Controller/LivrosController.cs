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
        private LocacaoContext contextDB = new LocacaoContext();
        /// <summary>
        /// Metodo construtor que prepara o terreo para já iniciar com livros pré cadastrados
        /// </summary>
        public LivrosController()
        {

        }
        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada" criada dentro do 
        /// construtor
        /// </summary>
        /// <param name="parametroLivro">Informações do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            //Adicionamos o livro em nossa lista.
            contextDB.ListaDeLivros.Add(parametroLivro);

            //Salvamos em nosso banco de dados as informações
            contextDB.SaveChanges();
        }
        /// <summary>
        /// Metodo que retorna a lista de livros
        /// </summary>
        /// <returns>Lista de livros</returns>
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// Metodo para desativar o registro de livro pelo Id
        /// </summary>
        /// <param name="identificadoID">Id do livro que vamos desativar</param>
        public void RemoverLivroPorId(int identificadoID)
        {
            //FirstOrDefault retorna null em caso de não encontrar um registro
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadoID);
            //Tratamento do valor quando ele não encontrar um livro com o id
            if (livro != null)
                livro.Ativo = false;

            //Salvamos as alterações em nosso banco de dados
            contextDB.SaveChanges();
        }
        /// <summary>
        /// Metodo para atualizar nosso livro dentro do sistema
        /// </summary>
        /// <param name="item">Livro que vamos etsra atualizando dentro do sistema</param>
        /// <returns>Retorna verdadeiro para quando o mesmo atualizar o livro</returns>
        public bool AtualizarLivro(Livro item)
        {
            var findLivro = contextDB //Nosso banco de dados 
                .ListaDeLivros //Lista de livros do nosso bando de dados
                .FirstOrDefault(x => x.Id == item.Id); //regra de busca do nosso livro

            if(findLivro != null) //Verificamos se o livro realmente existe para estarmos atualizando
            {
                //Colocamos a data de alteração do nosso registro
                findLivro.DataAlteracao = DateTime.Now;
                //Salvamos em nosso banco de dados 
                contextDB.SaveChanges();
                //Retornamos veraddeiro para alteração
                return true;
            }
            //So chegamos a este ponto quando ele nao realizar o salvamento da alteração
            return false;
        }
    }
}
