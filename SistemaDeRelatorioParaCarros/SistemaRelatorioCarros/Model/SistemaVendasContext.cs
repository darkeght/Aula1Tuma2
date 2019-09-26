using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class SistemaVendasContext
    {
        /// <summary>
        /// Nossa massa de dados interna
        /// </summary>
        private List<Venda> ListaDeVendas { get; set; }

        /// <summary>
        /// Contrutor que prepara nossa massa de dados
        /// </summary>
        public SistemaVendasContext()
        {
            //Criamos nossa lista de vendas em memoria
            //caso contrario ela fica null
            ListaDeVendas = new List<Venda>();

            //Enfim meu primeiro registro
            ListaDeVendas.Add(new Venda() {Id = 1,Carro = "Risus Company",Valor = 7200,Quantidade = 18,Data = DateTime.Parse("29/01/2019")});
            ListaDeVendas.Add(new Venda() {Id = 2, Carro = "Risus Associates", Valor = 9961, Quantidade = 4, Data = DateTime.Parse("10/02/2019") });
            ListaDeVendas.Add(new Venda() {Id = 3, Carro = "Et Libero Proin Foundation", Valor = 8710, Quantidade = 17, Data = DateTime.Parse("24/01/2019") });
        }
        /// <summary>
        /// Propriedade que contem as vendas realizadas sem nenhum tipo de filtro
        /// </summary>
        public List<Venda> ListaVendasPublica { get { return ListaDeVendas; } }
    }
}
