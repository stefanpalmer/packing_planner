namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeValueToShort : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Quantity", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Quantity");
        }
    }
}
