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
                        SelectedOrderId = ci.OrderId 
                    })
                    .ToListAsync()
            };

            return View("Checklist", viewModel);
        }


        public IActionResult CreateChecklist()
        {
            var viewModel = new ChecklistViewModel
            {
            
            };

            return View("Checklist", viewModel); 
        }

        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult SaveNewChecklist(ChecklistItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Sjekkliste initialisert
                var checklistItem = new ChecklistItem
                {
                    OrderId = viewModel.SelectedOrderId,
                    Kategori = viewModel.Kategori,
                    Sjekkpunkt = viewModel.Sjekkpunkt,
                    Status = viewModel.Status
                };

                // Legger til sjekkliste til database og lagrer 
                _context.ChecklistItems.Add(checklistItem);
                _context.SaveChanges();

                // Redirect or return a success message
                TempData["SuccessMessage"] = "Checklist item created successfully.";
                return RedirectToAction("Index"); 
            }

            // If ModelState is not valid, return to the form with validation errors
            return View(viewModel);
        }






        
        private string GetKategoriForIndex(int index)
        {
            var kategorier = new[] { "Mekanisk", "Hydraulisk", "Elektro", "Trykk settinger", "Funksjonstest",/* other categories */ };
            return kategorier[index];
        }

        private string GetSjekkpunktForIndex(int index)
        {
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