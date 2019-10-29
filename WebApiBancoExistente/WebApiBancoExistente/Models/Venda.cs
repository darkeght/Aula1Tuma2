namespace WebApiBancoExistente.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venda
    {
        public int Id { get; set; }

        public int Carro { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        public virtual Carro Carro1 { get; set; }
    }
}
