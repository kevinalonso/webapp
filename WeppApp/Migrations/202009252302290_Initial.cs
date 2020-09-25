namespace WeppApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tests", "Label", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tests", "Label", c => c.Single(nullable: false));
        }
    }
}
