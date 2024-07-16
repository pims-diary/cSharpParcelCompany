namespace parcelCompany.Resources
{
    internal class ParcelConstants
    {
        public const string ParcelTrackID = "ParcelTrackID";
        public const string CustomerID = "CustomerID";
        public const string ContainerType = "ContainerType";
        public const string VesselSize = "VesselSize";
        public const string SenderName = "SenderName";
        public const string SenderAddress = "SenderAddress";
        public const string SenderPhone = "SenderPhone";
        public const string SenderEmail = "SenderEmail";
        public const string ReceiverName = "ReceiverName";
        public const string ReceiverAddress = "ReceiverAddress";
        public const string ReceiverPhone = "ReceiverPhone";
        public const string PickUpDate = "PickUpDate";
        public const string DropOffDate = "DropOffDate";
        public const string DriverName = "DriverName";
        public const string DriverPhone = "DriverPhone";
        public const string DriverVehiclePlate = "DriverVehiclePlate";
        public const string DeliveryStatus = "DeliveryStatus";
        public const string DeliveryCost = "DeliveryCost";
        public const string ParcelCost = "ParcelCost";
        public const string Tax = "Tax";
        public const string TotalCost = "TotalCost";
        public const string DeliveryNotes = "DeliveryNotes";
        public const string CustomerNotes = "CustomerNotes";

    }

    internal class CustomerConstants
    {
        public const string CustomerID = "CustomerID";
        public const string CustomerName = "CustomerName";
        public const string CustomerAddress = "CustomerAddress";
        public const string CustomerEmail = "CustomerEmail";
        public const string CustomerMobile = "CustomerMobile";
    }

    internal class Messages
    {
        public const string EmptyFieldBody = " cannot be left empty.";
        public const string EmptyFieldTitle = "Empty Field Error!";
        public const string CreateCustomerSuccessBody = "New customer created! New customer ID: ";
        public const string CreateParcelSuccessBody = "New parcel created! Parcel Tracking ID: ";
    }

    internal class ContainerCost
    {
        public const double Drum = 50.0;
        public const double Box = 30.0;
        public const double Palette = 20.0;
        public const double Receptacle = 10.0;
    }

    internal class VesselSizeMultiplier
    {
        public const double Large = 2.0;
        public const double Medium = 1.5;
        public const double Small = 1.0;
    }

    internal class PickUpCost
    {
        public const double InOffice = 0.0;
        public const double LargePickUp = 40.0;
        public const double MediumPickUp = 20.0;
        public const double SmallPickUp = 10.0;
    }

    internal class Tax
    {
        public const double gstPercent = 15.0;
    }

    internal class DeliveryStatus
    {
        public const string Initiated = "Initiated";
        public const string Warehouse = "Warehouse";
        public const string Shipped = "Shipped";
        public const string Delivered = "Delivered";
    }
}