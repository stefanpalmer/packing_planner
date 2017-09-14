namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Quantity", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
        }
    }
}
