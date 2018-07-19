namespace Shoping_Cart_DTO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerUserId = c.String(nullable: false, maxLength: 128),
                        CustomerName = c.String(),
                        CustomerPassword = c.String(),
                    })
                .PrimaryKey(t => t.CustomerUserId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        CheckOutPrice = c.Double(nullable: false),
                        C_CustomerUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.C_CustomerUserId)
                .Index(t => t.C_CustomerUserId);
            
            CreateTable(
                "dbo.LineItems",
                c => new
                    {
                        LineItemId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        O_OrderId = c.Guid(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.LineItemId)
                .ForeignKey("dbo.Orders", t => t.O_OrderId)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.O_OrderId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineItems", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.LineItems", "O_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "C_CustomerUserId", "dbo.Customers");
            DropIndex("dbo.LineItems", new[] { "Product_ProductId" });
            DropIndex("dbo.LineItems", new[] { "O_OrderId" });
            DropIndex("dbo.Orders", new[] { "C_CustomerUserId" });
            DropTable("dbo.Products");
            DropTable("dbo.LineItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
