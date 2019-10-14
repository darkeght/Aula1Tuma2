using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        // 1 - Colocar console app para startar o projeto 
        // 2 - Adicionar referencia CatalagoCelulares
        // 3 - Adicionar Entity em nosso projeto
        // 4 - Adicionar using ao nosso projeto Model,Controller
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimos uma opção de menu inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0 
            //Ele continua em nosso loop
            while(opcao != 0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Atualizar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("4 - Listar Celular");
                Console.WriteLine("0 - Sair");
                //Obtemos o menu escolhido pelo usuario
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opção
                switch (opcao)
                {
                    //Caso for opção 1 ele inseri celular
                    case 1:
                        InserirCelular();
                        break;
                    //Caso for a opção 2 ele atualiza um celular existente
                    case 2:
                        AtualizarCelular();
                        break;
                    //Caso for a opção 3 ele remove o celular informado
                    case 3:
                        RemoverCelular();
                        break;
                    //Caso for opção 4 ele lista os celulares do sistema
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        //Informamos que estamos saindo do sistema
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default://Casso colocar uma opção não valida 
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //Colocamos true para informar que não deve aparecer na 
                //tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey(true);
                Console.Clear();

            }
        }

        //Inserir
        public static void InserirCelular()
        {
            //Apresentamos a tela em que estamos 
            Console.WriteLine("-- Inserir Celular --");
            Console.WriteLine("Informe a Marca do celular");
            //Obtemos a maca do usuario
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            //Obtemos o modelo do aparelho
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do aparelho");
            //Obtemos o valor do aparelho
            var preco = double.Parse(Console.ReadLine());
            //Criamos a resultado para identificar sucesso ou erro
            var resultado = celulares //Nossa controler pelo nome 
                //que demos a ela 
                .InserirCelular(new Celular()//Um novo celular
                {
                    Marca = marca,
                    Modelo = modelo,
                    Preco = preco
                });
            //Verificamos se o resultado e verdadeiro ou falso
            if (resultado)//Caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso!");
            else//Caso False apresenta o aviso 
                Console.WriteLine("Erro ao cadastra aparelho!");
        }
        //Atualizar
        public static void AtualizarCelular()
        {
            //Apresentamos a tela em que estamos 
            Console.WriteLine("-- Atualizar Celular --");

            ListarCelular();

            //Informamos ao usuario que ele precisa colocar o id para realizar a alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            //Obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que vamos atualizar
            var celular = celulares // Nossa controller
                .GetCelulares() //Obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId);//regra para obter o celular

            //Verificamos se o celular existe
            if (celular == null)
            {
                //Informo que esse id não encontrou um registro
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe a Marca do celular");
            //Obtemos a maca do usuario
            celular.Marca  = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            //Obtemos o modelo do aparelho
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do aparelho");
            //Obtemos o valor do aparelho
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares.//Nossa controller 
                AtualizarCelular(celular);//Metodo que atualiza o celular

            //Parte final que mostramos o resultado do processo de atualização
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso!");
            else
                Console.WriteLine("Erro ao atualizar aparelho");
        }
        //Remover
        public static void RemoverCelular()
        {
            //Apresentamos a tela em que estamos 
            Console.WriteLine("-- Remover Celular --");

            ListarCelular();

            //Informamos ao usuario que ele precisa colocar o id para realizar a remoção
            Console.WriteLine("Informe o Id para remoção do registro:");
            //Obtemos o id informado
            var celularId = int.Parse(Console.ReadLine());

            //Metodo que 'remove' o celular de nosso sistema
            var resultado = celulares.RemoverCelular(celularId);

            if (resultado)//Apresentação do resultado da operação
                Console.WriteLine("Celular removido com sucesso!");
            else
                Console.WriteLine("Erro ao remover aparelho");
        }
        //Listar
        public static void ListarCelular()
        {
            Console.WriteLine("-- Lista Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memoria
                .ForEach(x => //Laço de repetição para mostrar cada celular
                //Mostramos no console nosso celular
                Console.WriteLine($"Id:{x.Id} Marca:{x.Marca} Modelo:{x.Modelo} Preço:{x.Preco}"));
        }
    }
}
