using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class A_new_db_test_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff710e57-c951-482a-8024-7e23325312e7", "AQAAAAIAAYagAAAAEBF53Sjwl4p72OKYM1DrXj7NWEQoMgs9oZtAZphVDkQQp3AHGIn0D853DV/VPWJ6lQ==", "5c5144b9-c48b-4d48-a7c6-9f559f433cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abf060a4-fea4-40e0-a35a-60bb9f298c08", "AQAAAAIAAYagAAAAEL+p/kO4vKSiiBk31Z0zMf4MmiB5TiBHL7/XDElSabjBFbvQoEXvRxiAwUtgiDCxKA==", "967b3c94-b226-457d-97e1-74fefa1ba1fe" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(228), new DateTime(2018, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(232), new DateTime(2020, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(235), new DateTime(2019, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 5, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 12, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.InsertData(
                table: "BookStatistics",
                columns: new[] { "Id", "BookId", "Date", "Sales", "Views" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(562), 1200, 540 },
                    { 2, 3, new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(564), 985, 320 }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 8, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 28, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(293));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
