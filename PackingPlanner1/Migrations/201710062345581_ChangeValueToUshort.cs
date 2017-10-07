namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeValueToUshort : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Quantity", c => c.Single(nullable: false));
        }
    }
}
