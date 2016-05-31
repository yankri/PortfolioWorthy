namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        GithubLink = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Screenshots",
                c => new
                    {
                        SSID = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SSID)
                .ForeignKey("dbo.Projects", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Screenshots", "ID", "dbo.Projects");
            DropIndex("dbo.Screenshots", new[] { "ID" });
            DropTable("dbo.Screenshots");
            DropTable("dbo.Projects");
        }
    }
}
