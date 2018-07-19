namespace Banking_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Guid(nullable: false),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Guid(nullable: false),
                        Amount = c.Double(nullable: false),
                        TType = c.String(),
                        TDate = c.DateTime(nullable: false),
                        Account_AccountId = c.Guid(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Accounts", t => t.Account_AccountId)
                .Index(t => t.Account_AccountId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        Passwword = c.String(),
                        Role = c.String(),
                        AccountStatus = c.String(),
                        Account_AccountId = c.Guid(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Accounts", t => t.Account_AccountId)
                .Index(t => t.Account_AccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Account_AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "Account_AccountId", "dbo.Accounts");
            DropIndex("dbo.Users", new[] { "Account_AccountId" });
            DropIndex("dbo.Transactions", new[] { "Account_AccountId" });
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Accounts");
        }
    }
}
