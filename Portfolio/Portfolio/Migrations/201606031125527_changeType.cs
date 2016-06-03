namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Type", c => c.String());
        }
    }
}
