using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mission6Assignment.Migrations
{
    /// <inheritdoc />
    public partial class TakeEight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    formID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieCat = table.Column<string>(type: "TEXT", nullable: false),
                    movieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    movieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    movieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    movieRating = table.Column<string>(type: "TEXT", nullable: false),
                    isEdited = table.Column<bool>(type: "INTEGER", nullable: false),
                    lentTo = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.formID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
