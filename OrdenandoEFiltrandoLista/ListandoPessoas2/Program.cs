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

            Console.ReadKey();
        }

        private static void MostraInformacoes(Pessoa pessoa)
        {
            string template = "Id {0,3} Nome {1,10}";

            string textoFormatado = string.Format(template,pessoa.Id,pessoa.Nome);

            Console.WriteLine(textoFormatado);
        }
    }
}
