using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 1, "Romantic Comedy", "Nora Ephron", false, null, null, "PG", 1998, "You've Got Mail" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 2, "Drama", "Luca Guadagnino", false, null, null, "R", 2017, "Call Me By Your Name" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 3, "Romantic Comedy", "Jon Turteltaub", false, null, null, "PG", 1995, "While You Were Sleeping" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
