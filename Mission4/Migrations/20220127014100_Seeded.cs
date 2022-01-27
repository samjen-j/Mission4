using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addedMovies",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addedMovies", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "addedMovies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Joss Whedon", false, "", "", "PG-13", "Avengers", (ushort)2012 });

            migrationBuilder.InsertData(
                table: "addedMovies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Christopher Nolan", false, "", "", "PG-13", "The Dark Knight", (ushort)2008 });

            migrationBuilder.InsertData(
                table: "addedMovies",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Steven Spielberg", false, "", "", "PG", "Indiana Jones and the Raiders of the Lost Ark", (ushort)1981 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addedMovies");
        }
    }
}
