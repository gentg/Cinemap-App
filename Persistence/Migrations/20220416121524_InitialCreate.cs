using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: true),
                    MovieQuality = table.Column<string>(type: "TEXT", nullable: true),
                    MovieReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MovieDuration = table.Column<string>(type: "TEXT", nullable: true),
                    MovieUserVote = table.Column<int>(type: "INTEGER", nullable: false),
                    MoviePhoto = table.Column<string>(type: "TEXT", nullable: true),
                    MovieCover = table.Column<string>(type: "TEXT", nullable: true),
                    MovieTrailer = table.Column<string>(type: "TEXT", nullable: true),
                    MovieDescription = table.Column<string>(type: "TEXT", nullable: true),
                    MovieGenre = table.Column<string>(type: "TEXT", nullable: true),
                    MovieIMDB = table.Column<double>(type: "REAL", nullable: false),
                    isTvSHow = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
