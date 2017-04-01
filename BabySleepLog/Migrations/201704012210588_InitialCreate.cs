namespace BabySleepLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        SleepId = c.Int(nullable: false),
                        Duration = c.Double(nullable: false),
                        Level = c.Int(nullable: false),
                        Exclude = c.Boolean(nullable: false),
                        Notes = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.EntryId)
                .ForeignKey("dbo.Sleeps", t => t.SleepId, cascadeDelete: true)
                .Index(t => t.SleepId);
            
            CreateTable(
                "dbo.Sleeps",
                c => new
                    {
                        SleepId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SleepId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "SleepId", "dbo.Sleeps");
            DropIndex("dbo.Entries", new[] { "SleepId" });
            DropTable("dbo.Sleeps");
            DropTable("dbo.Entries");
        }
    }
}
