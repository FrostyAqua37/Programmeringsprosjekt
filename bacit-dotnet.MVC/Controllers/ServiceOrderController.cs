using bacit_dotnet.MVC.Models.ServiceOrdre;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Xml.Linq;

namespace bacit_dotnet.MVC.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class ServiceOrderController : Controller
    {

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult Checklist()
        {
            return View();
        }

        public IActionResult WorkDocument()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }





        [HttpPost]
        [HttpGet]
        public IActionResult Index(string FirstName, string LastName, string PhoneNumber, string Email, string ProductName, string ProductType, string PreferredTimePeriod, string Comment)
        {
            var model = new Serviceform
            {
                serviceform = new List<Serviceform> 
                {
                    new Serviceform
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        PhoneNumber = PhoneNumber,
                        Email = Email,
                        ProductName = ProductName,
                        ProductType = ProductType,
                        PreferredTimePeriod = PreferredTimePeriod,
                        Comment = Comment
                       
                    }
                }
            };
            return View(model);
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Details(string FirstName, string LastName, string PhoneNumber, string Email, string ProductName, string ProductType, string PreferredTimePeriod, string Comment)
        {
            var model = List<Serviceform>
            {
                serviceform = new List<Serviceform>
                {
                    new Serviceform
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        PhoneNumber = PhoneNumber,
                        Email = Email,
                        ProductName = ProductName,
                        ProductType = ProductType,
                        PreferredTimePeriod = PreferredTimePeriod,
                        Comment = Comment
                    }
                }
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult WorkDocument(string Week, string Order, string Inquiry, bool CaseCompleted, string CustomerInfo, DateTime? PlannedDelivery, DateTime? ProductReceivedDate, DateTime? AgreedCompletionDate, DateTime? ServiceCompletedDate, string ServiceHours, bool HasOrderNumber, bool HasServiceForm)
        {
            var model = new Serviceform
            { 
                workDocument = new List<Serviceform>
                {
                    new Serviceform
                    {
                    Week = Week,
                    Order = Order,
                    Inquiry = Inquiry,
                    CaseCompleted = CaseCompleted,
                    CustomerInfo = CustomerInfo,
                    PlannedDelivery = PlannedDelivery,
                    ProductReceivedDate = ProductReceivedDate,
                    AgreedCompletionDate = AgreedCompletionDate,
                    ServiceCompletedDate = ServiceCompletedDate,
                    ServiceHours = ServiceHours,
                    HasOrderNumber = HasOrderNumber,
                    HasServiceForm = HasServiceForm
                    }
                }
            };
            return View(model);
        }



        [HttpPost]
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Mekanisk(string? mekanisk1, string? mekanisk2, string? mekanisk3, string? mekanisk4, string? mekanisk5, string? mekanisk6, string? mekanisk7, string? mekanisk8)
        {
            var model = new ChecklistViewModel
            {
                mekanisk1 = mekanisk1,
                mekanisk2 = mekanisk2,
                mekanisk3 = mekanisk3,
                mekanisk4 = mekanisk4,
                mekanisk5 = mekanisk5,
                mekanisk6 = mekanisk6,
                mekanisk7 = mekanisk7,
                mekanisk8 = mekanisk8
            };

            return View(model);
        }

        public IActionResult Elektro(string? elektro1, string? elektro2, string? elektro3)
        {
            var model = new ChecklistViewModel
            {
                elektro1 = elektro1,
                elektro2 = elektro2,
                elektro3 = elektro3
            };
            return View("Index");
        }

        public IActionResult Hydraulikk(string? hydraulikk1, string? hydraulikk2, string? hydraulikk3, string? hydraulikk4, string? hydraulikk5, string? hydraulikk6, string? hydraulikk7)
        {
            var model = new ChecklistViewModel
            {
                hydraulikk1 = hydraulikk1,
                hydraulikk2 = hydraulikk2,
                hydraulikk3 = hydraulikk3,
                hydraulikk4 = hydraulikk4,
                hydraulikk5 = hydraulikk5,
                hydraulikk6 = hydraulikk6,
                hydraulikk7 = hydraulikk7
            };
            return View(model);
        }

        public IActionResult Trykksettinger(string? XXBar1)
        {
            var model = new ChecklistViewModel
            {
                XXBar1 = XXBar1
            };
            return View("Index");
        }

        public IActionResult Funksjonstest(string? funksjonstest1, string? funksjonstest2, string? funksjonstest3)
        {
            var model = new ChecklistViewModel
            {
                funksjonstest1 = funksjonstest1,
                funksjonstest2 = funksjonstest2,
                funksjonstest3 = funksjonstest3
            };
            return View("Index");
        }

        
    }
}
