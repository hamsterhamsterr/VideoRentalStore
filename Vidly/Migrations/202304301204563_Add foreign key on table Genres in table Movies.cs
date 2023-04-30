namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddforeignkeyontableGenresintableMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropColumn("dbo.Movies", "Genre_Id");
        }
    }
}
