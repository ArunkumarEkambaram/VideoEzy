namespace VideoEzy_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercustomertable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "MobileNo", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String());
            AlterColumn("dbo.Customers", "MobileNo", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
