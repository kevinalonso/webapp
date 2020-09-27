namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VATs", "VAT_Id", "dbo.VATs");
            DropIndex("dbo.VATs", new[] { "VAT_Id" });
            DropColumn("dbo.VATs", "VAT_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VATs", "VAT_Id", c => c.Int());
            CreateIndex("dbo.VATs", "VAT_Id");
            AddForeignKey("dbo.VATs", "VAT_Id", "dbo.VATs", "Id");
        }
    }
}
