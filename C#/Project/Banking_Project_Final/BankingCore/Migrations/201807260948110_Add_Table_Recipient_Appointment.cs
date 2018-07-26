namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Table_Recipient_Appointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Reason = c.String(),
                        Status = c.String(),
                        Date = c.DateTime(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Recipients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Balance = c.Double(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipients", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Appointments", "User_Id", "dbo.Users");
            DropIndex("dbo.Recipients", new[] { "User_Id" });
            DropIndex("dbo.Appointments", new[] { "User_Id" });
            DropTable("dbo.Recipients");
            DropTable("dbo.Appointments");
        }
    }
}
