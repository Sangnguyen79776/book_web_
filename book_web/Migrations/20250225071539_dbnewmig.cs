using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class dbnewmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SearchString",
                table: "BookViewModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6bb70e-1b0d-4766-b995-be15622fb8e1", "AQAAAAIAAYagAAAAEOewVixfgJY/7hLoMFFudf+OdR59aTGgWIsBSHLZvBzhnMVOM9sLgstJz0FHjV/QEQ==", "02e00af6-9d63-49fb-ab15-d1794780b962" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58f06387-4168-4619-8585-21503547d511", "AQAAAAIAAYagAAAAEAJL3RN7Du7HgTVFt9vVNHLUoomz6haglZe1URd8lT/11rl1lumZH324Jo3Xte5HMA==", "9d6b3edf-a470-40ed-a788-3f41bc975737" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9188), new DateTime(2025, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9226), new DateTime(2018, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9237), new DateTime(2020, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9241), new DateTime(2025, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9245), new DateTime(2019, 2, 25, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 11, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 7, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 27, 14, 15, 38, 179, DateTimeKind.Local).AddTicks(9504));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SearchString",
                table: "BookViewModel");

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
    }
}
