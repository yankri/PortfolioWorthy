namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlanguages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Languages", c => c.String());
            AddColumn("dbo.Projects", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Type");
            DropColumn("dbo.Projects", "Languages");
        }
    }
}
