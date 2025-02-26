using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class new_for_mig_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Views = table.Column<int>(type: "INTEGER", nullable: false),
                    Sales = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStatistics_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd89fb35-af13-4f6e-8732-5519180cd848", "AQAAAAIAAYagAAAAEPCiuBPGHoje4c+xzf3E5e6pLubIojoNgXSL0sPnOo7McFDX3s9A6LdQYKfOhzAmyg==", "3e22d8a8-4cd6-4685-a4ed-ead3cf9af0da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a34de3-e3f2-48f4-882c-80d7a0db2ae7", "AQAAAAIAAYagAAAAEJ5uUc+6EHCAFln+RWA2XK/H4gDX8ZJpe//pVV/rbq/WswIvO94nKM00u/so8aJTUQ==", "52a3a654-127b-4380-9b45-9b6b80004086" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7154), new DateTime(2025, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7194), new DateTime(2018, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7197), new DateTime(2025, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7199), new DateTime(2020, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7202), new DateTime(2025, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7204), new DateTime(2019, 2, 26, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 5, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 12, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 8, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 28, 11, 4, 12, 868, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.CreateIndex(
                name: "IX_BookStatistics_BookId",
                table: "BookStatistics",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStatistics");

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
    }
}
