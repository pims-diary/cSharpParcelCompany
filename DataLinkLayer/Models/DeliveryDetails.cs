using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.DataLinkLayer.Models
{
    public class DeliveryDetails
    {
        public DateTime pickUpDate { get; set; }
        public DateTime dropOffDate { get; set; }
        public string deliveryStatus { get; set; }
        public string deliveryCost { get; set; }
        public string deliveryNotes { get; set; }
        public string customerNotes { get; set; }
        public bool remotePickUp { get; set; }
    }
}
