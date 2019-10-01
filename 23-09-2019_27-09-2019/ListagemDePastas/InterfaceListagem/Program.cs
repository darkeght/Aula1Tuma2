using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        //Instanciamos  nossa classe principal
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while(menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pasta");
                Console.WriteLine("1 - Criar Pasta em MeusDocumentos");
                Console.WriteLine("2 - Deletar Pasta em Meus Documentos");
                Console.WriteLine("3 - Listar Meus Documentos");
                Console.WriteLine("4 - Bonus Sextouuuuuuuu");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        //Informo pro usuario que ele deverá informar um nome para a pasta
                        Console.WriteLine("Informe o nome da pasta:");
                        //Aqui obtemos o nome que ele digitou para a pasta dele
                        var nomePasta = Console.ReadLine();
                        //Este metodo como mostra na docuemntação cria a pasta com base no nome
                        //que passamos
                        documents.CriarPastaMeusDocumentos(nomePasta);
                        break;
                    case 2:
                        Console.WriteLine("Informar o nome da pasta para excluir:");

                        var nomePastaD = Console.ReadLine();

                        documents.DeletarPastaMeusDocumentos(nomePastaD,true);
                        break;
                    case 3:
                        //Obtemos a lista completa de pasta dentro dos meus documentos
                        documents.ObterPastasDiretorioMeuDocumentos()
                            //Apresentamos esta lista para o usuario
                            .ForEach(x => Console.WriteLine(x));
                        break;
                    case 4:
                        //Bora beber rapaziadaaaaaaaaaaaaaaaaaa
                        new HoraDoShow().Birllllllllll();
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
