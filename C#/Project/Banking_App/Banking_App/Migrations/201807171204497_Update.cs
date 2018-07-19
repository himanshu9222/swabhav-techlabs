namespace Banking_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "Passwword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Passwword", c => c.String());
            DropColumn("dbo.Users", "Password");
        }
    }
}
