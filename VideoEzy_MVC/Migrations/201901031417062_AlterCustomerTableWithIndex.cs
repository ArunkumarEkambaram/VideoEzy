namespace VideoEzy_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCustomerTableWithIndex : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Customers", "MobileNo", unique: true, name: "IX_UniqueMobileNo");
            CreateIndex("dbo.Customers", "EmailAddress", unique: true, name: "IX_UniqueEmailId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", "IX_UniqueEmailId");
            DropIndex("dbo.Customers", "IX_UniqueMobileNo");
        }
    }
}
