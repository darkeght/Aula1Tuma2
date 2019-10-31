namespace MigrationApiWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVendas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Produto = c.String(),
                        Valor = c.Double(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendas");
        }
    }
}
