namespace BankingCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDAtaType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Gender", c => c.String());
            AlterColumn("dbo.Users", "Verified", c => c.String());
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "AccountStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "AccountStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Verified", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Users", "Gender", c => c.Int(nullable: false));
        }
    }
}
