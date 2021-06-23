namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres(GenreName) VALUES('Action')");
            Sql("INSERT INTO MovieGenres(GenreName) VALUES('Comedy')");
            Sql("INSERT INTO MovieGenres(GenreName) VALUES('Romance')");
            Sql("INSERT INTO MovieGenres(GenreName) VALUES('Fantasy')");
            Sql("INSERT INTO MovieGenres(GenreName) VALUES('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
