namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "CategoryId", c => c.Byte(nullable: false));
            AddColumn("dbo.Items", "Category_Id", c => c.Int());
            CreateIndex("dbo.Items", "Category_Id");
            AddForeignKey("dbo.Items", "Category_Id", "dbo.Categories", "Id");
            DropColumn("dbo.Items", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Category", c => c.String());
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "Category_Id" });
            DropColumn("dbo.Items", "Category_Id");
            DropColumn("dbo.Items", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
