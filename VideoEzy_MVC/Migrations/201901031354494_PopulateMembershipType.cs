namespace VideoEzy_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert MembershipTypes(SignUpFee,DurationInMonths,DiscountRate) values (50,0,0)");
            Sql("Insert MembershipTypes(SignUpFee,DurationInMonths,DiscountRate) values (200,1,5)");
            Sql("Insert MembershipTypes(SignUpFee,DurationInMonths,DiscountRate) values (600,3,10)");
            Sql("Insert MembershipTypes(SignUpFee,DurationInMonths,DiscountRate) values (1200,6,15)");
            Sql("Insert MembershipTypes(SignUpFee,DurationInMonths,DiscountRate) values (2400,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
