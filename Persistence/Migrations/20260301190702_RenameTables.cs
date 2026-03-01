using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capacitors_ElectronicComponent_Id",
                table: "Capacitors");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicComponent_Item_Id",
                table: "ElectronicComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_FerriteBeads_ElectronicComponent_Id",
                table: "FerriteBeads");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericElectronicComponents_ElectronicComponent_Id",
                table: "GenericElectronicComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Resistors_ElectronicComponent_Id",
                table: "Resistors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectronicComponent",
                table: "ElectronicComponent");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "ElectronicComponent",
                newName: "ElectronicComponents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectronicComponents",
                table: "ElectronicComponents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Capacitors_ElectronicComponents_Id",
                table: "Capacitors",
                column: "Id",
                principalTable: "ElectronicComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicComponents_Items_Id",
                table: "ElectronicComponents",
                column: "Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FerriteBeads_ElectronicComponents_Id",
                table: "FerriteBeads",
                column: "Id",
                principalTable: "ElectronicComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericElectronicComponents_ElectronicComponents_Id",
                table: "GenericElectronicComponents",
                column: "Id",
                principalTable: "ElectronicComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resistors_ElectronicComponents_Id",
                table: "Resistors",
                column: "Id",
                principalTable: "ElectronicComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Capacitors_ElectronicComponents_Id",
                table: "Capacitors");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectronicComponents_Items_Id",
                table: "ElectronicComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_FerriteBeads_ElectronicComponents_Id",
                table: "FerriteBeads");

            migrationBuilder.DropForeignKey(
                name: "FK_GenericElectronicComponents_ElectronicComponents_Id",
                table: "GenericElectronicComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Resistors_ElectronicComponents_Id",
                table: "Resistors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectronicComponents",
                table: "ElectronicComponents");

            migrationBuilder.RenameTable(
                name: "ElectronicComponents",
                newName: "ElectronicComponent");
            
            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectronicComponent",
                table: "ElectronicComponent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Capacitors_ElectronicComponent_Id",
                table: "Capacitors",
                column: "Id",
                principalTable: "ElectronicComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectronicComponent_Item_Id",
                table: "ElectronicComponent",
                column: "Id",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FerriteBeads_ElectronicComponent_Id",
                table: "FerriteBeads",
                column: "Id",
                principalTable: "ElectronicComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenericElectronicComponents_ElectronicComponent_Id",
                table: "GenericElectronicComponents",
                column: "Id",
                principalTable: "ElectronicComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resistors_ElectronicComponent_Id",
                table: "Resistors",
                column: "Id",
                principalTable: "ElectronicComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
