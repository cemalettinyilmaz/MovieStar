namespace MovieStarEFUygulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turIdnullableyaptık : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Films", "TurId", "dbo.Turs");
            DropIndex("dbo.Films", new[] { "TurId" });
            AlterColumn("dbo.Films", "TurId", c => c.Int());
            CreateIndex("dbo.Films", "TurId");
            AddForeignKey("dbo.Films", "TurId", "dbo.Turs", "TurID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "TurId", "dbo.Turs");
            DropIndex("dbo.Films", new[] { "TurId" });
            AlterColumn("dbo.Films", "TurId", c => c.Int(nullable: false));
            CreateIndex("dbo.Films", "TurId");
            AddForeignKey("dbo.Films", "TurId", "dbo.Turs", "TurID", cascadeDelete: true);
        }
    }
}
