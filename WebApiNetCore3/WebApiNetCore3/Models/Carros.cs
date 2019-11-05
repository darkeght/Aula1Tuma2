using System;
using System.Collections.Generic;

namespace WebApiNetCore3.Models
{
    public partial class Carros
    {
        public Carros()
        {
            Vendas = new HashSet<Vendas>();
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Marca { get; set; }
        public bool? Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DatInc { get; set; }
        public DateTime DatAlt { get; set; }

        public virtual Marcas MarcaNavigation { get; set; }
        public virtual ICollection<Vendas> Vendas { get; set; }
    }
}
