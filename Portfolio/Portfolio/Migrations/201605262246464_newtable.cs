namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LangID = c.Int(nullable: false, identity: true),
                        ID = c.Int(nullable: false),
                        LanguageUsed = c.String(),
                    })
                .PrimaryKey(t => t.LangID)
                .ForeignKey("dbo.Projects", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            DropColumn("dbo.Projects", "Languages");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "Languages", c => c.String());
            DropForeignKey("dbo.Languages", "ID", "dbo.Projects");
            DropIndex("dbo.Languages", new[] { "ID" });
            DropTable("dbo.Languages");
        }
    }
}
