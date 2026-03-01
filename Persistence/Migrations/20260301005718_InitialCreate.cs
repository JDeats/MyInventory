using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerPartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicComponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MountingStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tolerance = table.Column<double>(type: "float", nullable: true),
                    LinkToDatasheet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectronicComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectronicComponent_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Capacitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Capacitance = table.Column<double>(type: "float", nullable: false),
                    Voltage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capacitors_ElectronicComponent_Id",
                        column: x => x.Id,
                        principalTable: "ElectronicComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FerriteBeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Impedance = table.Column<double>(type: "float", nullable: false),
                    MaxDcCurrent = table.Column<double>(type: "float", nullable: false),
                    MaxDcResistance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FerriteBeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FerriteBeads_ElectronicComponent_Id",
                        column: x => x.Id,
                        principalTable: "ElectronicComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenericElectronicComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericElectronicComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericElectronicComponents_ElectronicComponent_Id",
                        column: x => x.Id,
                        principalTable: "ElectronicComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resistors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Resistance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerRating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resistors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resistors_ElectronicComponent_Id",
                        column: x => x.Id,
                        principalTable: "ElectronicComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capacitors");

            migrationBuilder.DropTable(
                name: "FerriteBeads");

            migrationBuilder.DropTable(
                name: "GenericElectronicComponents");

            migrationBuilder.DropTable(
                name: "Resistors");

            migrationBuilder.DropTable(
                name: "ElectronicComponent");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
