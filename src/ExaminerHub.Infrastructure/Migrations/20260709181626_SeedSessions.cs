using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExaminerHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedSessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Location", "ScheduledDate", "Title" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Kensite Murcia", new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "B2 First Speaking Session" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Kensite Alicante", new DateTime(2026, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "C1 Advanced Speaking Session" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));
        }
    }
}
