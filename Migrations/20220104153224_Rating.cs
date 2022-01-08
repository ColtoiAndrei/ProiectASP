using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectASP.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatingID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_LanguageID",
                table: "Movie",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_RatingID",
                table: "Movie",
                column: "RatingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Language_LanguageID",
                table: "Movie",
                column: "LanguageID",
                principalTable: "Language",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Rating_RatingID",
                table: "Movie",
                column: "RatingID",
                principalTable: "Rating",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Language_LanguageID",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Rating_RatingID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Movie_LanguageID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_RatingID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "LanguageID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "RatingID",
                table: "Movie");
        }
    }
}
