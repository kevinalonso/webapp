namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classifieds", "Title", c => c.String());
            AlterColumn("dbo.Classifieds", "Description", c => c.String());
            AlterColumn("dbo.Classifieds", "DateCreate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classifieds", "DateUpdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classifieds", "Price", c => c.Single(nullable: false));
            AlterColumn("dbo.Classifieds", "Type", c => c.String());
            AlterColumn("dbo.Classifieds", "IsActive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Classifieds", "DateStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Classifieds", "DateEnd", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classifieds", "DateEnd", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "DateStart", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "IsActive", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "DateUpdate", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "DateCreate", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "Description", c => c.Int(nullable: false));
            AlterColumn("dbo.Classifieds", "Title", c => c.Int(nullable: false));
        }
    }
}
