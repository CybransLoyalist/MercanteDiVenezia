namespace MercanteDiVenezia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingStreetToCustomerMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Street", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Street");
        }
    }
}
