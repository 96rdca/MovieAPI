using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieAPIIonHH.Migrations
{
    /// <inheritdoc />
    public partial class addingdata1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "IsDeleted", "Overview", "Runtime", "Title", "Year" },
                values: new object[] { 1, false, "", 102, "Strange World", "2022" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Reviews");
        }
    }
}
