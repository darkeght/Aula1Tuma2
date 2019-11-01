namespace BancoDeDadosInnerJoinWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carros")]
    public partial class Carro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carro()
        {
            Vendas = new HashSet<Venda>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ano { get; set; }

        public int Marca { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        public virtual Marca Marca1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
