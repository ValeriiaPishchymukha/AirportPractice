using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airport.DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_AircraftTypes_AircraftTypeId",
                table: "Aircraft");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircraft",
                table: "Aircraft");

            migrationBuilder.RenameTable(
                name: "Aircraft",
                newName: "Aircrafts");

            migrationBuilder.RenameIndex(
                name: "IX_Aircraft_AircraftTypeId",
                table: "Aircrafts",
                newName: "IX_Aircrafts_AircraftTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PilotAircrafts",
                columns: table => new
                {
                    PilotId = table.Column<int>(type: "int", nullable: false),
                    AircraftId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilotAircrafts", x => new { x.PilotId, x.AircraftId });
                    table.ForeignKey(
                        name: "FK_PilotAircrafts_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PilotAircrafts_Pilots_PilotId",
                        column: x => x.PilotId,
                        principalTable: "Pilots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PilotAircrafts_AircraftId",
                table: "PilotAircrafts",
                column: "AircraftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts",
                column: "AircraftTypeId",
                principalTable: "AircraftTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts");

            migrationBuilder.DropTable(
                name: "PilotAircrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts");

            migrationBuilder.RenameTable(
                name: "Aircrafts",
                newName: "Aircraft");

            migrationBuilder.RenameIndex(
                name: "IX_Aircrafts_AircraftTypeId",
                table: "Aircraft",
                newName: "IX_Aircraft_AircraftTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircraft",
                table: "Aircraft",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_AircraftTypes_AircraftTypeId",
                table: "Aircraft",
                column: "AircraftTypeId",
                principalTable: "AircraftTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
