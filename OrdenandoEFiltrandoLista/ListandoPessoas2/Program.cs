using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas 
            //podemos agora listar e demais funcionalidades
            PessoaController pessoaController 
                //Nesta parte ao iniciar em memoria 
                //Iniciamos o contrutor
                = new PessoaController();

            //Aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublica
                //Usamos o ForEach do linq para percorrer a lista
                .ForEach(i => //criamos a variavel i para receber o item da nossa lista
                //Imprimimos a informação de cada item da nossa lista
                MostraInformacoes(i));

            MostraIdentificador("Lista ordenada pelo nome");

            pessoaController
                .GetPessoasOrdenadaAsc()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista ordenada por data");

            pessoaController
                .GetPessoasOrdenadaDescPelaDataNascimento()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista ordenada pela carteira");

            pessoaController
                .GetPessoasComMaisPilasNaCarteira()
                .ForEach(i => MostraInformacoes(i));

            //Mostrando a informação dinamica
            MostraIdentificador($"Lista maiores de {18} anos");

            pessoaController
                .GetPessoasComIdadeMaiorA()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"Lista menores de {16} anos");

            pessoaController
                .GetPessoasComIdadeMenorQue()
                .ForEach(i => MostraInformacoes(i));

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para mostrar a informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">Identificador da listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("---- {0,20} ----", nomeAcao));
        }
        /// <summary>
        /// Metodo que mostra  no console formatado  nosso objeto 
        /// "Pessoa"
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //Nosso template que apresenta as informações bonitinhas
            //O format usa {0} essa expressão para colocar de acordo 
            //com a ordem informada dos parametros
            string template = "Id {0,-3} Nome {1,-10} Nascimento {2,10} Carteira {3,5}";
            //Recebemos as informações bonitinhas com o string format
            string textoFormatado = 
                //string.Format e usado para formatar as string 
                //deixando nosso texto padrão e apresentavel
                string.Format(
                    //Nosso primeiro parametro é o template que usamos
                    template,
                    //Após informar o template, temos os parametro 
                    //este metodo espera um array de parametros ou seja
                    //podemos passar muitos parametros nele
                    pessoa.Id,
                    pessoa.Nome,
                    //Formatamos a data de nascimento para apresentar a 
                    //informação reduzida
                    pessoa.DataNascimento.ToShortDateString(),
                    //Aqui apresentamos em valor monetario de acordo com 
                    //as configurações local da maquina
                    pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }


    }
}
