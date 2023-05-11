namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailabilitycolumntotheMoviestable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Availability", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Availability");
        }
    }
}
