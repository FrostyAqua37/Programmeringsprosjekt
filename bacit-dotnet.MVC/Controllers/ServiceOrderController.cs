using bacit_dotnet.MVC.DataAccess;
using bacit_dotnet.MVC.Models.ServiceOrdre;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web;
using System.Xml.Linq;

namespace bacit_dotnet.MVC.Controllers
{
    public class ServiceOrderController : Controller
    {

        private readonly DataContext _context;

        public ServiceOrderController(DataContext context)
        {
            _context = context;
        }

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

        public IActionResult Success()
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
      
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var serviceOrders = await _context.ServiceOrders.ToListAsync();
            var viewModel = new ServiceOrderViewModel
            {
                ServiceOrders = serviceOrders // Assuming Serviceform and ServiceOrder have the same properties
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(ServiceOrderViewModel model) {
            if(ModelState.IsValid)
            {
                var s = "ineedabreakpoint";

            }
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateServiceOrder(ServiceOrder serviceOrder)
        {
            if (ModelState.IsValid)
            {

                _context.ServiceOrders.Add(serviceOrder);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index"); // Redirect to a success page or another appropriate action
            }

            // If we got this far, something failed; redisplay the form
            return View("Create", serviceOrder);
        }

 

    }
}
