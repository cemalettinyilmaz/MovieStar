namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmID = c.Int(nullable: false, identity: true),
                        FilmAdi = c.String(nullable: false, maxLength: 200),
                        Yıl = c.Int(nullable: false),
                        IMDBPuani = c.Decimal(nullable: false, precision: 2, scale: 1),
                        TurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilmID)
                .ForeignKey("dbo.Turs", t => t.TurId, cascadeDelete: true)
                .Index(t => t.TurId);
            
            CreateTable(
                "dbo.Oyuncus",
                c => new
                    {
                        OyuncuID = c.Int(nullable: false, identity: true),
                        OyuncuAd = c.String(nullable: false, maxLength: 60),
                        OyuncuSoyAd = c.String(nullable: false, maxLength: 60),
                        IletisimId = c.Int(),
                    })
                .PrimaryKey(t => t.OyuncuID);
            
            CreateTable(
                "dbo.IletisimBilgis",
                c => new
                    {
                        OyuncuID = c.Int(nullable: false),
                        TelefonNo = c.String(nullable: false, maxLength: 13),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.OyuncuID)
                .ForeignKey("dbo.Oyuncus", t => t.OyuncuID)
                .Index(t => t.OyuncuID);
            
            CreateTable(
                "dbo.Turs",
                c => new
                    {
                        TurID = c.Int(nullable: false, identity: true),
                        TurAdi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.TurID);
            
            CreateTable(
                "dbo.OyuncuFilms",
                c => new
                    {
                        Oyuncu_OyuncuID = c.Int(nullable: false),
                        Film_FilmID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Oyuncu_OyuncuID, t.Film_FilmID })
                .ForeignKey("dbo.Oyuncus", t => t.Oyuncu_OyuncuID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_FilmID, cascadeDelete: true)
                .Index(t => t.Oyuncu_OyuncuID)
                .Index(t => t.Film_FilmID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "TurId", "dbo.Turs");
            DropForeignKey("dbo.IletisimBilgis", "OyuncuID", "dbo.Oyuncus");
            DropForeignKey("dbo.OyuncuFilms", "Film_FilmID", "dbo.Films");
            DropForeignKey("dbo.OyuncuFilms", "Oyuncu_OyuncuID", "dbo.Oyuncus");
            DropIndex("dbo.OyuncuFilms", new[] { "Film_FilmID" });
            DropIndex("dbo.OyuncuFilms", new[] { "Oyuncu_OyuncuID" });
            DropIndex("dbo.IletisimBilgis", new[] { "OyuncuID" });
            DropIndex("dbo.Films", new[] { "TurId" });
            DropTable("dbo.OyuncuFilms");
            DropTable("dbo.Turs");
            DropTable("dbo.IletisimBilgis");
            DropTable("dbo.Oyuncus");
            DropTable("dbo.Films");
        }
    }
}
