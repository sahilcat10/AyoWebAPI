using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AYOAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitConversionRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetricUnitName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImperialUnitName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MetricToImperialRate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImperialToMetricRate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CratedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitConversionRates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UnitConversionRates",
                columns: new[] { "Id", "CratedBy", "CreatedAt", "ImperialToMetricRate", "ImperialUnitName", "MetricToImperialRate", "MetricUnitName", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4140), "I * 1.60935", "mile", "M * 0.62136", "kilometer", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4150), "Admin" },
                    { 2, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4152), "I * 0.0003048", "foot", "M * 3280.839895", "kilometer", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4152), "Admin" },
                    { 3, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4153), "I * 0.3048", "foot", "M * 3.28083", "meter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4153), "Admin" },
                    { 4, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4154), "I * 0.0254", "inch", "M * 39.37007", "meter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4154), "Admin" },
                    { 5, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4155), "I * 2.54", "inch", "M * 0.39370", "centimeter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4155), "Admin" },
                    { 6, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4156), "I * 25.4", "inch", "M * 0.03937", "millimeter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4156), "Admin" },
                    { 7, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4157), "I * 0.94635", "quart", "M * 1.05668", "liter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4158), "Admin" },
                    { 8, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4158), "I * 3.78541", "gallon", "M * 0.26417", "liter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4159), "Admin" },
                    { 9, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4159), "I * 236.588125", "cup", "M * 0.00422", "milliliter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4160), "Admin" },
                    { 10, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4160), "I * 29.57351", "ounce", "M * 0.03381", "milliliter", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4161), "Admin" },
                    { 11, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4161), "(I - 32) * 5/9", "fahrenheit", "(M * 9/5) + 32", "celsius", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4162), "Admin" },
                    { 12, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4162), "I * 1000", "ton", "M * 0.001", "kilogram", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4163), "Admin" },
                    { 13, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4164), "I * 0.45359", "pound", "M * 2.20462", "kilogram", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4164), "Admin" },
                    { 14, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4165), "I * 28.3495", "ounce", "M * 0.03527", "gram", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4165), "Admin" },
                    { 15, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4166), "I * 453.592", "pound", "M * 0.002205", "gram", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4166), "Admin" },
                    { 16, "Admin", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4167), "I * 28349.5", "ounce", "M * 0.000035", "milligram", new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4167), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitConversionRates");
        }
    }
}
