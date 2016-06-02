namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class techdesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "TechDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "TechDescription");
        }
    }
}
