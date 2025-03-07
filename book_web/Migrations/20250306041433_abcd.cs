using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_web.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenreName",
                table: "BookViewModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb9f3ac8-543d-46a7-be26-755fd3fc3a90", "AQAAAAIAAYagAAAAELLEOvv+CWuP/RwjtK2Qtya4GzZtV2GnSA8oZWUlA1eOurHM2nMhs1cOVAdgEAmShQ==", "cd11e8a4-e481-42a9-b6b4-abe076ebca51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2492cd46-4f9d-47c7-aa58-fe2595c8a875", "AQAAAAIAAYagAAAAEKc/Ikp8Nf7tl1c92Iztyr82OqlkTvYVYKqHef3m7B6O5H7jB2AAw1OgPAvxvEKs3A==", "25098d27-e404-4d44-985d-ae38fae0edf6" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 10, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7370), new DateTime(2025, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7407), new DateTime(2018, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7409), new DateTime(2025, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7411), new DateTime(2020, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "DateAdded", "LastUpdated", "PublishedDate" },
                values: new object[] { new DateTime(2024, 7, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7415), new DateTime(2025, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7416), new DateTime(2019, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 1,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 13, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "BookClubs",
                keyColumn: "Id",
                keyValue: 2,
                column: "MeetingDate",
                value: new DateTime(2025, 3, 20, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 6, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 3, 16, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 4, 5, 11, 14, 32, 513, DateTimeKind.Local).AddTicks(7475));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreName",
                table: "BookViewModel");

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

            migrationBuilder.UpdateData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "BookStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 2, 26, 15, 9, 51, 218, DateTimeKind.Local).AddTicks(564));

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
    }
}
