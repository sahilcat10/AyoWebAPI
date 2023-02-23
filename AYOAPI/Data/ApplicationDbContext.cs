using AYOAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AYOAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitConversionRate>().HasData(
                new UnitConversionRate { 
                    Id = 1, 
                    MetricUnitName= "kilometer", 
                    ImperialUnitName= "mile", 
                    MetricToImperialRate= "M * 0.62136", 
                    ImperialToMetricRate= "I * 1.60935", 
                    CratedBy="Admin",
                    CreatedAt=DateTime.Now, 
                    ModifiedBy="Admin", 
                    ModifiedAt=DateTime.Now 
                },
                new UnitConversionRate
                {
                    Id = 2,
                    MetricUnitName = "kilometer",
                    ImperialUnitName = "foot",
                    MetricToImperialRate = "M * 3280.839895",
                    ImperialToMetricRate = "I * 0.0003048",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 3,
                    MetricUnitName = "meter",
                    ImperialUnitName = "foot",
                    MetricToImperialRate = "M * 3.28083",
                    ImperialToMetricRate = "I * 0.3048",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 4,
                    MetricUnitName = "meter",
                    ImperialUnitName = "inch",
                    MetricToImperialRate = "M * 39.37007",
                    ImperialToMetricRate = "I * 0.0254",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 5,
                    MetricUnitName = "centimeter",
                    ImperialUnitName = "inch",
                    MetricToImperialRate = "M * 0.39370",
                    ImperialToMetricRate = "I * 2.54",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 6,
                    MetricUnitName = "millimeter",
                    ImperialUnitName = "inch",
                    MetricToImperialRate = "M * 0.03937",
                    ImperialToMetricRate = "I * 25.4",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 7,
                    MetricUnitName = "liter",
                    ImperialUnitName = "quart",
                    MetricToImperialRate = "M * 1.05668",
                    ImperialToMetricRate = "I * 0.94635",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 8,
                    MetricUnitName = "liter",
                    ImperialUnitName = "gallon",
                    MetricToImperialRate = "M * 0.26417",
                    ImperialToMetricRate = "I * 3.78541",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 9,
                    MetricUnitName = "milliliter",
                    ImperialUnitName = "cup",
                    MetricToImperialRate = "M * 0.00422",
                    ImperialToMetricRate = "I * 236.588125",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 10,
                    MetricUnitName = "milliliter",
                    ImperialUnitName = "ounce",
                    MetricToImperialRate = "M * 0.03381",
                    ImperialToMetricRate = "I * 29.57351",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 11,
                    MetricUnitName = "celsius",
                    ImperialUnitName = "fahrenheit",
                    MetricToImperialRate = "(M * 9/5) + 32",
                    ImperialToMetricRate = "(I - 32) * 5/9",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 12,
                    MetricUnitName = "kilogram",
                    ImperialUnitName = "ton",
                    MetricToImperialRate = "M * 0.001",
                    ImperialToMetricRate = "I * 1000",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 13,
                    MetricUnitName = "kilogram",
                    ImperialUnitName = "pound",
                    MetricToImperialRate = "M * 2.20462",
                    ImperialToMetricRate = "I * 0.45359",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 14,
                    MetricUnitName = "gram",
                    ImperialUnitName = "ounce",
                    MetricToImperialRate = "M * 0.03527",
                    ImperialToMetricRate = "I * 28.3495",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 15,
                    MetricUnitName = "gram",
                    ImperialUnitName = "pound",
                    MetricToImperialRate = "M * 0.002205",
                    ImperialToMetricRate = "I * 453.592",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                },
                new UnitConversionRate
                {
                    Id = 16,
                    MetricUnitName = "milligram",
                    ImperialUnitName = "ounce",
                    MetricToImperialRate = "M * 0.000035",
                    ImperialToMetricRate = "I * 28349.5",
                    CratedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedBy = "Admin",
                    ModifiedAt = DateTime.Now
                }
                );
        }

        public DbSet<UnitConversionRate> UnitConversionRates { get; set; }
    }
}
