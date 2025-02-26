using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class AB00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookCover",
                table: "Book",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54238b3-7bd1-40e9-a8e1-f757c075d50b", "AQAAAAIAAYagAAAAECrIBEWPrZ8eD6AS3G6k7KPFFJFB3bERrnc1eTCjDbSpDEYyJKFhCsbXEAD+diELog==", "3e718af5-8bad-45a8-a224-14cecc551a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23334383-7e76-4254-b94d-3c8bce75a8db", "AQAAAAIAAYagAAAAEIWqZR9nQh9979u2NbkCoi4j5mC2438xDxNxkBU72UvuXL1R/CPmVe9dNGKvwGxDCw==", "ee4864a6-0e39-43cd-b8e5-1fb6baad9834" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6175), new DateTime(2025, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6201), new DateTime(2018, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6203), new DateTime(2025, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6205), new DateTime(2020, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6207), new DateTime(2025, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6208), new DateTime(2019, 2, 25, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 11, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 7, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 27, 15, 49, 30, 325, DateTimeKind.Local).AddTicks(6254));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookCover",
                table: "Book",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
    }
}
