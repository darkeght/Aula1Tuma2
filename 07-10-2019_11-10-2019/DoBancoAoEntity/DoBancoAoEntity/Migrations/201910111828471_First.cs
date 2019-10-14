namespace DoBancoAoEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ano = c.DateTime(nullable: false, storeType: "date"),
                        Marca = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marca)
                .Index(t => t.Marca);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carro = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, storeType: "money"),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carros", t => t.Carro)
                .Index(t => t.Carro);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Carro", "dbo.Carros");
            DropForeignKey("dbo.Carros", "Marca", "dbo.Marcas");
            DropIndex("dbo.Vendas", new[] { "Carro" });
            DropIndex("dbo.Carros", new[] { "Marca" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Vendas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Carros");
        }
    }
}
