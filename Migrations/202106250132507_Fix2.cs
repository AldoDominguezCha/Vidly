namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenre_Id" });
            DropColumn("dbo.Movies", "MovieGenreId");
            RenameColumn(table: "dbo.Movies", name: "MovieGenre_Id", newName: "MovieGenreId");
            DropPrimaryKey("dbo.MovieGenres");
            AlterColumn("dbo.MovieGenres", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "MovieGenreId", c => c.Byte());
            AlterColumn("dbo.Movies", "MovieGenreId", c => c.Byte());
            AddPrimaryKey("dbo.MovieGenres", "Id");
            CreateIndex("dbo.Movies", "MovieGenreId");
            AddForeignKey("dbo.Movies", "MovieGenreId", "dbo.MovieGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenreId", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenreId" });
            DropPrimaryKey("dbo.MovieGenres");
            AlterColumn("dbo.Movies", "MovieGenreId", c => c.Int());
            AlterColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.MovieGenres", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MovieGenres", "Id");
            RenameColumn(table: "dbo.Movies", name: "MovieGenreId", newName: "MovieGenre_Id");
            AddColumn("dbo.Movies", "MovieGenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "MovieGenre_Id");
            AddForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres", "Id");
        }
    }
}
