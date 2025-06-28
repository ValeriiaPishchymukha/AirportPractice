using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airport.DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class MigrationSeeding4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Departure",
                table: "FlightDestinations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "PilotAircrafts",
                columns: new[] { "AircraftId", "PilotId" },
                values: new object[,]
                {
                    { 36, 1 },
                    { 48, 2 },
                    { 85, 2 },
                    { 100, 2 },
                    { 3, 3 },
                    { 20, 3 },
                    { 84, 3 },
                    { 100, 3 },
                    { 18, 4 },
                    { 30, 4 },
                    { 94, 4 },
                    { 99, 5 },
                    { 96, 6 },
                    { 10, 7 },
                    { 42, 7 },
                    { 72, 7 },
                    { 84, 7 },
                    { 93, 7 },
                    { 20, 8 },
                    { 33, 8 },
                    { 10, 9 },
                    { 28, 9 },
                    { 49, 9 },
                    { 39, 10 },
                    { 66, 10 },
                    { 3, 11 },
                    { 4, 11 },
                    { 5, 12 },
                    { 47, 13 },
                    { 4, 14 },
                    { 94, 14 },
                    { 38, 15 },
                    { 57, 16 },
                    { 23, 17 },
                    { 6, 18 },
                    { 7, 18 },
                    { 30, 18 },
                    { 55, 18 },
                    { 5, 19 },
                    { 46, 19 },
                    { 96, 19 },
                    { 38, 20 },
                    { 48, 20 },
                    { 59, 20 },
                    { 70, 21 },
                    { 72, 21 },
                    { 5, 22 },
                    { 86, 22 },
                    { 55, 23 },
                    { 21, 24 },
                    { 33, 24 },
                    { 60, 25 },
                    { 48, 26 },
                    { 60, 26 },
                    { 81, 26 },
                    { 96, 26 },
                    { 42, 27 },
                    { 90, 27 },
                    { 42, 28 },
                    { 80, 29 },
                    { 85, 29 },
                    { 15, 30 },
                    { 70, 30 },
                    { 16, 31 },
                    { 52, 32 },
                    { 22, 33 },
                    { 25, 33 },
                    { 57, 33 },
                    { 12, 35 },
                    { 37, 35 },
                    { 21, 36 },
                    { 25, 36 },
                    { 32, 36 },
                    { 26, 37 },
                    { 72, 37 },
                    { 77, 37 },
                    { 90, 37 },
                    { 5, 38 },
                    { 55, 38 },
                    { 68, 38 },
                    { 81, 38 },
                    { 65, 39 },
                    { 80, 39 },
                    { 14, 40 },
                    { 21, 40 },
                    { 68, 41 },
                    { 69, 41 },
                    { 67, 42 },
                    { 82, 42 },
                    { 77, 43 },
                    { 56, 45 },
                    { 45, 47 },
                    { 67, 47 },
                    { 89, 47 },
                    { 4, 48 },
                    { 47, 48 },
                    { 20, 49 },
                    { 28, 49 },
                    { 6, 50 },
                    { 71, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 96, 6 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 84, 7 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 93, 7 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 49, 9 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 39, 10 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 66, 10 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 47, 13 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 94, 14 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 38, 15 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 57, 16 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 30, 18 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 55, 18 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 46, 19 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 96, 19 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 38, 20 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 48, 20 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 59, 20 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 70, 21 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 72, 21 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 86, 22 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 55, 23 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 21, 24 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 33, 24 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 60, 25 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 48, 26 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 60, 26 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 81, 26 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 96, 26 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 42, 27 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 90, 27 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 42, 28 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 80, 29 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 85, 29 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 15, 30 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 70, 30 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 16, 31 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 52, 32 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 22, 33 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 25, 33 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 57, 33 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 12, 35 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 37, 35 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 21, 36 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 25, 36 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 32, 36 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 26, 37 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 72, 37 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 77, 37 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 90, 37 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 5, 38 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 55, 38 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 68, 38 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 81, 38 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 65, 39 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 80, 39 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 14, 40 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 21, 40 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 68, 41 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 69, 41 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 67, 42 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 82, 42 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 77, 43 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 56, 45 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 45, 47 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 67, 47 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 89, 47 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 4, 48 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 47, 48 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 20, 49 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 28, 49 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 6, 50 });

            migrationBuilder.DeleteData(
                table: "PilotAircrafts",
                keyColumns: new[] { "AircraftId", "PilotId" },
                keyValues: new object[] { 71, 50 });

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "FlightDestinations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
