namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classifieds", "IdVat", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "VAT_Id", c => c.Int());
            AddColumn("dbo.VATs", "Vat", c => c.Single(nullable: false));
            AddColumn("dbo.VATs", "VAT_Id", c => c.Int());
            CreateIndex("dbo.Classifieds", "VAT_Id");
            CreateIndex("dbo.VATs", "VAT_Id");
            AddForeignKey("dbo.VATs", "VAT_Id", "dbo.VATs", "Id");
            AddForeignKey("dbo.Classifieds", "VAT_Id", "dbo.VATs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classifieds", "VAT_Id", "dbo.VATs");
            DropForeignKey("dbo.VATs", "VAT_Id", "dbo.VATs");
            DropIndex("dbo.VATs", new[] { "VAT_Id" });
            DropIndex("dbo.Classifieds", new[] { "VAT_Id" });
            DropColumn("dbo.VATs", "VAT_Id");
            DropColumn("dbo.VATs", "Vat");
            DropColumn("dbo.Classifieds", "VAT_Id");
            DropColumn("dbo.Classifieds", "IdVat");
        }
    }
}
