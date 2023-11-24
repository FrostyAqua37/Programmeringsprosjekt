using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bacit_dotnet.MVC.Controllers;
using bacit_dotnet.MVC.DataAccess;
using bacit_dotnet.MVC.Models.Checklist;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace bacit_dotnet.MVC.Tests.Controllers
{
    public class SimpleTempDataProvider : ITempDataProvider
    {
        public IDictionary<string, object> LoadTempData(HttpContext context)
        {
            return new Dictionary<string, object>();
        }

        public void SaveTempData(HttpContext context, IDictionary<string, object> values)
        {
            // Method intentionally left empty.
        }
    }

    public class ChecklistControllerTests
    {
        [Fact]
        public void SaveNewChecklist_SavesDataAndRedirects()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Initialize TempData
            var tempData = new TempDataDictionary(new DefaultHttpContext(), new SimpleTempDataProvider());

            using var context = new DataContext(options);
            var controller = new ChecklistController(context)
            {
                TempData = tempData
            };

            var testViewModel = new ChecklistItemViewModel
            {
                // Initialize properties as needed for the test
            };

            // Act
            var result = controller.SaveNewChecklist(testViewModel);

            // Assert
            // Verify the expected behavior of the SaveNewChecklist method
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
            // Additional assertions as needed
        }

        [Fact]
        public void CreateChecklist_ReturnsView()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Initialize TempData
            var tempData = new TempDataDictionary(new DefaultHttpContext(), new SimpleTempDataProvider());

            using var context = new DataContext(options);
            var controller = new ChecklistController(context)
            {
                TempData = tempData
            };

            // Act
            var result = controller.CreateChecklist();

            // Assert
            // Verify that the action returns a view result
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Checklist", viewResult.ViewName); // Ensure it returns the "Checklist" view
        }
    }
}


