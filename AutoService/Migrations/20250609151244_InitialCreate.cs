using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mechanics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    MechanicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRecords_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LicensePlate",
                table: "Cars",
                column: "LicensePlate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_VIN",
                table: "Cars",
                column: "VIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_CarId",
                table: "ServiceRecords",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_MechanicId",
                table: "ServiceRecords",
                column: "MechanicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Mechanics");
        }
    }
}
