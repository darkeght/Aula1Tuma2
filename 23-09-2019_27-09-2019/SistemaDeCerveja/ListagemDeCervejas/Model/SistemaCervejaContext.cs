using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int IdContador = 1;
        public List<Cerveja> ListaDeCerveja { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = IdContador++,
                Nome = "Skol",
                Litros = 0.600,
                Alcool = 4.7,
                Valor = 4.5
            });

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = IdContador++,
                Nome = "Bramah",
                Litros = 1.0,
                Alcool = 4.8,
                Valor = 6.19
            });

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = IdContador++,
                Nome = "Corona",
                Litros = 0.355,
                Alcool = 4.6,
                Valor = 4.99
            });

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = IdContador++,
                Nome = "Original",
                Litros = 0.600,
                Alcool = 5.0,
                Valor = 5.50
            });

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = IdContador++,
                Nome = "Subzero Tang Cevada",
                Litros = 0.350,
                Alcool = 4.6,
                Valor = 2.19
            });
        }

    }
}
