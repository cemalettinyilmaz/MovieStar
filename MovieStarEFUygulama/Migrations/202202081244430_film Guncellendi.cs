namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmGuncellendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Yil", c => c.Int(nullable: false));
            AddColumn("dbo.Films", "Poster", c => c.String());
            AddColumn("dbo.Films", "imdbID", c => c.String());
            DropColumn("dbo.Films", "Yıl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Yıl", c => c.Int(nullable: false));
            DropColumn("dbo.Films", "imdbID");
            DropColumn("dbo.Films", "Poster");
            DropColumn("dbo.Films", "Yil");
        }
    }
}
