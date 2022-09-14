namespace DZ_CodeFirstMapping_ChessChapmionships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryLevel = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false, maxLength: 100),
                        Birthday = c.DateTime(nullable: false, storeType: "date"),
                        Country = c.String(nullable: false, maxLength: 100),
                        LevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Levels", t => t.LevelId, cascadeDelete: true)
                .Index(t => t.LevelId);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        TournamentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Tournamets", t => t.TournamentId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.TournamentId);
            
            CreateTable(
                "dbo.Tournamets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Venue = c.String(nullable: false, maxLength: 100),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "TournamentId", "dbo.Tournamets");
            DropForeignKey("dbo.Results", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Members", "LevelId", "dbo.Levels");
            DropIndex("dbo.Results", new[] { "TournamentId" });
            DropIndex("dbo.Results", new[] { "MemberId" });
            DropIndex("dbo.Members", new[] { "LevelId" });
            DropTable("dbo.Tournamets");
            DropTable("dbo.Results");
            DropTable("dbo.Members");
            DropTable("dbo.Levels");
        }
    }
}
