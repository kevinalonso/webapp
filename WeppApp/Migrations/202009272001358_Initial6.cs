namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classifieds", "DateSale", c => c.DateTime(nullable: false));
            AddColumn("dbo.Classifieds", "Turnover_Id", c => c.Int());
            CreateIndex("dbo.Classifieds", "Turnover_Id");
            AddForeignKey("dbo.Classifieds", "Turnover_Id", "dbo.Turnovers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classifieds", "Turnover_Id", "dbo.Turnovers");
            DropIndex("dbo.Classifieds", new[] { "Turnover_Id" });
            DropColumn("dbo.Classifieds", "Turnover_Id");
            DropColumn("dbo.Classifieds", "DateSale");
        }
    }
}
