namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakePhoneNumbercolumnnotnullandmaxlength50 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE AspNetUsers SET PhoneNumber = '' WHERE PhoneNumber IS NULL");
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            Sql("UPDATE AspNetUsers SET PhoneNumber = NULL WHERE PhoneNumber = ''");
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
        }
    }
}
