using System;
using System.Collections.Generic;

namespace WebApiComBancoDeDados.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            Carros = new HashSet<Carros>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public bool? Ativo { get; set; }
        public int UsuInc { get; set; }
        public int UsuAlt { get; set; }
        public DateTime DatInc { get; set; }
        public DateTime DatAlt { get; set; }

        public virtual ICollection<Carros> Carros { get; set; }
    }
}
