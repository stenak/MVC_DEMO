namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleaningShit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Gnr_Id", "dbo.Gnrs");
            DropIndex("dbo.Movies", new[] { "Gnr_Id" });
            DropColumn("dbo.Movies", "GnrId");
            DropColumn("dbo.Movies", "Gnr_Id");
            DropTable("dbo.Gnrs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Gnrs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Gnr_Id", c => c.Int());
            AddColumn("dbo.Movies", "GnrId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Gnr_Id");
            AddForeignKey("dbo.Movies", "Gnr_Id", "dbo.Gnrs", "Id");
        }
    }
}
