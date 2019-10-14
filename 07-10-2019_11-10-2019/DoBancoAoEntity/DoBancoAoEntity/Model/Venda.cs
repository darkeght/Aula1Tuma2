namespace DoBancoAoEntity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venda : ControleUsuario
    {
        public int Id { get; set; }

        public int Carro { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public virtual Carro Carro1 { get; set; }
    }
}
