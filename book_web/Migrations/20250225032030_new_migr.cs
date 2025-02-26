using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class new_migr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookViewModel",
                columns: table => new
                {
                    CurrentPage = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalPages = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b455dda6-cb1b-430c-8bd8-31796ac3a0b0", "AQAAAAIAAYagAAAAEOHIfnkoh9TWAQ/nuyXuHFzDksln3zS6tyi9pyunEoQ39K5Ae0coJoKTadp7sjrNsw==", "8c66e93c-4028-4f77-b0e9-d8d5e49659db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41fd2603-48c5-4fb8-bfec-9e667e0fec83", "AQAAAAIAAYagAAAAECo2uw83bLuSL+czRQ/xt4wVaoAkwBVNudTZHg/JgjvKvxWwTZ6rCnK0un81c+2/Jg==", "0c3a3cd8-d652-40ad-89e4-a85d40783632" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4223), new DateTime(2025, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4249), new DateTime(2018, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4251), new DateTime(2025, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4253), new DateTime(2020, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4254), new DateTime(2025, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4256), new DateTime(2019, 2, 25, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 11, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 7, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 27, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4305), "https://th.bing.com/th/id/OIP.wT9mRKIUU-dlHXh0SmCuCwHaGN?w=940&h=788&rs=1&pid=ImgDetMain" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookViewModel");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf8a6fc5-e7d5-4762-8df4-d29c03d69763", "AQAAAAIAAYagAAAAEOIkBSKM/nNzBaWpLv+tFw0upVDJGVg11Ys0VU8HIUtwd/vsHo60vJtqgvpkf7bbOA==", "3c6f84a7-c5a5-4b31-a77a-aee6683b86bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5f7bf0e-46fd-4999-82d8-dd64b96f8f0f", "AQAAAAIAAYagAAAAENP6PNSeAgojRE1roLN95bPefvhy7K9MI8mVsgDN/zOscxY+1UVNc9m6S49mTewAOw==", "86504295-b261-43a4-8ea2-e299a53e7baa" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3588), new DateTime(2025, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3611), new DateTime(2018, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3614), new DateTime(2025, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3615), new DateTime(2020, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3617), new DateTime(2025, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3618), new DateTime(2019, 2, 18, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 2, 25, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 2, 28, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "ImageUrl" },
                values: new object[] { new DateTime(2025, 3, 20, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3670), "https://th.bing.com/th?id=OIF.U3Rim%2bX2peFUrZDE55xvYQ&w=322&h=181&c=7&r=0&o=5&dpr=1.1&pid=1.7" });
        }
    }
}
