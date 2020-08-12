namespace ExemploWebForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2_add_category : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            AddColumn("dbo.Products", "CategoryID", c => c.Int());
            CreateIndex("dbo.Products", "CategoryID");
            AddForeignKey("dbo.Products", "CategoryID", "dbo.Categories", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropColumn("dbo.Products", "CategoryID");
            DropTable("dbo.Categories");
        }
    }
}
