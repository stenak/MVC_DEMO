namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixing : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id1", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id1" });
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "Genre_Id");
            DropColumn("dbo.Movies", "Genre_Id1");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Genre_Id1", c => c.Int());
            AddColumn("dbo.Movies", "Genre_Id", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id1");
            AddForeignKey("dbo.Movies", "Genre_Id1", "dbo.Genres", "Id");
        }
    }
}
