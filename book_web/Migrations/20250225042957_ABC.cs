using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class ABC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SortOrder",
                table: "BookViewModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b1d703b-262d-4204-a002-11be94ef8b5c", "AQAAAAIAAYagAAAAEKy63wq4aCCIceLCKCEf+SfefnjTIld/ZInG4qTTJsZj6TWOsqTGboidhiCpMkX1sg==", "c2c68602-1dc1-4013-8464-8bc5e77263bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "599c99b8-773f-4563-bfb7-f70e7970c6f5", "AQAAAAIAAYagAAAAEGUale56o4bgevmwcWGoQfeAJZ9DhZyfJzUEqWRHL8gYx2Hpp6MRR3CzX01PiroKlg==", "b026fc80-a3b9-4de5-9964-5075afdec98e" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5809), new DateTime(2025, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5835), new DateTime(2018, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5837), new DateTime(2025, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5839), new DateTime(2020, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5910), new DateTime(2025, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5911), new DateTime(2019, 2, 25, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 11, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 7, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 27, 11, 29, 56, 453, DateTimeKind.Local).AddTicks(5962));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "BookViewModel");

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
                column: "Date",
                value: new DateTime(2025, 3, 27, 10, 20, 29, 881, DateTimeKind.Local).AddTicks(4305));
        }
    }
}
