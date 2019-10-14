namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Canco
    {
        public int Id { get; set; }

        public int ArtistaId { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public virtual Artista Artista { get; set; }
    }
}
