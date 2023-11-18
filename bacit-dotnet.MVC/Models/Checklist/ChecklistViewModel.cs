using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace bacit_dotnet.MVC.Models.Checklist
{
    public class ChecklistViewModel
    {
        public int SelectedOrderId { get; set; }
        public IEnumerable<SelectListItem> OrderIds { get; set; }
      
        public List<ChecklistItemViewModel> ChecklistItems { get; set; }
        public List<string> Statuses { get; set; } 
    }


}


