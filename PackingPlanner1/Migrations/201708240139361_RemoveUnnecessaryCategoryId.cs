namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnnecessaryCategoryId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "CategoryId", c => c.Byte(nullable: false));
        }
    }
}
