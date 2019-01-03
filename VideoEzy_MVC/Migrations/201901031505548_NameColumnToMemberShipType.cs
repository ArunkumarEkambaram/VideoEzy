namespace VideoEzy_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameColumnToMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Description");
        }
    }
}
