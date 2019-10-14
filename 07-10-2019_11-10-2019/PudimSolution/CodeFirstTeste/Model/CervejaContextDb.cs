namespace CodeFirstTeste.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Configuration;

    public partial class CervejaContextDb : DbContext
    {
        public CervejaContextDb(string conexao)
            : base(conexao) // Aqui alteramos nosso contrutor de "DbContext"
        {//para receber um valor pelo construtor "CervejaContextDb"
        

        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Cerveja> Cervejas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
