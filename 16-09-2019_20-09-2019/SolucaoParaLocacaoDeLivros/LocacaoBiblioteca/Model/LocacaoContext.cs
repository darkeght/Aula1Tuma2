using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        ///Propriedade que armazena o ID dos livros adicionado ao sistema
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1; 
        /// <summary>
        /// Metodo contrutor que prepara nossa classe LocacaoContext
        /// </summary>
        public LocacaoContext()
        {
            //criamos uma lista de livros em memoria
            ListaDeLivros = new List<Livro>();
            //criamos uma lista de usuarios em memoria
            ListaDeUsuarios = new List<Usuario>();

            //Adicionamos os livros 
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                //Informo apenas o nome do livro para adicionar
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Segundo Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Guia do mochileiro das galaxias 'Pika'"
            });

            //Adicionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });
        }

        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }
}
