using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class db_12_new_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookStatisticViewModel",
                columns: table => new
                {
                    Labels = table.Column<string>(type: "TEXT", nullable: false),
                    Views = table.Column<string>(type: "TEXT", nullable: false),
                    Sales = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8702d9c2-caab-4c6a-a4b4-ff8abc80eaf5", "AQAAAAIAAYagAAAAEIttOuc0VbtLqp1PFY+I6XieTyRsgfDrOYzB+/7i4Cvt2u8KKb/xJk3Pr/tsoEjJFw==", "a04d3295-df77-4bd3-8054-f3c54d7d9b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "428d442f-0c0f-4ff4-a979-57ce76ffa4e6", "AQAAAAIAAYagAAAAENlJ9T40rxnDR5qopILlizLKcylE72Ca7mMKIpQLC7LmlXEueSkg1YoxZAs11eVXgg==", "dd65b9b9-2fbc-45c8-96a6-bf21e0e22e87" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4461), new DateTime(2018, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4467), new DateTime(2020, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4471), new DateTime(2019, 2, 26, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 5, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 12, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 8, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 28, 11, 38, 58, 274, DateTimeKind.Local).AddTicks(4533));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStatisticViewModel");

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
        }
    }
}
