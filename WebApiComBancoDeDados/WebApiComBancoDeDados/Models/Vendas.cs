using System;
using System.Collections.Generic;

namespace WebApiComBancoDeDados.Models
{
    public partial class Vendas
    {
        public int Id { get; set; }
        public int Carro { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool? Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DatInc { get; set; }
        public DateTime DatAlt { get; set; }

        public virtual Carros CarroNavigation { get; set; }
    }
}
