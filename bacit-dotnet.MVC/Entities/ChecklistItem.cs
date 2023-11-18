using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bacit_dotnet.MVC.Models.ServiceOrdre;


namespace bacit_dotnet.MVC.Models.ChecklistItem
{
    [Table("CheckListItems")]
    public class ChecklistItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChecklistItemId { get; set; } // Primary Key

        [ForeignKey("ServiceOrder")]
        public int OrderId { get; set; } // Foreign Key

        public string Kategori { get; set; } = string.Empty;
        public string Sjekkpunkt { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public virtual ServiceOrder ServiceOrder { get; set; } // Navigation property
    }
}
