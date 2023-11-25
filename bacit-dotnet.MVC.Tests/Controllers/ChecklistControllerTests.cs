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
                // Initialize
            };

            // Act
            var result = controller.SaveNewChecklist(testViewModel);

            // Assert
            // Verify forventet funksjon av SaveNewChecklist metoden
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);
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
            // Verifiser at action returnerer et view resultat
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal("Checklist", viewResult.ViewName); // Forsikre om at det returnerer "Checklist" view
        }
    }
}


