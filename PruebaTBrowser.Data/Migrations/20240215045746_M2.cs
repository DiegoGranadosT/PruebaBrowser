using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTBrowser.Data.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Nombre", "UpdatedOn", "UpdatedUserId" },
                values: new object[] { 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9573), null, "Browser", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9574), null });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Nombre", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(144), null, "Activo", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(145), null },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(146), null, "Finalizado", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(146), null },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(147), null, "Cancelado", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(147), null },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(148), null, "En Espera", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(148), null }
                });

            migrationBuilder.InsertData(
                table: "MedioPago",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Nombre", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8501), null, "Pago en destino", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8504), null },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8505), null, "Tarjeta de crédito", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8505), null },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8506), null, "Tarjeta de debito", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8507), null },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8507), null, "PSE", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8508), null },
                    { 5, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8508), null, "PayPal", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8508), null }
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Nombre", "UpdatedOn", "UpdatedUserId" },
                values: new object[] { 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8890), null, "Colombia", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(8890), null });

            migrationBuilder.InsertData(
                table: "Vehiculo",
                columns: new[] { "Id", "Año", "CreatedOn", "CreatedUserId", "Marca", "Modelo", "Placa", "Refernecia", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, "2015", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(375), null, "KIA", "", "DAW245", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(376), null },
                    { 2, "2018", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(379), null, "MAZDA", "", "HND135", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(379), null },
                    { 3, "2023", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(381), null, "RENAULD", "", "DAW578", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(381), null },
                    { 4, "2023", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(382), null, "RENAULD", "", "DFA123", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(382), null },
                    { 5, "2018", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(384), null, "MAZDA", "", "TRE455", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(384), null },
                    { 6, "2018", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(385), null, "RENAULD", "", "NJD145", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(385), null },
                    { 7, "2015", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(386), null, "RENAULD", "", "SDD231", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(386), null },
                    { 8, "2018", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(388), null, "KIA", "", "DAW234", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(388), null },
                    { 9, "2015", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(389), null, "MAZDA", "", "GHJJ353", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(389), null },
                    { 10, "2023", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(390), null, "MAZDA", "", "DWA123", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(390), null },
                    { 11, "2018", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(392), null, "KIA", "", "HJU897", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(392), null },
                    { 12, "2015", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(393), null, "RENAULD", "", "FGH678", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(393), null },
                    { 13, "2007", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(394), null, "RENAULD", "", "DGT678", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(394), null },
                    { 14, "2023", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(395), null, "KIA", "", "NJM834", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(396), null },
                    { 15, "2015", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(397), null, "KIA", "", "MKJ345", "", new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(397), null }
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Nombre", "PaisId", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9116), null, "Casanare", 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9116), null },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9119), null, "Boyaca", 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9119), null },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9120), null, "Cundinamarca", 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9120), null }
                });

            migrationBuilder.InsertData(
                table: "Factura",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Fecha", "MedioPagoId", "UpdatedOn", "UpdatedUserId", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8539), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8540), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8539), null, 200f },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8541), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8542), 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8541), null, 200f },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8542), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8543), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8543), null, 200f },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8544), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8545), 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8544), null, 200f },
                    { 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8545), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8546), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8545), null, 200f },
                    { 6, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8547), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8547), 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8547), null, 200f },
                    { 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8548), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8549), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8548), null, 200f },
                    { 8, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8549), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8550), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8550), null, 200f },
                    { 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8551), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8552), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8551), null, 200f },
                    { 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8552), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8553), 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8553), null, 200f },
                    { 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8554), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8554), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8554), null, 200f },
                    { 12, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8555), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8556), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8555), null, 200f },
                    { 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8556), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8557), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8557), null, 200f },
                    { 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8558), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8559), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8558), null, 200f },
                    { 15, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8559), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8560), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8559), null, 200f },
                    { 16, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8560), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8561), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8561), null, 200f },
                    { 17, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8562), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8563), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8562), null, 200f }
                });

            migrationBuilder.InsertData(
                table: "Renta",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "Periodo", "UpdatedOn", "UpdatedUserId", "Valor", "VehiculoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(624), null, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(624), null, 3500f, 1 },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(626), null, 0, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(627), null, 65f, 1 },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(628), null, 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(628), null, 5000f, 2 },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(629), null, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(629), null, 1200f, 3 },
                    { 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(630), null, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(630), null, 350f, 4 },
                    { 6, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(631), null, 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(631), null, 6500f, 5 },
                    { 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(632), null, 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(632), null, 2000f, 6 },
                    { 8, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(633), null, 0, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(633), null, 25f, 6 },
                    { 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(634), null, 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(634), null, 2200f, 6 },
                    { 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(635), null, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(636), null, 900f, 7 },
                    { 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(636), null, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(637), null, 850f, 8 },
                    { 12, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(638), null, 0, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(638), null, 90f, 9 },
                    { 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(639), null, 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(639), null, 250f, 10 },
                    { 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(640), null, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(640), null, 180f, 11 },
                    { 15, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(641), null, 0, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(641), null, 29f, 12 },
                    { 16, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(642), null, 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(642), null, 3600f, 13 },
                    { 17, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(643), null, 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(644), null, 2800f, 14 },
                    { 18, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(644), null, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(645), null, 450f, 15 },
                    { 19, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(645), null, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(646), null, 600f, 15 }
                });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "DepartamentoId", "Nombre", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9341), null, 1, "Yopal", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9341), null },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9343), null, 1, "Aguazul", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9343), null },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9344), null, 3, "Bogota", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9344), null },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9348), null, 2, "Sogamoso", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9349), null },
                    { 5, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9349), null, 2, "Paipa", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9350), null },
                    { 6, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9350), null, 2, "Tunja", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9351), null },
                    { 7, new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9351), null, 1, "Monterrey", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9352), null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellidos", "CiudadId", "CorreoElectronico", "CreatedOn", "CreatedUserId", "Edad", "EmpresaId", "Genero", "Nombres", "Telefono", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, "González", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9794), null, "25", 1, "Masculino", "Laura", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9794), null },
                    { 2, "Jiménez", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9799), null, "43", 1, "Femenino", "Andrés", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9799), null },
                    { 3, "Martínez", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9801), null, "63", 1, "Femenino", "Carlos", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9801), null },
                    { 4, "Jiménez", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9802), null, "25", 1, "Masculino", "Sofía", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9803), null },
                    { 5, "García", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9804), null, "16", 1, "Femenino", "Valentina", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9804), null },
                    { 6, "Torres", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9806), null, "46", 1, "Femenino", "Laura", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9806), null },
                    { 7, "González", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9807), null, "78", 1, "Femenino", "Daniel", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9808), null },
                    { 8, "González", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9809), null, "47", 1, "Masculino", "Mariana", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9809), null },
                    { 9, "Rojas", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9811), null, "37", 1, "Masculino", "Isabella", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9811), null },
                    { 10, "Díaz", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9812), null, "46", 1, "Femenino", "Ana", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9813), null },
                    { 11, "Muñoz", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9814), null, "69", 1, "Masculino", "Carlos", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9814), null },
                    { 12, "González", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9816), null, "47", 1, "Femenino", "Mariana", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9817), null },
                    { 13, "Pérez", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9818), null, "33", 1, "Femenino", "Diego", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9818), null },
                    { 14, "Vargas", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9820), null, "47", 1, "Masculino", "Laura", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9820), null },
                    { 15, "Gómez", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9821), null, "46", 1, "Femenino", "Juan", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9822), null },
                    { 16, "Romero", 3, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9823), null, "54", 1, "Masculino", "David", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9823), null },
                    { 17, "Martínez", 3, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9824), null, "35", 1, "Masculino", "Carlos", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9825), null },
                    { 18, "Muñoz", 3, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9827), null, "46", 1, "Femenino", "Alejandro", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9827), null },
                    { 19, "Díaz", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9828), null, "27", 1, "Femenino", "Camila", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9829), null },
                    { 20, "Romero", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9830), null, "46", 1, "Masculino", "Santiago", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9830), null },
                    { 21, "Rojas", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9832), null, "35", 1, "Masculino", "Laura", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9832), null },
                    { 22, "González", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9833), null, "56", 1, "Femenino", "Diego", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9833), null },
                    { 23, "Vargas", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9835), null, "34", 1, "Masculino", "Mateo", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9835), null },
                    { 24, "Pérez", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9836), null, "34", 1, "Masculino", "Carlos", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9837), null },
                    { 25, "Jiménez", 2, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9838), null, "37", 1, "Femenino", "Samuel", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9838), null },
                    { 26, "Torres", 1, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9840), null, "56", 1, "Femenino", "Camila", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9840), null },
                    { 27, "García", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9841), null, "67", 1, "Masculino", "Luis", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9841), null },
                    { 28, "González", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9843), null, "46", 1, "Masculino", "Mateo", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9843), null },
                    { 29, "Jiménez", 6, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9844), null, "46", 1, "Femenino", "Andrés", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9845), null },
                    { 30, "Martínez", 7, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9881), null, "58", 1, "Masculino", "Ana", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9881), null },
                    { 31, "Muñoz", 4, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9883), null, "37", 1, "Femenino", "Mariana", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9883), null },
                    { 32, "Romero", 6, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9884), null, "26", 1, "Masculino", "Diego", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9885), null },
                    { 33, "Pérez", 6, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9886), null, "46", 1, "Femenino", "Isabella", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9886), null },
                    { 34, "Romero", 7, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9888), null, "26", 1, "Masculino", "Carlos", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9888), null },
                    { 35, "Gómez", 7, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9889), null, "26", 1, "Masculino", "Mateo", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9890), null },
                    { 36, "Gómez", 7, "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9891), null, "20", 1, "Femenino", "Samuel", "", new DateTime(2024, 2, 15, 4, 57, 46, 380, DateTimeKind.Utc).AddTicks(9891), null }
                });

            migrationBuilder.InsertData(
                table: "Solicitud",
                columns: new[] { "Id", "ClienteId", "CreatedOn", "CreatedUserId", "FechaFin", "FechaInicio", "RentaId", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8225), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8226), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8227), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8225), null },
                    { 2, 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8228), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8229), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8230), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8229), null },
                    { 3, 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8231), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8231), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8232), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8231), null },
                    { 4, 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8232), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8233), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8234), 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8233), null },
                    { 5, 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8234), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8235), 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8234), null },
                    { 6, 6, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8236), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8237), 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8236), null },
                    { 7, 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8238), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8239), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8239), 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8238), null },
                    { 8, 8, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8240), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8241), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8241), 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8240), null },
                    { 9, 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8241), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8243), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8242), null },
                    { 10, 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8243), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8244), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8244), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8244), null },
                    { 11, 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8245), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8246), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8245), null },
                    { 12, 12, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8247), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8248), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8248), 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8247), null },
                    { 13, 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8249), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8250), 15, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8249), null },
                    { 14, 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8250), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8251), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8252), 18, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8251), null },
                    { 15, 20, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8252), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8253), 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8253), null },
                    { 16, 22, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8254), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8255), 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8254), null },
                    { 17, 24, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8256), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8257), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8256), null },
                    { 18, 26, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8258), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8259), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8258), null },
                    { 19, 27, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8260), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8260), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8261), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8260), null },
                    { 20, 28, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8262), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8262), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8263), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8262), null },
                    { 21, 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8263), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8264), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8264), 19, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8264), null },
                    { 22, 34, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8265), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8266), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8266), 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8265), null },
                    { 23, 21, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8267), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8268), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8268), 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8267), null },
                    { 24, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8269), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8269), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8270), 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8269), null },
                    { 25, 31, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8270), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8271), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8272), 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8271), null },
                    { 26, 33, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8272), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8273), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8273), 8, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8272), null },
                    { 27, 34, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8274), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8275), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8275), 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8274), null },
                    { 28, 35, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8276), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8277), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8277), 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8276), null },
                    { 29, 36, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8277), null, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8279), 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8278), null }
                });

            migrationBuilder.InsertData(
                table: "Reserva",
                columns: new[] { "Id", "CreatedOn", "CreatedUserId", "EstadoId", "FacturaId", "SolucitudId", "UpdatedOn", "UpdatedUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8796), null, 1, 1, 1, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8797), null },
                    { 2, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8798), null, 1, 2, 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8799), null },
                    { 3, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8800), null, 1, 3, 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8800), null },
                    { 4, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8801), null, 1, 4, 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8801), null },
                    { 5, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8802), null, 1, 5, 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8802), null },
                    { 6, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8803), null, 2, 6, 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8803), null },
                    { 7, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8804), null, 4, 7, 12, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8805), null },
                    { 8, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8806), null, 3, 8, 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8806), null },
                    { 9, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8807), null, 3, 9, 15, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8807), null },
                    { 10, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8808), null, 2, 10, 17, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8808), null },
                    { 11, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8809), null, 4, 11, 20, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8809), null },
                    { 12, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8810), null, 2, 12, 21, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8810), null },
                    { 13, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8811), null, 3, 13, 23, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8811), null },
                    { 14, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8812), null, 2, 14, 25, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8812), null },
                    { 15, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8847), null, 3, 15, 27, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8848), null },
                    { 16, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8849), null, 4, 16, 28, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8849), null },
                    { 17, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8850), null, 1, 17, 29, new DateTime(2024, 2, 15, 4, 57, 46, 381, DateTimeKind.Utc).AddTicks(8850), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reserva",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Factura",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Solicitud",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedioPago",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedioPago",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedioPago",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MedioPago",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MedioPago",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Renta",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehiculo",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pais",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
