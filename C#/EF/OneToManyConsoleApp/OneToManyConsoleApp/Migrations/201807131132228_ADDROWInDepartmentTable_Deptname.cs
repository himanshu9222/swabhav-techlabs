namespace OneToManyConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDROWInDepartmentTable_Deptname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Dept_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Dept_Name");
        }
    }
}
