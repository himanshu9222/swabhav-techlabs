namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "AccountType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "AccountType", c => c.Int(nullable: false));
        }
    }
}
