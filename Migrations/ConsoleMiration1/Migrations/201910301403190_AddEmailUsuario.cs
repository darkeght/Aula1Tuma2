namespace ConsoleMiration1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Email");
        }
    }
}
