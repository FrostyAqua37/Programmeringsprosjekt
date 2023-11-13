using Microsoft.AspNetCore.Mvc;

namespace bacit_dotnet.MVC.Models.Checklist
{
    public class Checklist : Controller
    {
        public int OrderId { get; set; }
        public string? Kategorier { get; set; }
        public string? Sjekkpunkter { get; set; }
        public bool OK { get; set; }
        public bool BørSkiftes { get; set; }
        public bool Defekt { get; set; }
    }
}
    

