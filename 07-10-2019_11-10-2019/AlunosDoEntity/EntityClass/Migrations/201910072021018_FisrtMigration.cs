namespace EntityClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FisrtMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alunoes", "Nome", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alunoes", "Nome", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
