namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcolumnIsActiveRentaltoRentalstable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "IsActiveRental", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "IsActiveRental");
        }
    }
}
