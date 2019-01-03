namespace VideoEzy_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMembershipTypeAndAlterCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Short(nullable: false),
                        DiscountRate = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MobileNo", c => c.String());
            AddColumn("dbo.Customers", "EmailAddress", c => c.String());
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Short(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "EmailAddress");
            DropColumn("dbo.Customers", "MobileNo");
            DropTable("dbo.MembershipTypes");
        }
    }
}
