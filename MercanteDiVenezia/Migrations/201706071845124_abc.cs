namespace MercanteDiVenezia.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
           // AddColumn("dbo.Customers", "HomeNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
           // DropColumn("dbo.Customers", "HomeNumber");
        }
    }
}
