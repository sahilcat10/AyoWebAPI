using AYOAPI.Controllers;
using AYOAPI.Data;
using AYOAPI.Model;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AYOAPITest
{
    public class ConversionControllerTest
    {
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; }
        public static string connectionString = "Server=MSI;Database=AYODb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;";

        ConversionController _controller;
        IUnitConversionService _unitConversionService;

        static ConversionControllerTest()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        public ConversionControllerTest()
        {
            var dbContext = new ApplicationDbContext(dbContextOptions);
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