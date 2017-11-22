namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGnrToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GnrId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "Gnr_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Gnr_Id");
            AddForeignKey("dbo.Movies", "Gnr_Id", "dbo.Gnrs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Gnr_Id", "dbo.Gnrs");
            DropIndex("dbo.Movies", new[] { "Gnr_Id" });
            DropColumn("dbo.Movies", "Gnr_Id");
            DropColumn("dbo.Movies", "GnrId");
        }
    }
}
