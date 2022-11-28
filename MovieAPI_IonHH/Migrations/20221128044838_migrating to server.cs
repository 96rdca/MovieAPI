using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieAPIIonHH.Migrations
{
    /// <inheritdoc />
    public partial class migratingtoserver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Runtime = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "IsDeleted", "Overview", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 1, false, "", 102, "Strange World", "2022" },
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
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1140), "Lorem Ipsum is simply dummy text of the printing", false, 1, 2.5, "Testing@mail.com" },
                    { 2, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1200), "Lorem Ipsum is simply dummy text of the printing", false, 1, 2.5, "Testing@mail.com" },
                    { 3, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1200), "Lorem Ipsum is simply dummy text of the printing", false, 2, 2.5, "Testing@mail.com" },
                    { 4, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1210), "Lorem Ipsum is simply dummy text of the printing", false, 2, 2.5, "Testing@mail.com" },
                    { 5, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1220), "Lorem Ipsum is simply dummy text of the printing", false, 3, 2.5, "Testing@mail.com" },
                    { 6, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1220), "Lorem Ipsum is simply dummy text of the printing", false, 3, 2.5, "Testing@mail.com" },
                    { 7, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1220), "Lorem Ipsum is simply dummy text of the printing", false, 4, 2.5, "Testing@mail.com" },
                    { 8, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1230), "Lorem Ipsum is simply dummy text of the printing", false, 4, 2.5, "Testing@mail.com" },
                    { 9, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1230), "Lorem Ipsum is simply dummy text of the printing", false, 5, 2.5, "Testing@mail.com" },
                    { 10, new DateTime(2022, 11, 28, 0, 48, 37, 918, DateTimeKind.Local).AddTicks(1290), "Lorem Ipsum is simply dummy text of the printing", false, 5, 2.5, "Testing@mail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieId",
                table: "Reviews",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
