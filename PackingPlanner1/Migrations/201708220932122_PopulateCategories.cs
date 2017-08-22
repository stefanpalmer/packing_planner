namespace PackingPlanner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Clothing')");
            Sql("INSERT INTO Categories (Name) VALUES ('Hygiene(Body)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Hygiene(Oral)')");
            Sql("INSERT INTO Categories (Name) VALUES ('Cosmetics')");
            Sql("INSERT INTO Categories (Name) VALUES ('Medicine')");
            Sql("INSERT INTO Categories (Name) VALUES ('Documents')");
            Sql("INSERT INTO Categories (Name) VALUES ('Technology')");
            Sql("INSERT INTO Categories (Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
