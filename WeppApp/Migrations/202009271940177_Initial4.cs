namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Categories", new[] { "Account_Id" });
            AddColumn("dbo.Accounts", "FirtName", c => c.String());
            AddColumn("dbo.Accounts", "LastName", c => c.String());
            DropColumn("dbo.Categories", "Account_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Account_Id", c => c.Int());
            DropColumn("dbo.Accounts", "LastName");
            DropColumn("dbo.Accounts", "FirtName");
            CreateIndex("dbo.Categories", "Account_Id");
            AddForeignKey("dbo.Categories", "Account_Id", "dbo.Accounts", "Id");
        }
    }
}
