namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeQuantityType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Quantity", c => c.Byte(nullable: false));
        }
    }
}
