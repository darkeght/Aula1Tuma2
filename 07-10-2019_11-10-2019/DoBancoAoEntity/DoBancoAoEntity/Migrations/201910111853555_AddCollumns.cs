namespace DoBancoAoEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCollumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carros", "Cor", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carros", "Cor");
        }
    }
}
