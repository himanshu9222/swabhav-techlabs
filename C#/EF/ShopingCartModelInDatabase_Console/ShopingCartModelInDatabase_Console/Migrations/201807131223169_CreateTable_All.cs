namespace ShopingCartModelInDatabase_Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_All : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        Orderdate = c.DateTime(nullable: false),
                        CheckoutPrice = c.Double(nullable: false),
                        C_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.C_CustomerId)
                .Index(t => t.C_CustomerId);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        LineItemId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        O_OrderId = c.Guid(),
                        P_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.LineItemId)
                .ForeignKey("dbo.Orders", t => t.O_OrderId)
                .ForeignKey("dbo.Products", t => t.P_ProductId)
                .Index(t => t.O_OrderId)
                .Index(t => t.P_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineItems", "P_ProductId", "dbo.Products");
            DropForeignKey("dbo.LineItems", "O_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "C_CustomerId", "dbo.Customers");
            DropIndex("dbo.LineItems", new[] { "P_ProductId" });
            DropIndex("dbo.LineItems", new[] { "O_OrderId" });
            DropIndex("dbo.Orders", new[] { "C_CustomerId" });
            DropTable("dbo.Products");
            DropTable("dbo.LineItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
