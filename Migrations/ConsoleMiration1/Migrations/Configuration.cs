namespace ConsoleMiration1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMiration1.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMiration1.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMiration1.Model.MigrationContext context)
        {

            context.Usuarios.AddOrUpdate(x => x.Nome,new Model.Usuario() {
                Nome = "Felipe",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com.br",
                Nivel = Model.Nivel.Visitante
            });

            context.SaveChanges();
        }
    }
}
