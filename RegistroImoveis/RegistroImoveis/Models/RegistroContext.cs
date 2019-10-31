using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class RegistroContext : DbContext
    {
        public virtual DbSet<Proprietario> Proprietarios { get; set; }

        public virtual DbSet<Imovel> Imovels { get; set; }
    }
}