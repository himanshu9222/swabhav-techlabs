namespace SimpleEFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescriptionFieldAdd_Students : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Description");
        }
    }
}
