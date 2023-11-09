using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class ChecklistController : Controller
{
    [HttpPost]
    public IActionResult Checklist()
    {
        return View("index");
    }
}
