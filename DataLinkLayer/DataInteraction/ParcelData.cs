using parcelCompany.DataLinkLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using parcelCompany.Resources;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    internal class ParcelData : BaseData
    {

        public void CreateParcel(ParcelDetails parcel)
        {
            string insertCommandString = "INSERT INTO ParcelInfo (" +
                                                        "ParcelTrackID, " +
                                                        "CustomerID, " +
                                                        "ContainerType, " +
                                                        "VesselSize, " +
                                                        "SenderName, " +
                                                        "SenderAddress, " +
                                                        "SenderPhone, " +
                                                        "SenderEmail, " +
                                                        "ReceiverName, " +
                                                        "ReceiverAddress, " +
                                                        "ReceiverPhone, " +
                                                        "PickUpDate, " +
                                                        "DropOffDate, " +
                                                        "DriverName, " +
                                                        "DriverPhone, " +
                                                        "DriverVehiclePlate, " +
                                                        "DeliveryStatus, " +
                                                        "DeliveryCost, " +
                                                        "ParcelCost, " +
                                                        "Tax, " +
                                                        "TotalCost, " +
                                                        "DeliveryNotes," +
                                                        "CustomerNotes) " +
                                                        "VALUES(" +
                                                        "@ParcelTrackID, " +
                                                        "@CustomerID, " +
                                                        "@ContainerType, " +
                                                        "@VesselSize, " +
                                                        "@SenderName, " +
                                                        "@SenderAddress, " +
                                                        "@SenderPhone, " +
                                                        "@SenderEmail, " +
                                                        "@ReceiverName, " +
                                                        "@ReceiverAddress, " +
                                                        "@ReceiverPhone, " +
                                                        "@PickUpDate, " +
                                                        "@DropOffDate, " +
                                                        "@DriverName, " +
                                                        "@DriverPhone, " +
                                                        "@DriverVehiclePlate, " +
                                                        "@DeliveryStatus, " +
                                                        "@DeliveryCost, " +
                                                        "@ParcelCost, " +
                                                        "@Tax, " +
                                                        "@TotalCost, " +
                                                        "@DeliveryNotes, " +
                                                        "@CustomerNotes)";
            SqlCommand cmd = new SqlCommand(insertCommandString, conn);
            cmd.Parameters.AddWithValue("@ParcelTrackID", parcel.parcelTrackId);
            cmd.Parameters.AddWithValue("@CustomerID", parcel.customerId);
            cmd.Parameters.AddWithValue("@ContainerType", parcel.container.containerType);
            cmd.Parameters.AddWithValue("@VesselSize", parcel.container.vesselSize);
            cmd.Parameters.AddWithValue("@SenderName", parcel.sender.senderName);
            cmd.Parameters.AddWithValue("@SenderAddress", parcel.sender.senderAddress);
            cmd.Parameters.AddWithValue("@SenderPhone", parcel.sender.senderPhone);
            cmd.Parameters.AddWithValue("@SenderEmail", parcel.sender.senderEmail);
            cmd.Parameters.AddWithValue("@ReceiverName", parcel.receiver.ReceiverName);
            cmd.Parameters.AddWithValue("@ReceiverAddress", parcel.receiver.ReceiverAddress);
            cmd.Parameters.AddWithValue("@ReceiverPhone", parcel.receiver.ReceiverPhone);
            cmd.Parameters.AddWithValue("@PickUpDate", parcel.delivery.pickUpDate);
            cmd.Parameters.AddWithValue("@DropOffDate", parcel.delivery.dropOffDate);
            cmd.Parameters.AddWithValue("@DriverName", parcel.driver.driverName);
            cmd.Parameters.AddWithValue("@DriverPhone", parcel.driver.driverPhone);
            cmd.Parameters.AddWithValue("@DriverVehiclePlate", parcel.driver.driverVehiclePlate);
            cmd.Parameters.AddWithValue("@DeliveryStatus", parcel.delivery.deliveryStatus);
            cmd.Parameters.AddWithValue("@DeliveryCost", parcel.delivery.deliveryCost);
            cmd.Parameters.AddWithValue("@ParcelCost", parcel.container.parcelCost);
            cmd.Parameters.AddWithValue("@Tax", parcel.tax);
            cmd.Parameters.AddWithValue("@TotalCost", parcel.totalCost);
            cmd.Parameters.AddWithValue("@DeliveryNotes", parcel.delivery.deliveryNotes);
            cmd.Parameters.AddWithValue("@CustomerNotes", parcel.delivery.customerNotes);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateParcel(List<ParcelConstants> param, List<object> value, string trackId)
        {
            string updatedParams = "";
            if (param != null)
            {
                foreach (ParcelConstants parcel in param)
                {
                    updatedParams += " " + parcel.ToString() + "=@" + parcel.ToString() + ",";
                }
                updatedParams = updatedParams.Remove(updatedParams.Length - 1);
            }

            string query = "UPDATE parcelInfo SET" + updatedParams + " WHERE ParcelTrackID=@ParcelTrackID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ParcelTrackID", trackId);

            if (param != null)
            {
                for (int i = 0; i < param.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@" + param[i].ToString(), value[i]);
                }
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
