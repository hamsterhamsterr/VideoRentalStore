namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removeallusersandroles : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM AspNetUserRoles");
            Sql("DELETE FROM AspNetRoles");
            Sql("DELETE FROM AspNetUsers");
        }
        
        public override void Down()
        {
        }
    }
}
