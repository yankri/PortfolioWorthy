namespace DateNightCleve.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DateNights", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DateNights", "Category");
        }
    }
}
