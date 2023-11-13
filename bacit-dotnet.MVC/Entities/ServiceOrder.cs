using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bacit_dotnet.MVC.Models.ServiceOrdre
{
    [Table("ServiceOrders")]
    public class ServiceOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Address { get; set; }
        public string ModellYear { get; set; }
        public DateTime RecivedOrder { get; set; }
        public DateTime RecivedProduct { get; set; }
        public string ReperationDescription { get; set; }
        public DateTime AgreedServiceFinished { get; set; }
        public DateTime AgreedDelivery { get; set; }
        public string DeliveryWay { get; set; }
        public bool ServiceGaranti { get; set; }
        public DateTime ServiceDone { get; set; }
        public string UsedParts { get; set; }
        public bool ReturnedRemovedParts { get; set; }
        public string HoursUsed { get; set; }
        public bool CaseDone { get; set; }
        public string SignatureCustomer { get; set; }
        public string SignatureMechanic { get; set; }
        public string SerialNumber { get; set; }

        public string Comment { get; set; }
    }
}