namespace Expression_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTbale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Number = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
