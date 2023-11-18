namespace bacit_dotnet.MVC.Models.Checklist
{
    public class ChecklistItemViewModel
    {
        public string Kategori { get; set; } = string.Empty;
        public string Sjekkpunkt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        
        public int SelectedOrderId { get; set; }// "OK", "BørSkiftes", "Defekt"
    }

}
