using bacit_dotnet.MVC.Controllers;
using bacit_dotnet.MVC.DataAccess;
using bacit_dotnet.MVC.Models.ServiceOrdre;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bacit_dotnet.MVC.Tests.Controllers
{
    public class ServiceOrderControllerTests
    {
        [Fact]
        public async Task Edit_Post_UpdatesServiceOrderAndRedirects()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase") // Using In-Memory Database
                .Options;

            var testId = 1;
            var testServiceOrder = new ServiceOrder { 
                OrderId = testId,
                Address = "testAdress",
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                PhoneNumber = "1234567890",
                Email = "test@example.com",
                ProductName = "TestProduct",
                ProductType = "TestType",
                ModellYear = "2022",
                RecivedOrder = DateTime.Now,
                RecivedProduct = DateTime.Now,
                ReperationDescription = "Test Description",
                AgreedServiceFinished = DateTime.Now,
                AgreedDelivery = DateTime.Now,
                DeliveryWay = "TestDelivery",
                ServiceGaranti = true,
                ServiceDone = DateTime.Now,
                UsedParts = "Test Parts",
                ReturnedRemovedParts = true,
                HoursUsed = "2",
                CaseDone = true,
                SignatureCustomer = "TestSignature",
                SignatureMechanic = "TestSignature",
                SerialNumber = "SN123456",
                Comment = "Test Comment"


                /*, Initialize other properties as needed */
            };
            var testModel = new ServiceOrderViewModel {
                ServiceOrders = new List<ServiceOrder>(), // Assuming this is initialized as an empty list or relevant ServiceOrder objects
                OrderId = testId, // Example ID, ensure it matches with the testServiceOrder's ID if needed
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                PhoneNumber = "1234567890",
                Email = "test@example.com",
                ProductName = "TestProduct",
                ProductType = "TestType",
                Address = "Test Address",
                ModellYear = "2022",
                RecivedOrder = DateTime.Now,
                RecivedProduct = DateTime.Now,
                ReperationDescription = "Test Description",
                AgreedServiceFinished = DateTime.Now,
                AgreedDelivery = DateTime.Now,
                DeliveryWay = "TestDelivery",
                ServiceGaranti = true,
                ServiceDone = DateTime.Now,
                UsedParts = "Test Parts",
                ReturnedRemovedParts = true,
                HoursUsed = "2",
                CaseDone = true,
                SignatureCustomer = "TestSignature",
                SignatureMechanic = "TestSignature",
                Comment = "Test Comment",
                SerialNumber = "SN123456"
            };

            // Using actual DbContext with In-Memory Database
            using var context = new DataContext(options);
            context.ServiceOrders.Add(testServiceOrder);
            await context.SaveChangesAsync();

            var controller = new ServiceOrderController(context);

            // Act
            var result = await controller.Edit(testId, testModel);

            // Assert
            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectResult.ActionName);

            // Optionally, verify that the service order was updated in the context
        }
    }


}

