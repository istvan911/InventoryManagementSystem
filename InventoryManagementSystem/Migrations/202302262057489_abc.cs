namespace InventoryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        CustomerEmail = c.String(nullable: false),
                        CustomerPhone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            AddColumn("dbo.Products", "CategoryName", c => c.String(nullable: false));
            DropColumn("dbo.Products", "ProductCategory");
            DropTable("dbo.Costumers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Costumers",
                c => new
                    {
                        CostumerID = c.Int(nullable: false, identity: true),
                        CostumerName = c.String(nullable: false),
                        CostumerEmail = c.String(nullable: false),
                        CostumerPhone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CostumerID);
            
            AddColumn("dbo.Products", "ProductCategory", c => c.String(nullable: false));
            DropColumn("dbo.Products", "CategoryName");
            DropTable("dbo.Customers");
        }
    }
}
