using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jokeWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class initalsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JokeQuestion = table.Column<string>(type: "TEXT", nullable: true),
                    JokeAnswer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joke", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joke");
        }
    }
}
