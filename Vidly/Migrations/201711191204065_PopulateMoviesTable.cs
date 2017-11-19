namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('The Shawshank Redemption','Drama', 1994, 01/12/2016, 7)");
            Sql("INSERT into Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('The Godfather','Drama', 1972, 05/07/2015, 12  )");
            Sql("INSERT into Movies (Name, Genre, ReleaseDate, DateAdded, Stock) VALUES ('The Lord of the Rings: The Return of the King','Adventure', 2003, 07/09/2017, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
