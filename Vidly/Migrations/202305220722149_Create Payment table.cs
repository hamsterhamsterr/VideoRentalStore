namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePaymenttable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Discount = c.Double(),
                        RentalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Rentals", t => t.RentalId, cascadeDelete: true)
                .Index(t => t.RentalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "RentalId", "dbo.Rentals");
            DropIndex("dbo.Payments", new[] { "RentalId" });
            DropTable("dbo.Payments");
        }
    }
}
