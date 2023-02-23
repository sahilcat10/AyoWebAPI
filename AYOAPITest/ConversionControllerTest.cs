using AYOAPI.Controllers;
using AYOAPI.Data;
using AYOAPI.Model;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AYOAPITest
{
    public class ConversionControllerTest
    {
        public IConfigurationRoot Configuration { get; set; }

        ConversionController _controller;
        IUnitConversionService _unitConversionService;

        public ConversionControllerTest()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("AYOConnection"));
            var dbContext = new ApplicationDbContext(optionsBuilder.Options);

            _unitConversionService = new UnitConversionService(dbContext);
            _controller = new ConversionController(_unitConversionService);
        }

        [Fact]
        public async void Get_ReturnsOKResult()
        {
            // Arrange
            var fromUnit = "kilogram";
            var toUnit = "pound";
            var val = "1";

            // Act
            var okResult = await _controller.Get(fromUnit, toUnit, val);
            
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public async void Get_ReturnsNotFoundResult()
        {
            // Arrange
            var fromUnit = "kilograms";
            var toUnit = "pounds";
            var val = "1";

            // Act
            var notFoundResult = await _controller.Get(fromUnit, toUnit, val);

            // Assert
            Assert.IsType<NotFoundObjectResult>(notFoundResult);
        }

        [Fact]
        public async void Get_ReturnsRightValue()
        {
            // Arrange
            var fromUnit = "kilogram";
            var toUnit = "pound";
            var val = "1";

            var output = "2.20";

            // Act
            var okResult = await _controller.Get(fromUnit, toUnit, val);

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(output, (((ObjectResult)okResult).Value as SuccessConversionObject).ConvertedValue);
        }
    }
}