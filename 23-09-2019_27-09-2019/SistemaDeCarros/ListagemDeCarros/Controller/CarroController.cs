using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContext = new SistemaCarrosContext();

        /// <summary>
        /// Metodo que retorna nossa lista de carros completa
        /// </summary>
        /// <returns>Retorna nossa lista de carros</returns>
        public List<Carro> GetCarros()
        {
            return sistemaCarrosContext.ListaDeCarros;
        }
    }
}
