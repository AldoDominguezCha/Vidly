namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieAdditionalProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MovieGenreId = c.Byte(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        AdditionDate = c.DateTime(nullable: false),
                        Stock = c.Int(nullable: false),
                        MovieGenre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieGenres", t => t.MovieGenre_Id)
                .Index(t => t.MovieGenre_Id);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenre_Id" });
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Movies");
        }
    }
}
