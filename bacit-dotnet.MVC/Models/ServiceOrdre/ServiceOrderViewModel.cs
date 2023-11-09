using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.ServiceOrdre
{
    public class ServiceOrderViewModel
    {
        public List<Serviceform> Serviceforms { get; set; }
        public int OrderId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string PreferredTimePeriod { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public string ModellYear { get; set; } = string.Empty;

        public string RecivedOrder { get; set; } = string.Empty;

        public string RecivedProduct { get; set; } = string.Empty;

        public string ReperationDescription { get; set; } = string.Empty;

        public string AgreedServiceFinished { get; set; } = string.Empty;

        public string AgreedDelivery { get; set; } = string.Empty;

        public string DeliveryWay { get; set; } = string.Empty;

        public string ServiceGaranti { get; set; } = string.Empty;

        public string ServiceDone { get; set; } = string.Empty;

        public string UsedParts { get; set; } = string.Empty;

        public string ReturnedRemovedParts { get; set; } = string.Empty;

        public string HoursUsed { get; set; } = string.Empty;

        public string CaseDone { get; set; } = string.Empty;

        public string SignatureCustomer { get; set; } = string.Empty;

        public string SignatureMechanic { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string Mechanic { get; set; } = string.Empty;
        public bool IsAdministrator { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        [Range(0,100000,ErrorMessage ="Hei sveis, denne verdien er rar, bruk heltall mellom 0 og 100 000")]
        public decimal ConsumedHours { get; set; }
        public string ImageUrl { get; set; }
        public string MechanicComment { get; set; }
        public string CustomerComment { get; set; }

        public string FutureMaintenance { get; set; }
        public int ServiceOrderId { get; set; }
        public List<ServiceOrderJobGroupModel> JobGroups { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerTelephoneNumber { get; set; }

    }
  
    public class ServiceOrderJobGroupModel
    {
        public string Name { get; set; }

        public List<string> Jobs { get; set; }
    }

    public class Serviceform
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string PreferredTimePeriod { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ModellYear { get; set; } = string.Empty;

        public DateTime RecivedOrder { get; set; }

        public DateTime RecivedProduct { get; set; } 

        public string ReperationDescription { get; set; } = string.Empty;

        public DateTime AgreedServiceFinished { get; set; } 

        public DateTime AgreedDelivery { get; set; } 

        public string DeliveryWay { get; set; } = string.Empty;

        public bool ServiceGaranti { get; set; } = false;

        public DateTime ServiceDone { get; set; }
        public string UsedParts { get; set; } = string.Empty;

        public bool ReturnedRemovedParts { get; set; } = false;

        public string HoursUsed { get; set; } = string.Empty;

        public bool CaseDone { get; set; } = false;

        public string SignatureCustomer { get; set; } = string.Empty;

        public string SignatureMechanic { get; set; } = string.Empty;
        public string Mechanic { get; set; } = string.Empty;

        public string SerialNumber { get; set; } = string.Empty;
    }
}
