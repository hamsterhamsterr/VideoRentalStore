namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovecolumnIsActiveRentalfromRentalstable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rentals", "IsActiveRental");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "IsActiveRental", c => c.Boolean(nullable: false));
        }
    }
}
