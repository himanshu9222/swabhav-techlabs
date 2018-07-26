namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccount : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Users", new[] { "Account_Id" });
            AddColumn("dbo.Accounts", "User_Id", c => c.Guid());
            CreateIndex("dbo.Accounts", "User_Id");
            AddForeignKey("dbo.Accounts", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Users", "Account_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Account_Id", c => c.Guid());
            DropForeignKey("dbo.Accounts", "User_Id", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "User_Id" });
            DropColumn("dbo.Accounts", "User_Id");
            CreateIndex("dbo.Users", "Account_Id");
            AddForeignKey("dbo.Users", "Account_Id", "dbo.Accounts", "Id");
        }
    }
}
