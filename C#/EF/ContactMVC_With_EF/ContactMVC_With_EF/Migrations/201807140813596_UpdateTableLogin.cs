namespace ContactMVC_With_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
