using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.DataLinkLayer.Models;
using parcelCompany.UserInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.Controllers
{
    internal class ParcelController
    {
        public ParcelDetails calculateCosts(ParcelDetails parcel)
        {
            double containerMultiplier = 0.0;
            if (parcel.container.containerType.Equals(ContainerType.Drum))
            {
                containerMultiplier = Resources.ContainerCost.Drum;
            }
            else if (parcel.container.containerType.Equals(ContainerType.Box))
            {
                containerMultiplier = Resources.ContainerCost.Box;
            }
            else if (parcel.container.containerType.Equals(ContainerType.Palette))
            {
                containerMultiplier = Resources.ContainerCost.Palette;
            }
            else if (parcel.container.containerType.Equals(ContainerType.Receptacle))
            {
                containerMultiplier = Resources.ContainerCost.Receptacle;
            }

            double vesselMultiplier = 0.0;
            if (parcel.container.vesselSize.Equals(VesselSize.Large))
            {
                vesselMultiplier = Resources.VesselSizeMultiplier.Large;
            }
            else if (parcel.container.vesselSize.Equals(VesselSize.Medium))
            {
                vesselMultiplier = Resources.VesselSizeMultiplier.Medium;
            }
            else if (parcel.container.vesselSize.Equals(VesselSize.Small))
            {
                vesselMultiplier = Resources.VesselSizeMultiplier.Small;
            }

            double parcelCost = containerMultiplier * vesselMultiplier;

            double deliveryCost = 0.0;
            if (!parcel.delivery.remotePickUp)
            {
                deliveryCost = Resources.PickUpCost.InOffice;
            }
            else if ((parcel.delivery.remotePickUp) && (vesselMultiplier == Resources.VesselSizeMultiplier.Large))
            {
                deliveryCost = Resources.PickUpCost.LargePickUp;
            }
            else if ((parcel.delivery.remotePickUp) && (vesselMultiplier == Resources.VesselSizeMultiplier.Medium))
            {
                deliveryCost = Resources.PickUpCost.MediumPickUp;
            }
            else if ((parcel.delivery.remotePickUp) && (vesselMultiplier == Resources.VesselSizeMultiplier.Small))
            {
                deliveryCost = Resources.PickUpCost.SmallPickUp;
            }

            parcel.container.parcelCost = UiUtility.doubleToString(parcelCost);
            parcel.delivery.deliveryCost = UiUtility.doubleToString(deliveryCost);

            double tax = calculateTax(parcelCost, deliveryCost);
            parcel.tax = UiUtility.doubleToString(tax);

            double totalCost = calculateTotalCost(parcelCost, deliveryCost, tax);
            parcel.totalCost = UiUtility.doubleToString(totalCost);

            return parcel;
        }

        public ContainerDetails setContainerType(ContainerDetails container, string containerString)
        {
            if (containerString.Equals("Drum"))
            {
                container.containerType = ContainerType.Drum;
            }
            else if (containerString.Equals("Box"))
            {
                container.containerType = ContainerType.Box;
            }
            else if (containerString.Equals("Palette"))
            {
                container.containerType = ContainerType.Palette;
            }
            else if (containerString.Equals("Receptacle"))
            {
                container.containerType = ContainerType.Receptacle;
            }

            return container;
        }

        public ContainerDetails setVesselType(ContainerDetails container, string vesselString)
        {
            if (vesselString.Equals("Large"))
            {
                container.vesselSize = VesselSize.Large;
            }
            else if (vesselString.Equals("Medium"))
            {
                container.vesselSize = VesselSize.Medium;
            }
            else if (vesselString.Equals("Small"))
            {
                container.vesselSize = VesselSize.Small;
            }

            return container;
        }

        // OOP Concept - Encapsulation - public method. It can be accessed from outside this class.
        public DeliveryDetails setPickUpType(DeliveryDetails delivery, string pickup)
        {
            delivery.remotePickUp = !pickup.Equals("Courier Office");

            return delivery;
        }

        // OOP Concept - Encapsulation - private method. It cannot be accessed from outside this class.
        private double calculateTax(double parcelCost, double deliveryCost)
        {
            double amount = (parcelCost + deliveryCost);
            double tax = amount * (Resources.Tax.gstPercent / 100.0);

            return tax;
        }

        // OOP Concept - Encapsulation - private method. It cannot be accessed from outside this class.
        private double calculateTotalCost(double parcelCost, double deliveryCost, double tax)
        {
            return (parcelCost + deliveryCost + tax);
        }

        public string generateTrackId()
        {
            ParcelData parcelData = new ParcelData();
            string lastTrackId = parcelData.GetLastTrackId();
            string serialNumber = lastTrackId.Substring(1);
            int newTrackId = int.Parse(serialNumber) + 1;
            return "A" + newTrackId.ToString();
        }
    }
}
