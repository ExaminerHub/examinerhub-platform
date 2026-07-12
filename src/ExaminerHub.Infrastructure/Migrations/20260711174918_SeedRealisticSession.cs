using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExaminerHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRealisticSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Centres",
                columns: new[] { "Id", "Address", "ContactEmail", "ContactName", "ContactPhone", "Name" },
                values: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Murcia", "admin@kensite.example", "Centre Administrator", "", "Kensington Site" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Room 1" });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "ArrivalTime", "CentreId", "ExpectedFinishTime", "FirstCandidateTime", "IsRemotePartner", "Notes", "PartnerExaminerName", "RoomId", "SessionDate", "ZoomLink" },
                values: new object[] { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new TimeSpan(0, 9, 0, 0, 0), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new TimeSpan(0, 14, 10, 0, 0), new TimeSpan(0, 9, 30, 0, 0), false, "Arrive 30 minutes before the first candidate.", "Gemma", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.InsertData(
                table: "ExamAssignments",
                columns: new[] { "Id", "Level", "PairCount", "SessionId", "TrioCount" },
                values: new object[,]
                {
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd01"), "FCE FS", 3, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 1 },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd02"), "PET FS", 9, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0 },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"), "PET", 4, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExamAssignments",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd01"));

            migrationBuilder.DeleteData(
                table: "ExamAssignments",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd02"));

            migrationBuilder.DeleteData(
                table: "ExamAssignments",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"));

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Centres",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));
        }
    }
}
