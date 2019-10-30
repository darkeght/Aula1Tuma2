using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsoleMiration1.Model
{
    public class MigrationContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}