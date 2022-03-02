namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class türadigerekliliğnikaldırdım : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Turs", "TurAdi", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turs", "TurAdi", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
