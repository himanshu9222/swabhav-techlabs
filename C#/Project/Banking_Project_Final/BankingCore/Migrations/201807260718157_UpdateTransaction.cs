namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransaction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Type", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Type", c => c.Int(nullable: false));
        }
    }
}
