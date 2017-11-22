namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Name", c => c.String());
        }
    }
}
