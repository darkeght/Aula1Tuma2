using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();
        /// <summary>
        /// Metodo que retorna nossa lista completa de cervejas
        /// </summary>
        /// <returns>Retorna a lista o.o</returns>
        public List<Cerveja> GetCervejas()
        {
            return sistemaCervejaContext.ListaDeCerveja;
        }
        /// <summary>
        /// Metodo que adiciona em nossa geladeira mais cervejas
        /// </summary>
        /// <param name="cerveja">Aqui pegamos a cerveja para colocar na geladeira</param>
        public void AdicionarCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContador++;
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);
        }
        /// <summary>
        /// Metodo que retorna o valor total em nossa lista de cerveja
        /// </summary>
        /// <returns>Retornamos o valor total</returns>
        public double RetornaValorTotalCervejas()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
        }
        /// <summary>
        /// Metodo que retorna o valor total de litros de cerveja que temos dentro de nossa geladeira
        /// </summary>
        /// <returns>Retornamos os litros em formato double</returns>
        public double RetornaValorTotalListrosCerveja()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Litros);
        }

    }
}
