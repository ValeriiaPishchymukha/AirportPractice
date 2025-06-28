using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airport.DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class MigrationSeeding5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FlightDestinations",
                columns: new[] { "Id", "AircraftId", "AirportId", "Departure", "PassengerId", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 29, 29, new DateTime(2020, 1, 1, 1, 26, 11, 0, DateTimeKind.Unspecified), 86, 4096.92m },
                    { 2, 80, 1, new DateTime(2020, 4, 26, 17, 51, 13, 0, DateTimeKind.Unspecified), 16, 1904.47m },
                    { 3, 25, 27, new DateTime(2020, 2, 18, 14, 0, 1, 0, DateTimeKind.Unspecified), 86, 404.01m },
                    { 4, 92, 3, new DateTime(2020, 3, 22, 4, 23, 48, 0, DateTimeKind.Unspecified), 59, 2490.24m },
                    { 5, 74, 34, new DateTime(2021, 4, 17, 12, 30, 28, 0, DateTimeKind.Unspecified), 72, 405.83m },
                    { 6, 1, 42, new DateTime(2020, 9, 21, 22, 50, 50, 0, DateTimeKind.Unspecified), 69, 1880.23m },
                    { 7, 78, 31, new DateTime(2020, 10, 16, 4, 58, 11, 0, DateTimeKind.Unspecified), 4, 2111.93m },
                    { 8, 100, 15, new DateTime(2020, 1, 13, 5, 32, 42, 0, DateTimeKind.Unspecified), 89, 2110.56m },
                    { 9, 22, 41, new DateTime(2020, 2, 6, 22, 32, 14, 0, DateTimeKind.Unspecified), 48, 4100.49m },
                    { 10, 63, 11, new DateTime(2020, 6, 6, 22, 44, 50, 0, DateTimeKind.Unspecified), 92, 150.56m },
                    { 11, 83, 1, new DateTime(2020, 8, 26, 6, 9, 21, 0, DateTimeKind.Unspecified), 63, 290.98m },
                    { 12, 93, 12, new DateTime(2021, 4, 20, 9, 34, 41, 0, DateTimeKind.Unspecified), 53, 930.27m },
                    { 13, 80, 28, new DateTime(2020, 2, 4, 4, 59, 33, 0, DateTimeKind.Unspecified), 89, 3280.36m },
                    { 14, 13, 31, new DateTime(2021, 1, 19, 11, 5, 43, 0, DateTimeKind.Unspecified), 65, 3083.05m },
                    { 15, 49, 18, new DateTime(2020, 4, 17, 23, 42, 6, 0, DateTimeKind.Unspecified), 63, 3087.56m },
                    { 16, 37, 5, new DateTime(2021, 2, 6, 1, 3, 30, 0, DateTimeKind.Unspecified), 61, 1780.60m },
                    { 17, 47, 28, new DateTime(2020, 10, 29, 5, 10, 21, 0, DateTimeKind.Unspecified), 19, 300.46m },
                    { 18, 5, 12, new DateTime(2021, 4, 18, 11, 35, 23, 0, DateTimeKind.Unspecified), 79, 2180.54m },
                    { 19, 77, 21, new DateTime(2020, 7, 3, 21, 38, 23, 0, DateTimeKind.Unspecified), 28, 1801.36m },
                    { 20, 4, 18, new DateTime(2020, 2, 27, 6, 6, 45, 0, DateTimeKind.Unspecified), 28, 440.72m },
                    { 21, 50, 34, new DateTime(2020, 8, 2, 15, 43, 34, 0, DateTimeKind.Unspecified), 88, 3010.46m },
                    { 22, 33, 27, new DateTime(2020, 4, 10, 23, 14, 6, 0, DateTimeKind.Unspecified), 86, 160.99m },
                    { 23, 36, 17, new DateTime(2021, 4, 30, 6, 25, 18, 0, DateTimeKind.Unspecified), 78, 300.07m },
                    { 24, 6, 42, new DateTime(2020, 3, 24, 21, 8, 22, 0, DateTimeKind.Unspecified), 70, 2170.03m },
                    { 25, 33, 6, new DateTime(2020, 10, 1, 0, 35, 46, 0, DateTimeKind.Unspecified), 92, 470.11m },
                    { 26, 55, 11, new DateTime(2021, 2, 2, 4, 44, 5, 0, DateTimeKind.Unspecified), 88, 460.57m },
                    { 27, 2, 13, new DateTime(2021, 5, 2, 12, 52, 14, 0, DateTimeKind.Unspecified), 31, 3091.31m },
                    { 28, 44, 42, new DateTime(2020, 11, 11, 11, 15, 42, 0, DateTimeKind.Unspecified), 37, 2130.86m },
                    { 29, 20, 31, new DateTime(2020, 11, 14, 7, 12, 0, 0, DateTimeKind.Unspecified), 78, 1120.51m },
                    { 30, 45, 23, new DateTime(2021, 5, 25, 2, 55, 43, 0, DateTimeKind.Unspecified), 41, 405.97m },
                    { 31, 79, 4, new DateTime(2020, 12, 12, 3, 6, 6, 0, DateTimeKind.Unspecified), 19, 260.58m },
                    { 32, 75, 5, new DateTime(2020, 9, 10, 1, 55, 19, 0, DateTimeKind.Unspecified), 22, 3690.22m },
                    { 33, 76, 10, new DateTime(2020, 2, 6, 2, 3, 35, 0, DateTimeKind.Unspecified), 8, 1017.93m },
                    { 34, 82, 16, new DateTime(2020, 6, 13, 10, 53, 40, 0, DateTimeKind.Unspecified), 86, 3190.57m },
                    { 35, 77, 3, new DateTime(2020, 1, 15, 9, 11, 40, 0, DateTimeKind.Unspecified), 12, 380.32m },
                    { 36, 38, 1, new DateTime(2020, 3, 2, 21, 56, 45, 0, DateTimeKind.Unspecified), 57, 350.42m },
                    { 37, 80, 39, new DateTime(2020, 7, 19, 18, 1, 3, 0, DateTimeKind.Unspecified), 86, 1150.16m },
                    { 38, 67, 39, new DateTime(2020, 10, 14, 23, 26, 43, 0, DateTimeKind.Unspecified), 14, 780.61m },
                    { 39, 2, 2, new DateTime(2021, 2, 17, 21, 18, 51, 0, DateTimeKind.Unspecified), 64, 1130.19m },
                    { 40, 14, 36, new DateTime(2020, 1, 5, 11, 5, 38, 0, DateTimeKind.Unspecified), 65, 1580.50m },
                    { 41, 20, 6, new DateTime(2020, 8, 10, 11, 33, 10, 0, DateTimeKind.Unspecified), 64, 1800.43m },
                    { 42, 90, 14, new DateTime(2020, 4, 20, 23, 28, 53, 0, DateTimeKind.Unspecified), 24, 4080.54m },
                    { 43, 34, 40, new DateTime(2020, 4, 24, 23, 48, 4, 0, DateTimeKind.Unspecified), 4, 490.84m },
                    { 44, 1, 22, new DateTime(2020, 6, 25, 18, 16, 14, 0, DateTimeKind.Unspecified), 26, 730.22m },
                    { 45, 18, 12, new DateTime(2020, 1, 20, 14, 27, 26, 0, DateTimeKind.Unspecified), 49, 260.61m },
                    { 46, 27, 27, new DateTime(2021, 1, 15, 15, 23, 51, 0, DateTimeKind.Unspecified), 42, 380.22m },
                    { 47, 33, 41, new DateTime(2021, 5, 19, 2, 24, 33, 0, DateTimeKind.Unspecified), 26, 230.61m },
                    { 48, 59, 10, new DateTime(2020, 2, 4, 23, 30, 5, 0, DateTimeKind.Unspecified), 88, 260.32m },
                    { 49, 28, 4, new DateTime(2020, 12, 29, 6, 46, 6, 0, DateTimeKind.Unspecified), 15, 280.52m },
                    { 50, 44, 21, new DateTime(2020, 7, 25, 23, 22, 34, 0, DateTimeKind.Unspecified), 81, 680.22m },
                    { 51, 84, 33, new DateTime(2020, 4, 19, 14, 32, 41, 0, DateTimeKind.Unspecified), 29, 470.16m },
                    { 52, 56, 2, new DateTime(2020, 1, 4, 18, 44, 46, 0, DateTimeKind.Unspecified), 43, 300.88m },
                    { 53, 35, 43, new DateTime(2020, 3, 25, 14, 42, 8, 0, DateTimeKind.Unspecified), 92, 900.26m },
                    { 54, 83, 29, new DateTime(2021, 4, 5, 3, 46, 29, 0, DateTimeKind.Unspecified), 11, 690.20m },
                    { 55, 64, 1, new DateTime(2021, 1, 5, 19, 38, 45, 0, DateTimeKind.Unspecified), 28, 500.52m },
                    { 56, 24, 19, new DateTime(2020, 3, 6, 4, 54, 13, 0, DateTimeKind.Unspecified), 54, 1180.14m },
                    { 57, 81, 31, new DateTime(2020, 5, 29, 22, 36, 38, 0, DateTimeKind.Unspecified), 18, 1090.53m },
                    { 58, 19, 32, new DateTime(2020, 1, 5, 22, 15, 12, 0, DateTimeKind.Unspecified), 75, 480.44m },
                    { 59, 26, 7, new DateTime(2020, 12, 7, 3, 19, 32, 0, DateTimeKind.Unspecified), 38, 540.29m },
                    { 60, 62, 14, new DateTime(2020, 5, 10, 11, 2, 1, 0, DateTimeKind.Unspecified), 16, 670.29m },
                    { 61, 25, 35, new DateTime(2020, 6, 23, 7, 5, 5, 0, DateTimeKind.Unspecified), 6, 1020.18m },
                    { 62, 84, 15, new DateTime(2020, 9, 26, 15, 14, 23, 0, DateTimeKind.Unspecified), 5, 1150.00m },
                    { 63, 21, 18, new DateTime(2021, 1, 17, 6, 43, 22, 0, DateTimeKind.Unspecified), 74, 1180.50m },
                    { 64, 88, 22, new DateTime(2020, 12, 31, 18, 54, 0, 0, DateTimeKind.Unspecified), 77, 410.22m },
                    { 65, 6, 8, new DateTime(2020, 11, 12, 21, 39, 49, 0, DateTimeKind.Unspecified), 10, 490.70m },
                    { 66, 29, 30, new DateTime(2021, 2, 20, 3, 41, 37, 0, DateTimeKind.Unspecified), 61, 730.10m },
                    { 67, 40, 17, new DateTime(2021, 3, 16, 2, 18, 22, 0, DateTimeKind.Unspecified), 21, 820.45m },
                    { 68, 51, 5, new DateTime(2021, 4, 18, 22, 2, 53, 0, DateTimeKind.Unspecified), 82, 380.60m },
                    { 69, 37, 13, new DateTime(2020, 1, 10, 9, 14, 4, 0, DateTimeKind.Unspecified), 57, 430.16m },
                    { 70, 60, 25, new DateTime(2020, 8, 21, 19, 38, 14, 0, DateTimeKind.Unspecified), 69, 880.00m },
                    { 71, 18, 39, new DateTime(2020, 6, 27, 21, 3, 9, 0, DateTimeKind.Unspecified), 30, 420.85m },
                    { 72, 12, 4, new DateTime(2020, 3, 15, 8, 26, 54, 0, DateTimeKind.Unspecified), 85, 1090.52m },
                    { 73, 42, 24, new DateTime(2020, 2, 17, 23, 7, 36, 0, DateTimeKind.Unspecified), 45, 540.99m },
                    { 74, 65, 36, new DateTime(2020, 7, 4, 5, 45, 1, 0, DateTimeKind.Unspecified), 20, 690.30m },
                    { 75, 17, 34, new DateTime(2020, 5, 12, 4, 25, 50, 0, DateTimeKind.Unspecified), 25, 310.56m },
                    { 76, 69, 28, new DateTime(2020, 1, 30, 18, 49, 47, 0, DateTimeKind.Unspecified), 7, 250.36m },
                    { 77, 11, 3, new DateTime(2020, 12, 22, 20, 17, 36, 0, DateTimeKind.Unspecified), 39, 750.27m },
                    { 78, 73, 26, new DateTime(2020, 9, 6, 12, 2, 51, 0, DateTimeKind.Unspecified), 53, 520.24m },
                    { 79, 54, 11, new DateTime(2020, 4, 25, 7, 58, 17, 0, DateTimeKind.Unspecified), 50, 420.13m },
                    { 80, 39, 7, new DateTime(2020, 11, 19, 1, 43, 38, 0, DateTimeKind.Unspecified), 60, 120.34m },
                    { 81, 9, 9, new DateTime(2020, 2, 28, 6, 12, 24, 0, DateTimeKind.Unspecified), 11, 130.54m },
                    { 82, 32, 20, new DateTime(2020, 3, 12, 8, 29, 1, 0, DateTimeKind.Unspecified), 33, 420.67m },
                    { 83, 15, 1, new DateTime(2020, 10, 4, 16, 44, 45, 0, DateTimeKind.Unspecified), 49, 270.80m },
                    { 84, 13, 38, new DateTime(2020, 6, 13, 22, 17, 51, 0, DateTimeKind.Unspecified), 12, 210.43m },
                    { 85, 7, 16, new DateTime(2020, 9, 15, 9, 1, 31, 0, DateTimeKind.Unspecified), 25, 460.59m },
                    { 86, 58, 15, new DateTime(2020, 1, 27, 7, 35, 50, 0, DateTimeKind.Unspecified), 19, 390.28m },
                    { 87, 10, 35, new DateTime(2020, 4, 14, 20, 41, 37, 0, DateTimeKind.Unspecified), 34, 410.91m },
                    { 88, 53, 23, new DateTime(2020, 5, 16, 23, 59, 1, 0, DateTimeKind.Unspecified), 44, 370.82m },
                    { 89, 41, 30, new DateTime(2020, 11, 29, 13, 44, 36, 0, DateTimeKind.Unspecified), 17, 330.75m },
                    { 90, 8, 37, new DateTime(2020, 3, 3, 12, 21, 42, 0, DateTimeKind.Unspecified), 23, 290.48m },
                    { 91, 31, 22, new DateTime(2020, 8, 20, 11, 58, 59, 0, DateTimeKind.Unspecified), 13, 420.10m },
                    { 92, 72, 33, new DateTime(2020, 9, 17, 18, 22, 55, 0, DateTimeKind.Unspecified), 48, 250.61m },
                    { 93, 66, 25, new DateTime(2020, 2, 28, 9, 44, 23, 0, DateTimeKind.Unspecified), 59, 400.12m },
                    { 94, 23, 28, new DateTime(2020, 7, 30, 15, 7, 6, 0, DateTimeKind.Unspecified), 14, 460.90m },
                    { 95, 16, 6, new DateTime(2020, 4, 1, 20, 39, 38, 0, DateTimeKind.Unspecified), 9, 330.22m },
                    { 96, 61, 10, new DateTime(2020, 5, 12, 18, 53, 19, 0, DateTimeKind.Unspecified), 66, 390.30m },
                    { 97, 43, 13, new DateTime(2020, 6, 23, 17, 10, 24, 0, DateTimeKind.Unspecified), 71, 350.43m },
                    { 98, 30, 18, new DateTime(2020, 10, 14, 11, 42, 37, 0, DateTimeKind.Unspecified), 24, 380.80m },
                    { 99, 57, 20, new DateTime(2020, 11, 15, 15, 29, 42, 0, DateTimeKind.Unspecified), 27, 310.19m },
                    { 100, 68, 42, new DateTime(2020, 12, 16, 21, 8, 50, 0, DateTimeKind.Unspecified), 31, 420.32m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "FlightDestinations",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
