namespace DateNightCleve.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateNights",
                c => new
                    {
                        RecordNum = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.String(),
                        Address = c.String(),
                        PhoneNum = c.String(),
                        PhotoURL = c.String(),
                        Website = c.String(),
                        PricePerPerson = c.String(),
                    })
                .PrimaryKey(t => t.RecordNum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DateNights");
        }
    }
}
