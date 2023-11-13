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
        public string SerialNumber { get; set; } = string.Empty;
      
      
    }
}
