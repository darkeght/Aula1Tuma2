using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        //Instanciamos "Carregamos para memoria" nosso controlador dos livros
        static LivrosController livros = new LivrosController();

        //Instanciamos "Carregamos para memoria" nosso controlador dos usuarios
        static UsuarioController usuarioController = new UsuarioController();

        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            //Aqui realizamos a tela de login do nosso sistema
            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos");

            //Realizamos a chamada "invok" do nosso menu do sistema em um metodo
            MostraMenuSistema();
        }
        /// <summary>
        /// Mostra no console o menu  disponivel do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            //Iniciamos nossa variavel com o menot valor de int possivel
            var menuEscolhido = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                //Mostra as opções de menu dentro do nosso sistema.
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Trocar usuário");
                Console.WriteLine("0 - Sair");

                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamada do menu de listagem de usuarios
                        Mostrausuarios();
                        break;
                    case 2:
                        //Realiza a chamada do menu de listagem de livros
                        MostrarLivro();
                        break;
                    case 3:break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// Metodo para mostrar a lista de usuarios já cadastrados no sistema
        /// </summary>
        private static void Mostrausuarios()
        {
            //Aqui andamos pela lista de usuarios e mostramos ela no console
            usuarioController.ListaDeUsuarios.ForEach(i =>
            Console.WriteLine($"Login usuário:{i.Login}"));

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra os livros já cadastrados em nossa lista
        /// </summary>
        private static void MostrarLivro()
        {

            livros.Livros.ForEach(i => 
            //Para cada livro cadastrado temos a demostração no console por esta parte
            Console.WriteLine($"Nome do livro:{i.Nome}"));

            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que realiza os procedimento complestos de login dentro do 
        /// sistema como solicitação de login e senha pelo console assim como a 
        /// respectivas validações que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados
        /// estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.Clear();
            //Informamos o que é preciso para entrar no sistema
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            //Informamos no console que precisamos do Login do usuario
            Console.WriteLine("Login:");
            //Solicitamos o login
            var loginDoUsuario = Console.ReadLine();

            //Informamos no console que precisa da senha
            Console.WriteLine("Senha:");
            //Solicitamos a senha do usuario
            var senhaDoUsuario = Console.ReadLine();

            //aqui carregamos em memoria nosso controlador de usuarios 
            UsuarioController usuarioController = new UsuarioController();

            //Validamos o login de maneira duvidosa
            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            }); 
        }
    }
}
