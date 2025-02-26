using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class test_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "OrderItems");

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
                column: "Date",
                value: new DateTime(2025, 3, 20, 16, 14, 59, 899, DateTimeKind.Local).AddTicks(3670));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "OrderItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02eb6bf1-f975-40ff-a7e2-b705f78e97f7", "AQAAAAIAAYagAAAAEKxRxCYyUXNdk8qYWki8ZJILAI9O0zVPlB1wIQ+OCJdPAnOCB4MArfIIR2MLhIDVOg==", "53da98d3-a4ae-46d8-8865-1212b812c7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23390f5a-21fb-4965-9cf9-78c2b9cca9d5", "AQAAAAIAAYagAAAAEHj9YvcrhB0rfK6IqCJ5HNrEEs0x//+VUvRekDxffLEDI1kBgeszOqKbzmD42Xa1/g==", "88be0b99-82e8-4678-b8fc-1976b28fee23" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5319), new DateTime(2025, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5357), new DateTime(2018, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5359), new DateTime(2025, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5361), new DateTime(2020, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5363), new DateTime(2025, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5364), new DateTime(2019, 2, 18, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 2, 25, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 4, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 2, 28, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 20, 15, 59, 15, 533, DateTimeKind.Local).AddTicks(5426));
        }
    }
}
