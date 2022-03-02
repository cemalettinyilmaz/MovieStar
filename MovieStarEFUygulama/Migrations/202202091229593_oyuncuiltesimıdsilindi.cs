namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oyuncuiltesimıdsilindi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oyuncus", "OyuncuAdSoyad", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Oyuncus", "OyuncuSoyAd");
            DropColumn("dbo.Oyuncus", "IletisimId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oyuncus", "IletisimId", c => c.Int());
            AddColumn("dbo.Oyuncus", "OyuncuSoyAd", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Oyuncus", "OyuncuAdSoyad");
        }
    }
}
