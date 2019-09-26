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

        public List<Venda> GetVendas()
        {
            //retornamos nossa lista de vendas sem nenhum filtro neste momento
            return vendasContext.ListaVendasPublica;
        }
    }
}
