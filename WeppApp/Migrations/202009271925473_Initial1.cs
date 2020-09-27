namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classifieds", "Title", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "Description", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "DateCreate", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "DateUpdate", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "IsActive", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "DateStart", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "DateEnd", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "IdCategory", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "Category_Id", c => c.Int());
            CreateIndex("dbo.Classifieds", "Category_Id");
            AddForeignKey("dbo.Classifieds", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classifieds", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Classifieds", new[] { "Category_Id" });
            DropColumn("dbo.Classifieds", "Category_Id");
            DropColumn("dbo.Classifieds", "IdCategory");
            DropColumn("dbo.Classifieds", "DateEnd");
            DropColumn("dbo.Classifieds", "DateStart");
            DropColumn("dbo.Classifieds", "IsActive");
            DropColumn("dbo.Classifieds", "Type");
            DropColumn("dbo.Classifieds", "Price");
            DropColumn("dbo.Classifieds", "DateUpdate");
            DropColumn("dbo.Classifieds", "DateCreate");
            DropColumn("dbo.Classifieds", "Description");
            DropColumn("dbo.Classifieds", "Title");
        }
    }
}
