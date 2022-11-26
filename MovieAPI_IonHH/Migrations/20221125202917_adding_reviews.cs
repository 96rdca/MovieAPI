using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieAPIIonHH.Migrations
{
    /// <inheritdoc />
    public partial class addingreviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Date", "Description", "IsDeleted", "MovieId", "Rating", "User" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(880), "Lorem Ipsum is simply dummy text of the printing", false, 1, 2.5, "Testing@mail.com" },
                    { 3, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(890), "Lorem Ipsum is simply dummy text of the printing", false, 2, 2.5, "Testing@mail.com" },
                    { 4, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(890), "Lorem Ipsum is simply dummy text of the printing", false, 2, 2.5, "Testing@mail.com" },
                    { 5, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(900), "Lorem Ipsum is simply dummy text of the printing", false, 3, 2.5, "Testing@mail.com" },
                    { 6, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(900), "Lorem Ipsum is simply dummy text of the printing", false, 3, 2.5, "Testing@mail.com" },
                    { 7, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(910), "Lorem Ipsum is simply dummy text of the printing", false, 4, 2.5, "Testing@mail.com" },
                    { 8, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(910), "Lorem Ipsum is simply dummy text of the printing", false, 4, 2.5, "Testing@mail.com" },
                    { 9, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(920), "Lorem Ipsum is simply dummy text of the printing", false, 5, 2.5, "Testing@mail.com" },
                    { 10, new DateTime(2022, 11, 25, 16, 29, 16, 828, DateTimeKind.Local).AddTicks(920), "Lorem Ipsum is simply dummy text of the printing", false, 5, 2.5, "Testing@mail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 25, 16, 23, 56, 58, DateTimeKind.Local).AddTicks(5350));
        }
    }
}
