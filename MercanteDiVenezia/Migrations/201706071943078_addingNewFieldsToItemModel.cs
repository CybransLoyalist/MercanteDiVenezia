namespace MercanteDiVenezia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingNewFieldsToItemModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Quantity");
            DropColumn("dbo.Items", "Value");
        }
    }
}
