namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGenreFromMovies : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "Genre");
        }
        
        public override void Down()
        {
        }
    }
}
