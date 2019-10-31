namespace MigrationApiWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationApiWeb.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MigrationApiWeb.Models.MigrationContext";
        }

        protected override void Seed(MigrationApiWeb.Models.MigrationContext context)
        {
            context.Usuarios.AddOrUpdate(x => x.Nome, new Models.Usuario()
            {
                Nome = "Felipe"
            });

            context.SaveChanges();

            var usuarioId = context
                .Usuarios
                .FirstOrDefault(x => x.Nome == "Felipe").Id;

            context.Vendas.AddOrUpdate(x => x.UsuarioId,new Models.Vendas() {
                Produto = "Cerveja",
                UsuarioId = usuarioId,
                Valor = 99
            });

            context.SaveChanges();

        }
    }
}
