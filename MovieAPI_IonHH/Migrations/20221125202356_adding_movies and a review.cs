using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieAPIIonHH.Migrations
{
    /// <inheritdoc />
    public partial class addingmoviesandareview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MoviesMovieId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MoviesMovieId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MoviesMovieId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "IsDeleted", "Overview", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 2, false, "", 103, "Black Adam", "2022" },
                    { 3, false, "", 104, "R.I.P.D. 2: Rise of the Damned", "2022" },
                    { 4, false, "", 105, "Black Panther: Wakanda Forever", "2022" },
                    { 5, false, "", 102, "Disenchanted", "2022" },
                    { 6, false, "", 102, "Smile", "2022" },
                    { 7, false, "", 102, "Terrifier 2", "2022" },
                    { 8, false, "", 102, "Sniper: The White Raven", "2022" },
                    { 9, false, "", 102, "Paradise City", "2022" },
                    { 10, false, "", 102, "Hex", "2022" },
                    { 11, false, "", 102, "Medieval", "2022" },
                    { 12, false, "", 102, "Jeepers Creepers: Reborn", "2022" },
                    { 13, false, "", 102, "The Lair", "2022" },
                    { 14, false, "", 102, "Tad the Lost Explorer and the Emerald Tablet", "2022" },
                    { 15, false, "", 102, "Emily the Criminal", "2022" },
                    { 16, false, "", 102, "Lost Bullet 2", "2022" },
                    { 17, false, "", 102, "Enola Holmes 2", "2022" },
                    { 18, false, "", 102, "The Menu", "2022" },
                    { 19, false, "", 102, "On the Line", "2022" },
                    { 20, false, "", 102, "MexZombies", "2022" },
                    { 21, false, "", 102, "Margaux", "2022" },
                    { 22, false, "", 102, "All Quiet on the Western Front", "2022" },
                    { 23, false, "", 102, "Beast", "2022" },
                    { 24, false, "", 102, "Corrective Measures", "2022" },
                    { 25, false, "", 102, "Avatar: The Way of Water\n", "2022" },
                    { 26, false, "", 102, "Overdose", "2022" },
                    { 27, false, "", 102, "The Soccer Football Movie", "2022" },
                    { 28, false, "", 102, "The Friendship Game", "2022" },
                    { 29, false, "", 102, "Cuando Sea Joven", "2022" },
                    { 30, false, "", 102, "Tom and Jerry Snowman's Land", "2022" },
                    { 31, false, "", 102, "Blade of the 47 Ronin", "2022" },
                    { 32, false, "", 102, "Avatar", "2022" },
                    { 33, false, "", 102, "Thor: Love and Thunder", "2022" },
                    { 34, false, "", 102, "Spider-Man: No Way Home", "2022" },
                    { 35, false, "", 102, "The School for Good and Evil", "2022" },
                    { 36, false, "", 103, "Jurassic World Dominion", "2021" },
                    { 37, false, "", 102, "Watcher", "2021" },
                    { 38, false, "", 103, "Top Gun: Maverick", "2021" },
                    { 39, false, "", 102, "Bullet Train", "2021" },
                    { 40, false, "", 103, "The Red Book Ritual", "2021" },
                    { 41, false, "", 102, "The Invitation", "2021" },
                    { 42, false, "", 102, "To Kill the Beast", "2020" },
                    { 43, false, "", 102, "Fullmetal Alchemist: The Final Alchemy", "2022" },
                    { 44, false, "", 102, "Minions: The Rise of Gru", "2020" },
                    { 45, false, "", 102, "Sonic the Hedgehog 2", "2020" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Date", "Description", "IsDeleted", "MovieId", "Rating", "User" },
                values: new object[] { 1, new DateTime(2022, 11, 25, 16, 23, 56, 58, DateTimeKind.Local).AddTicks(5350), "Lorem Ipsum is simply dummy text of the printing", false, 1, 2.5, "Testing@mail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MoviesMovieId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MoviesMovieId",
                table: "Reviews",
                column: "MoviesMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MoviesMovieId",
                table: "Reviews",
                column: "MoviesMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");
        }
    }
}
