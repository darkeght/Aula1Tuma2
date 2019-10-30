namespace ConsoleMiration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddControleUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "DataAlteracao");
            DropColumn("dbo.Usuarios", "DataCriacao");
            DropColumn("dbo.Usuarios", "UsuarioAlteracao");
            DropColumn("dbo.Usuarios", "UsuarioCriacao");
            DropColumn("dbo.Usuarios", "Ativo");
        }
    }
}
