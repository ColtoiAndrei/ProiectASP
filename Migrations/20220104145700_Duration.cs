using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectASP.Migrations
{
    public partial class Duration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationID",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Duration",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duration", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DurationID",
                table: "Movie",
                column: "DurationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Duration_DurationID",
                table: "Movie",
                column: "DurationID",
                principalTable: "Duration",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Duration_DurationID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Duration");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DurationID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DurationID",
                table: "Movie");
        }
    }
}
