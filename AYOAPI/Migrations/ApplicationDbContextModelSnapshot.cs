﻿// <auto-generated />
using System;
using AYOAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AYOAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AYOAPI.Model.UnitConversionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CratedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImperialToMetricRate")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImperialUnitName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MetricToImperialRate")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MetricUnitName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("UnitConversionRates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4140),
                            ImperialToMetricRate = "I * 1.60935",
                            ImperialUnitName = "mile",
                            MetricToImperialRate = "M * 0.62136",
                            MetricUnitName = "kilometer",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4150),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4152),
                            ImperialToMetricRate = "I * 0.0003048",
                            ImperialUnitName = "foot",
                            MetricToImperialRate = "M * 3280.839895",
                            MetricUnitName = "kilometer",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4152),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4153),
                            ImperialToMetricRate = "I * 0.3048",
                            ImperialUnitName = "foot",
                            MetricToImperialRate = "M * 3.28083",
                            MetricUnitName = "meter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4153),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 4,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4154),
                            ImperialToMetricRate = "I * 0.0254",
                            ImperialUnitName = "inch",
                            MetricToImperialRate = "M * 39.37007",
                            MetricUnitName = "meter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4154),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 5,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4155),
                            ImperialToMetricRate = "I * 2.54",
                            ImperialUnitName = "inch",
                            MetricToImperialRate = "M * 0.39370",
                            MetricUnitName = "centimeter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4155),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 6,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4156),
                            ImperialToMetricRate = "I * 25.4",
                            ImperialUnitName = "inch",
                            MetricToImperialRate = "M * 0.03937",
                            MetricUnitName = "millimeter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4156),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 7,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4157),
                            ImperialToMetricRate = "I * 0.94635",
                            ImperialUnitName = "quart",
                            MetricToImperialRate = "M * 1.05668",
                            MetricUnitName = "liter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4158),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 8,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4158),
                            ImperialToMetricRate = "I * 3.78541",
                            ImperialUnitName = "gallon",
                            MetricToImperialRate = "M * 0.26417",
                            MetricUnitName = "liter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4159),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 9,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4159),
                            ImperialToMetricRate = "I * 236.588125",
                            ImperialUnitName = "cup",
                            MetricToImperialRate = "M * 0.00422",
                            MetricUnitName = "milliliter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4160),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 10,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4160),
                            ImperialToMetricRate = "I * 29.57351",
                            ImperialUnitName = "ounce",
                            MetricToImperialRate = "M * 0.03381",
                            MetricUnitName = "milliliter",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4161),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 11,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4161),
                            ImperialToMetricRate = "(I - 32) * 5/9",
                            ImperialUnitName = "fahrenheit",
                            MetricToImperialRate = "(M * 9/5) + 32",
                            MetricUnitName = "celsius",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4162),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 12,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4162),
                            ImperialToMetricRate = "I * 1000",
                            ImperialUnitName = "ton",
                            MetricToImperialRate = "M * 0.001",
                            MetricUnitName = "kilogram",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4163),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 13,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4164),
                            ImperialToMetricRate = "I * 0.45359",
                            ImperialUnitName = "pound",
                            MetricToImperialRate = "M * 2.20462",
                            MetricUnitName = "kilogram",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4164),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 14,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4165),
                            ImperialToMetricRate = "I * 28.3495",
                            ImperialUnitName = "ounce",
                            MetricToImperialRate = "M * 0.03527",
                            MetricUnitName = "gram",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4165),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 15,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4166),
                            ImperialToMetricRate = "I * 453.592",
                            ImperialUnitName = "pound",
                            MetricToImperialRate = "M * 0.002205",
                            MetricUnitName = "gram",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4166),
                            ModifiedBy = "Admin"
                        },
                        new
                        {
                            Id = 16,
                            CratedBy = "Admin",
                            CreatedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4167),
                            ImperialToMetricRate = "I * 28349.5",
                            ImperialUnitName = "ounce",
                            MetricToImperialRate = "M * 0.000035",
                            MetricUnitName = "milligram",
                            ModifiedAt = new DateTime(2023, 2, 23, 13, 53, 40, 181, DateTimeKind.Local).AddTicks(4167),
                            ModifiedBy = "Admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
