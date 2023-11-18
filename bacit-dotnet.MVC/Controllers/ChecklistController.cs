using bacit_dotnet.MVC.DataAccess;
using bacit_dotnet.MVC.Models.Checklist;
using bacit_dotnet.MVC.Models.ChecklistItem;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bacit_dotnet.MVC.Controllers
{
    public class ChecklistController : Controller
    {
        private readonly DataContext _context;

        public ChecklistController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var viewModel = new ChecklistViewModel
            {
                OrderIds = await _context.ServiceOrders
                    .Select(o => new SelectListItem { Value = o.OrderId.ToString(), Text = o.OrderId.ToString() })
                    .ToListAsync(),
                ChecklistItems = await _context.ChecklistItems
                    .Select(ci => new ChecklistItemViewModel
                    {
                        Kategori = ci.Kategori,
                        Sjekkpunkt = ci.Sjekkpunkt,
                        Status = ci.Status,
                        SelectedOrderId = ci.OrderId // Assuming you want to include this
                    })
                    .ToListAsync()
            };

            return View("Checklist", viewModel);
        }


        public IActionResult CreateChecklist()
        {
            var viewModel = new ChecklistViewModel
            {
                // Initialize your ViewModel here
                // For example, load OrderIds or any other necessary data
            };

            return View("Checklist", viewModel); // Use the same view as the checklist
        }

        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveNewChecklist(ChecklistItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Create a ChecklistItem and populate its properties
                var checklistItem = new ChecklistItem
                {
                    OrderId = viewModel.SelectedOrderId,
                    Kategori = viewModel.Kategori,
                    Sjekkpunkt = viewModel.Sjekkpunkt,
                    Status = viewModel.Status
                    // Additional properties
                };

                // Add the checklistItem to your database context and save changes
                _context.ChecklistItems.Add(checklistItem);
                _context.SaveChanges();

                // Redirect or return a success message
                TempData["SuccessMessage"] = "Checklist item created successfully.";
                return RedirectToAction("Index"); // Replace "Index" with the action you want to redirect to.
            }

            // If ModelState is not valid, return to the form with validation errors
            return View(viewModel);
        }






        // Helper methods to get Kategori and Sjekkpunkt based on the index:
        private string GetKategoriForIndex(int index)
        {
            // This should match the order of the items in your view.
            var kategorier = new[] { "Mekanisk", "Hydraulisk", "Elektro", "Trykk settinger", "Funksjonstest",/* other categories */ };
            return kategorier[index];
        }

        private string GetSjekkpunktForIndex(int index)
        {
            // This should match the order of the items in your view.
            var sjekkpunkter = new[] { 
             //Mekanisk
             "Sjekk clutch lameller for slitasje",
             "Sjekk bremser. Bånd/Pal",
             "Sjekk lager for trommel",
             "Sjekk PTO og opplagring",
             "Sjekk kjedestrammer",
             "Sjekk wire",
             "Sjekk pinion lager",
             "Sjekk kile på kjedehjul",

             //Hydraulisk
             "Sjekk hydraulikk sylinder for lekkasje",
             "Sjekk slanger for skader og lekkasje",
             "Test hydraulikkblokk i testbenk",
             "Skift olje i tank",
             "Skift olje på gir boks",
             "Sjekk Ringsylinder åpne og skift tetninger",
             "Sjekk bremse sylinder åpne og skift tetninger",

             //Elektro
             "Sjekk ledningsnett på vinsj",
             "Sjekk og test radio",
             "Sjekk og test knappekasse",

             //Trykk settinger
             "xx-Bar",

             //Funksjonstest
             "Test vinsj og kjør alle funksjoner",
             "Trekkraft KN",
             "Bremse kraft KN",
            };
            return sjekkpunkter[index];
        }
    }
}