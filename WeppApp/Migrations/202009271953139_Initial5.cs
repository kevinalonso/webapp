namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetNumber = c.String(),
                        StreetName = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                        Country = c.String(),
                        IdAccount = c.Int(nullable: false),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            AddColumn("dbo.Accounts", "DateCreate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Accounts", "DateUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Accounts", "TotalSales", c => c.Single(nullable: false));
            AddColumn("dbo.Accounts", "Email", c => c.String());
            AddColumn("dbo.Accounts", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Addresses", new[] { "Account_Id" });
            DropColumn("dbo.Accounts", "Password");
            DropColumn("dbo.Accounts", "Email");
            DropColumn("dbo.Accounts", "TotalSales");
            DropColumn("dbo.Accounts", "DateUpdate");
            DropColumn("dbo.Accounts", "DateCreate");
            DropTable("dbo.Addresses");
        }
    }
}
