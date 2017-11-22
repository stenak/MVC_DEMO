namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Gnrs (Name) VALUES ('Action')");
            Sql("INSERT INTO Gnrs (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Gnrs (Name) VALUES ('Family')");
            Sql("INSERT INTO Gnrs (Name) VALUES ('Romance')");
            Sql("INSERT INTO Gnrs (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
