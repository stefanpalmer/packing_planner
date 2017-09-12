namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameRequiredAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}
