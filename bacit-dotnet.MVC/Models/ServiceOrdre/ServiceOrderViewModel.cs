using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.ServiceOrdre
{
    public class ServiceOrderViewModel
    {
        public List<ServiceOrder> ServiceOrders { get; set; }
        public int OrderId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ModellYear { get; set; } = string.Empty;
        public DateTime RecivedOrder { get; set; } 
        public DateTime RecivedProduct { get; set; } 
        public string ReperationDescription { get; set; } = string.Empty;
        public DateTime AgreedServiceFinished { get; set; } 
        public DateTime AgreedDelivery { get; set; } 
        public string DeliveryWay { get; set; } = string.Empty;
        public bool ServiceGaranti { get; set; } 
        public DateTime ServiceDone { get; set; } 
        public string UsedParts { get; set; } = string.Empty;
        public bool ReturnedRemovedParts { get; set; } 
        public string HoursUsed { get; set; } = string.Empty;
        public bool CaseDone { get; set; } 
        public string SignatureCustomer { get; set; } = string.Empty;
        public string SignatureMechanic { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
      
      
    }
}
