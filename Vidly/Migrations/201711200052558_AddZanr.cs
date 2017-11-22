namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddZanr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zanrs",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Films", "ZanrId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Films", "ZanrId");
            AddForeignKey("dbo.Films", "ZanrId", "dbo.Zanrs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "ZanrId", "dbo.Zanrs");
            DropIndex("dbo.Films", new[] { "ZanrId" });
            DropColumn("dbo.Films", "ZanrId");
            DropTable("dbo.Zanrs");
        }
    }
}
