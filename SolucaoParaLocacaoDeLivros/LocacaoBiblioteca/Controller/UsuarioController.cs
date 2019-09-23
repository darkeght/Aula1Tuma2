using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        //Criando privado para impedir o programador de adicionar um ID ou alterar fora da classe
        private int IdContador = 1;
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o Id contador incrementando o mesmo com ele + 1 "++"
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"
            }); ;

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "darkeght",
                Senha = "123456"
            });
        }

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListaDeUsuarios().Exists(x => 
               x.Login == usuarios.Login 
            && x.Senha == usuarios.Senha);
        }
        private List<Usuario> ListaDeUsuarios { get; set; }
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="usuario">Novo usuario que será adicionado a lista</param>
        public void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = IdContador++;
            //Adiciono o meu usuario a minha lista
            ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios ativos</returns>
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente a lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            //Aqui usamos o metodo FirstOrDefaul para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e dasativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
