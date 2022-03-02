namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OyuncuGuncellendi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Oyuncus", "OyuncuAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oyuncus", "OyuncuAd", c => c.String(nullable: false, maxLength: 60));
        }
    }
}
