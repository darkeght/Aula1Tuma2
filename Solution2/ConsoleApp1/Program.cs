using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Iniciando uma constante de um numero inteiro
        const int testeConst = 999;


        static void Main(string[] args)
        {       
 
            string testePrimitivo = string.Empty;
            String outroTesteOrimitivo;
            bool testComp;
            Boolean testeComp;

            bool? testeBoolNull;

            int numeroInteiro = 999;
            long numeroInteiroLongo = 8598215;

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String"; //Texto
            var teste2 = 'A'; //Char
            var teste3 = 8; //Int
            var teste4 = 3.8; //Double
            var teste5 = 0x0F; //Hex
            //Apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
