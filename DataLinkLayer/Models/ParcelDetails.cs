using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.DataLinkLayer.Models
{
    internal class ParcelDetails
    {
        public string parcelTrackId { get; set; }
        public string customerId { get; set; }
        public ContainerDetails container { get; set; }
        public SenderDetails sender { get; set; }
        public ReceiverDetails receiver { get; set;}
        public DriverDetails driver { get; set; }
        public DeliveryDetails delivery { get; set; }
        public string tax { get; set; }
        public string totalCost { get; set; }
    }
}
