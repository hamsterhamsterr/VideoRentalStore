namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateDataToCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1980-1-1' WHERE id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
