namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Artista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artista()
        {
            Cancoes = new HashSet<Canco>();
        }

        public int Id { get; set; }

        public int GeneroId { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public virtual Genero Genero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Canco> Cancoes { get; set; }
    }
}
