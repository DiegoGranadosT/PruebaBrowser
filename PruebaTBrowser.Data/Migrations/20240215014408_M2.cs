using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace PruebaTBrowser.Data.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedioPagoId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MedioPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioPago", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MedioPagoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_MedioPago_MedioPagoId",
                        column: x => x.MedioPagoId,
                        principalTable: "MedioPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_FacturaId",
                table: "Reserva",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_MedioPagoId",
                table: "Factura",
                column: "MedioPagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Factura_FacturaId",
                table: "Reserva",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Factura_FacturaId",
                table: "Reserva");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "MedioPago");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_FacturaId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "MedioPagoId",
                table: "Reserva");
        }
    }
}
