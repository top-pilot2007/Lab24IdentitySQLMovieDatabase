using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab24IdentitySQLMovieDatabase.Data.Migrations
{
    public partial class relationship3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckedOutMovies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckedOutMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckedOutMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckedOutMovies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutMovies_MovieId",
                table: "CheckedOutMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckedOutMovies_UserId",
                table: "CheckedOutMovies",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckedOutMovies");
        }
    }
}
