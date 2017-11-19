namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteBirthYearFromCustomers : DbMigration
    {
        public override void Up()
        {
            DropColumn("Customers", "Column");
        }
        
        public override void Down()
        {
        }
    }
}
