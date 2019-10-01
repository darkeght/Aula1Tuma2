using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    {
                        CalculaArea();
                        MenuSistema();
                    }
                    break;
                case 2:
                    {
                        AnimacoesEmFrames.ExecutarAnimacao();
                        MenuSistema();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Saindo...");
                        return;
                    }
                default:
                    break;
            }
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informa o lado do quadrado:");
            var ladoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
    }
}
