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

        public async Task<ActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var serviceOrder = await _context.ServiceOrders.AsNoTracking().FirstOrDefaultAsync(so => so.OrderId == id.Value);
            if (serviceOrder == null)
            {
                return NotFound();
            }

            var model = new ServiceOrderViewModel
            {
                OrderId = serviceOrder.OrderId,
                FirstName = serviceOrder.FirstName,
                LastName = serviceOrder.LastName,
                PhoneNumber = serviceOrder.PhoneNumber,
                Email = serviceOrder.Email,
                Address = serviceOrder.Address,
                ProductName = serviceOrder.ProductName,
                ProductType = serviceOrder.ProductType,
                SerialNumber = serviceOrder.SerialNumber,
                ModellYear = serviceOrder.ModellYear,
                RecivedOrder = serviceOrder.RecivedOrder,
                RecivedProduct = serviceOrder.RecivedProduct,
                ReperationDescription = serviceOrder.ReperationDescription,
                AgreedServiceFinished = serviceOrder.AgreedServiceFinished,
                AgreedDelivery = serviceOrder.AgreedDelivery,
                DeliveryWay = serviceOrder.DeliveryWay,
                ServiceGaranti = serviceOrder.ServiceGaranti,
                ServiceDone = serviceOrder.ServiceDone,
                UsedParts = serviceOrder.UsedParts,
                ReturnedRemovedParts = serviceOrder.ReturnedRemovedParts,
                HoursUsed = serviceOrder.HoursUsed,
                CaseDone = serviceOrder.CaseDone,
                SignatureCustomer = serviceOrder.SignatureCustomer,
                SignatureMechanic = serviceOrder.SignatureMechanic,
                Comment = serviceOrder.Comment,

            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ServiceOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                {
                    var serviceOrder = await _context.ServiceOrders.FindAsync(id);
                    if (serviceOrder == null)
                    {
                        return NotFound();
                    }

                    serviceOrder.OrderId = model.OrderId;
                    serviceOrder.FirstName = model.FirstName;
                    serviceOrder.LastName = model.LastName;
                    serviceOrder.PhoneNumber = model.PhoneNumber;
                    serviceOrder.Email = model.Email;
                    serviceOrder.Address = model.Address;
                    serviceOrder.ProductName = model.ProductName;
                    serviceOrder.ProductType = model.ProductType;
                    serviceOrder.SerialNumber = model.SerialNumber;
                    serviceOrder.ModellYear = model.ModellYear;
                    serviceOrder.RecivedOrder = model.RecivedOrder;
                    serviceOrder.RecivedProduct = model.RecivedProduct;
                    serviceOrder.ReperationDescription = model.ReperationDescription;
                    serviceOrder.AgreedServiceFinished = model.AgreedServiceFinished;
                    serviceOrder.AgreedDelivery = model.AgreedDelivery;
                    serviceOrder.DeliveryWay = model.DeliveryWay;
                    serviceOrder.ServiceGaranti = model.ServiceGaranti;
                    serviceOrder.ServiceDone = model.ServiceDone;
                    serviceOrder.UsedParts = model.UsedParts;
                    serviceOrder.ReturnedRemovedParts = model.ReturnedRemovedParts;
                    serviceOrder.HoursUsed = model.HoursUsed;
                    serviceOrder.CaseDone = model.CaseDone;
                    serviceOrder.SignatureCustomer = model.SignatureCustomer;
                    serviceOrder.SignatureMechanic = model.SignatureMechanic;
                    serviceOrder.Comment = model.Comment;

                    try
                    {
                        _context.Update(serviceOrder);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!await ServiceOrderExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return RedirectToAction("Index");
                }

                return View(model);
            }
            return View(model);
        }

        private async Task<bool> ServiceOrderExists(int id)
        {
            return await _context.ServiceOrders.AnyAsync(e => e.OrderId == id);
        }


        public async Task<IActionResult> Details(int? id)
        {
            var serviceOrder = await _context.ServiceOrders
                                             .AsNoTracking()
                                             .FirstOrDefaultAsync(so => so.OrderId == id);

            if (serviceOrder == null)
            {
                return NotFound();
            }

            var model = new ServiceOrderViewModel
            {
                OrderId = serviceOrder.OrderId,
                FirstName = serviceOrder.FirstName,
                LastName = serviceOrder.LastName,
                PhoneNumber = serviceOrder.PhoneNumber,
                Email = serviceOrder.Email,
                Address = serviceOrder.Address,
                ProductName = serviceOrder.ProductName,
                ProductType = serviceOrder.ProductType,
                SerialNumber = serviceOrder.SerialNumber,
                ModellYear = serviceOrder.ModellYear,
                RecivedOrder = serviceOrder.RecivedOrder,
                RecivedProduct = serviceOrder.RecivedProduct,
                ReperationDescription = serviceOrder.ReperationDescription,
                AgreedServiceFinished = serviceOrder.AgreedServiceFinished,
                AgreedDelivery = serviceOrder.AgreedDelivery,
                DeliveryWay = serviceOrder.DeliveryWay,
                ServiceGaranti = serviceOrder.ServiceGaranti,
                ServiceDone = serviceOrder.ServiceDone,
                UsedParts = serviceOrder.UsedParts,
                ReturnedRemovedParts = serviceOrder.ReturnedRemovedParts,
                HoursUsed = serviceOrder.HoursUsed,
                CaseDone = serviceOrder.CaseDone,
                SignatureCustomer = serviceOrder.SignatureCustomer,
                SignatureMechanic = serviceOrder.SignatureMechanic,
                Comment = serviceOrder.Comment,
            };

            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceOrder = await _context.ServiceOrders
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (serviceOrder == null)
            {
                return NotFound();
            }

            var viewModel = new ServiceOrderViewModel
            {
                OrderId = serviceOrder.OrderId,
                FirstName = serviceOrder.FirstName, LastName = serviceOrder.LastName,
                PhoneNumber = serviceOrder.PhoneNumber,
                ProductType = serviceOrder.ProductType,
                ReperationDescription = serviceOrder.ReperationDescription,

            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var serviceOrder = await _context.ServiceOrders.FindAsync(id);
            if (serviceOrder == null)

            {
                return NotFound();
            }

            _context.ServiceOrders.Remove(serviceOrder);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); 
        }



        [HttpPost]
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var serviceOrders = await _context.ServiceOrders.ToListAsync();
            var viewModel = new ServiceOrderViewModel
            {
                ServiceOrders = serviceOrders
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

                return RedirectToAction("Index"); 
            }

            return View("Create", serviceOrder);
        }

 

    }
}
