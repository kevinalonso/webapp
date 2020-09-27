namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            AddColumn("dbo.Categories", "Account_Id", c => c.Int());
            AddColumn("dbo.Classifieds", "IdAccount", c => c.Int(nullable: false));
            AddColumn("dbo.Classifieds", "Account_Id", c => c.Int());
            CreateIndex("dbo.Categories", "Account_Id");
            CreateIndex("dbo.Classifieds", "Account_Id");
            AddForeignKey("dbo.Classifieds", "Account_Id", "dbo.Accounts", "Id");
            AddForeignKey("dbo.Categories", "Account_Id", "dbo.Accounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Classifieds", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Classifieds", new[] { "Account_Id" });
            DropIndex("dbo.Categories", new[] { "Account_Id" });
            DropColumn("dbo.Classifieds", "Account_Id");
            DropColumn("dbo.Classifieds", "IdAccount");
            DropColumn("dbo.Categories", "Account_Id");
            DropColumn("dbo.Categories", "Name");
        }
    }
}
