namespace ExemploWebForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1_inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 10000, storeType: "nvarchar"),
                        ImagePath = c.String(unicode: false),
                        UnitPrice = c.Double(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
