using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{

    public class VendasController
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext();
        /// <summary>
        /// Metodo que retorna a lista de vendas, caso não informar o 
        /// valor ele retorna a lista sem filtro
        /// </summary>
        /// <param name="mes">Mes para realizar o filtro</param>
        /// <returns>Lista filtrada ou não dependendo do parametro informado</returns>
        public List<Venda> GetVendas(int mes = 0)
        {
            //retornamos nossa lista de vendas sem nenhum filtro neste momento
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica
                    .FindAll(x => x.Data.Month == mes);
        }
    }
}
