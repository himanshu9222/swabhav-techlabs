namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Account_AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Users", "Account_AccountId", "dbo.Accounts");
            RenameColumn(table: "dbo.Transactions", name: "Account_AccountId", newName: "Account_Id");
            RenameColumn(table: "dbo.Users", name: "Account_AccountId", newName: "Account_Id");
            RenameIndex(table: "dbo.Transactions", name: "IX_Account_AccountId", newName: "IX_Account_Id");
            RenameIndex(table: "dbo.Users", name: "IX_Account_AccountId", newName: "IX_Account_Id");
            DropPrimaryKey("dbo.Accounts");
            DropPrimaryKey("dbo.Transactions");
            AddColumn("dbo.Accounts", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Transactions", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Transactions", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "Date", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Accounts", "Id");
            AddPrimaryKey("dbo.Transactions", "Id");
            AddForeignKey("dbo.Transactions", "Account_Id", "dbo.Accounts", "Id");
            AddForeignKey("dbo.Users", "Account_Id", "dbo.Accounts", "Id");
            DropColumn("dbo.Accounts", "AccountId");
            DropColumn("dbo.Transactions", "TransactionId");
            DropColumn("dbo.Transactions", "TType");
            DropColumn("dbo.Transactions", "TDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "TDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "TType", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "TransactionId", c => c.Guid(nullable: false));
            AddColumn("dbo.Accounts", "AccountId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Users", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "Account_Id", "dbo.Accounts");
            DropPrimaryKey("dbo.Transactions");
            DropPrimaryKey("dbo.Accounts");
            DropColumn("dbo.Transactions", "Date");
            DropColumn("dbo.Transactions", "Type");
            DropColumn("dbo.Transactions", "Id");
            DropColumn("dbo.Accounts", "Id");
            AddPrimaryKey("dbo.Transactions", "TransactionId");
            AddPrimaryKey("dbo.Accounts", "AccountId");
            RenameIndex(table: "dbo.Users", name: "IX_Account_Id", newName: "IX_Account_AccountId");
            RenameIndex(table: "dbo.Transactions", name: "IX_Account_Id", newName: "IX_Account_AccountId");
            RenameColumn(table: "dbo.Users", name: "Account_Id", newName: "Account_AccountId");
            RenameColumn(table: "dbo.Transactions", name: "Account_Id", newName: "Account_AccountId");
            AddForeignKey("dbo.Users", "Account_AccountId", "dbo.Accounts", "AccountId");
            AddForeignKey("dbo.Transactions", "Account_AccountId", "dbo.Accounts", "AccountId");
        }
    }
}
