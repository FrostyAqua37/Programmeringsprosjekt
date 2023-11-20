using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.ServiceOrdre
{
    public class Serviceform
    {
        public List<Serviceform> workDocument { get; set; }
        public List<Serviceform> serviceform { get; set; }
        [Key]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string PreferredTimePeriod { get; set; }
        public string Comment { get; set; }



        public string Week { get; set; }
        public string Order { get; set; }
        public string Inquiry { get; set; }
        public bool CaseCompleted { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime? PlannedDelivery { get; set; }
        public DateTime? ProductReceivedDate { get; set; }
        public DateTime? AgreedCompletionDate { get; set; }
        public DateTime? ServiceCompletedDate { get; set; }
        public string ServiceHours { get; set; }
        public bool HasOrderNumber { get; set; }
        public bool HasServiceForm { get; set; }
    }

    public class Checklist
    {
        public List<mekanisk> mekanisk { get; set; }
        public List<elektro> elektro { get; set; }
        public List<hydraulikk> hydraulikk { get; set; }
        public List<trykkSettinger> trykkSettinger { get; set; }
        public List<funksjonstest> funksjonstest { get; set; }
    }

    public class mekanisk
    {
        public string mekanisk1 { get; set; }
        public string mekanisk2 { get; set; }
        public string mekanisk3 { get; set; }
        public string mekanisk4 { get; set; }
        public string mekanisk5 { get; set; }
        public string mekanisk6 { get; set; }
        public string mekanisk7 { get; set; }
        public string mekanisk8 { get; set; }
    }

    public class elektro
    {
        public string? elektro1 { get; set; }
        public string? elektro2 { get; set; }
        public string? elektro3 { get; set; }
    }

    public class trykkSettinger
    {
        public string? trykkSetting { get; set; }
    }

    public class funksjonstest
    {
        public string? funksjonstest1 { get; set; }
        public string? funksjonstest2 { get; set; }
        public string? funksjonstest3 { get; set; }
    }

    public class hydraulikk
    {
        public string? hydraulikk1 { get; set; }
        public string? hydraulikk2 { get; set; }
        public string? hydraulikk3 { get; set; }
        public string? hydraulikk4 { get; set; }
        public string? hydraulikk5 { get; set; }
        public string? hydraulikk6 { get; set; }
        public string? hydraulikk7 { get; set; }
    }  
}
