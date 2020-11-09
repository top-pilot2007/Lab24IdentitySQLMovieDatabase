using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab24IdentitySQLMovieDatabase.Data.Migrations
{
    public partial class MovieCheckedOutMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Actors = table.Column<string>(nullable: true),
                    Directors = table.Column<string>(nullable: true),
                    Runtime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Actors", "Directors", "Genre", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Samuel L. Jackson", "Fuminori Kizaki", 1, 0.0, "Afro Samurai", 2007 },
                    { 24, "Edie Murphy", "Chocolate Blood", 5, 0.0, "Blacula", 1990 },
                    { 25, "Edie Murphy", "Place Shelter", 5, 0.0, "Vampire in Brooklyn", 1999 },
                    { 26, "Lamar Odom", "Ruined Life", 5, 0.0, "Candyman", 1991 },
                    { 27, "Ice Cube", "Great Memories", 5, 0.0, "Tales from the Hood", 1992 },
                    { 28, "Every One", "Yearround Tan", 5, 0.0, "Us", 1993 },
                    { 29, "Citizen Arest", "Future Problem", 5, 0.0, "Purge", 1994 },
                    { 30, "Samuel L. Jackson", "Satan Child", 5, 0.0, "Spawn", 1995 },
                    { 31, "Samuel L. Jackson", "Hot Property", 5, 0.0, "A Haunted House", 1996 },
                    { 23, "Keegan Michael", "Too Late", 5, 0.0, "Get Out", 2020 },
                    { 32, "Samuel L. Jackson", "Waynes Family", 5, 0.0, "Scary Movie", 1997 },
                    { 34, "National Geographic", "Beautiful Nature", 3, 0.0, "Planet Earth", 1999 },
                    { 35, "Fresh Boat", "Living Big", 6, 0.0, "Crazy Rich Asians", 1980 },
                    { 36, "Josh Ryan", "Love Birds", 6, 0.0, "The Notebook", 1981 },
                    { 37, "Keanau Reeves", "Coen Brothers", 7, 0.0, "Matrix", 1982 },
                    { 38, "Sigorni Weaver", "Michael Bay", 7, 0.0, "Aliens", 1983 },
                    { 39, "Atticus Latrice", "Magic Forsome", 7, 0.0, "Lovecraft Country", 1984 },
                    { 40, "Europeans Descent", "Stay Alive", 2, 0.0, "Eurotrip", 1985 },
                    { 41, "Kids Caffein", "Hungry Tired", 5, 0.0, "Hellraiser", 1986 },
                    { 33, "Edie Murphy", "Edie Murphy", 2, 0.0, "Coming To America", 1998 },
                    { 42, "Mike Meyer", "Octoberfest", 5, 0.0, "Friday The 13th", 1987 },
                    { 22, "Nicholas Cage", "Real Life", 4, 0.0, "Lord of War", 2019 },
                    { 20, "Don Cheadle", "Needed Change", 4, 0.0, "Hotel Rwanda", 2017 },
                    { 2, "Beyonce", "Walt Disney", 1, 0.0, "Lion King", 1994 },
                    { 3, "Angela Basset", "Walt Disney", 1, 0.0, "The Princess and the Frog", 2007 },
                    { 4, "Michael Jordan", "Warner Brothers", 1, 0.0, "Space Jam", 2001 },
                    { 5, "Chris Rock", "Dreamwork", 1, 0.0, "Osmosis Jones", 2002 },
                    { 6, "Will Smith", "Dreamwork", 1, 0.0, "Shark Tale", 2003 },
                    { 7, "John Goodman", "Paramount", 1, 0.0, "Madagascar", 2004 },
                    { 8, "Mike Meyer", "Dreamwork", 1, 0.0, "Shrek", 2005 },
                    { 9, "Samuel L. Jackson", "Fuminori Kizaki", 1, 0.0, "Afro Samurai Resurection", 2009 },
                    { 21, "Jamie Foxx", "Musical Genius", 4, 0.0, "Ray", 2018 },
                    { 10, "Lucy Lu", "Walt Disney", 1, 0.0, "Mulan", 2007 },
                    { 12, "Denzel Washington", "Spike Lee", 4, 0.0, "Malcolm X", 2009 },
                    { 13, "Janelle Monet", "Pharrell Williams", 4, 0.0, "Hidden Figures", 2010 },
                    { 14, "Martin Luther King", "Oprah Winfrey", 4, 0.0, "Selma", 2011 },
                    { 15, "Tom Hank", "Wendy Finerman", 4, 0.0, "Forest Gump", 2012 },
                    { 16, "Chadwick Boseman", "Thomas Tull", 4, 0.0, "42", 2013 },
                    { 17, "Morgan Freeman", "Matthew Broderick", 4, 0.0, "Glory", 2014 },
                    { 18, "Idris Alba", "Why Kids", 4, 0.0, "Beasts of No Nation", 2015 },
                    { 19, "Whoppi Goldberg", "Danny Glover", 4, 0.0, "The Color Purple", 2016 },
                    { 11, "Larry Cucumber", "Ameake Owens", 1, 0.0, "VeggieTales", 2008 },
                    { 43, "Michael Fox", "Doctor", 7, 0.0, "Back To The Future", 1988 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
