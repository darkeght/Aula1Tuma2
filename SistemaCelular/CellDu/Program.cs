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
                    default://Casso colocar uma opção não valida 
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //Colocamos true para informar que não deve aparecer na 
                //tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
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
        //Remover
        //Listar
    }
}
