namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateZanr : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Zanrs (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Zanrs (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Zanrs (Id, Name) VALUES (3, 'Drama')");
            Sql("INSERT INTO Zanrs (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Zanrs (Id, Name) VALUES (5, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
