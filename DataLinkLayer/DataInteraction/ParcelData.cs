using parcelCompany.DataLinkLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace parcelCompany.DataLinkLayer.DataInteraction
{
    // OOP Concept - Inheritance - This is the child class
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
                                                        "CustomerNotes, " +
                                                        "RemotePickUp) " +
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
                                                        "@CustomerNotes, " +
                                                        "@RemotePickUp)";
            SqlCommand cmd = new SqlCommand(insertCommandString, conn);
            cmd.Parameters.AddWithValue("@ParcelTrackID", parcel.parcelTrackId);
            cmd.Parameters.AddWithValue("@CustomerID", parcel.customerId);
            cmd.Parameters.AddWithValue("@ContainerType", parcel.container.containerType);
            cmd.Parameters.AddWithValue("@VesselSize", parcel.container.vesselSize);
            cmd.Parameters.AddWithValue("@SenderName", parcel.sender.senderName);
            cmd.Parameters.AddWithValue("@SenderAddress", parcel.sender.senderAddress);
            cmd.Parameters.AddWithValue("@SenderPhone", parcel.sender.senderPhone);
            cmd.Parameters.AddWithValue("@SenderEmail", parcel.sender.senderEmail);
            cmd.Parameters.AddWithValue("@ReceiverName", parcel.receiver.receiverName);
            cmd.Parameters.AddWithValue("@ReceiverAddress", parcel.receiver.receiverAddress);
            cmd.Parameters.AddWithValue("@ReceiverPhone", parcel.receiver.receiverPhone);
            cmd.Parameters.AddWithValue("@PickUpDate", parcel.delivery.pickUpDate);
            cmd.Parameters.AddWithValue("@DropOffDate", DateTime.Now);
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
            cmd.Parameters.AddWithValue("@RemotePickUp", parcel.delivery.remotePickUp);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateParcel(Dictionary<string, object> parcelInfo, string trackId)
        {
            if (parcelInfo != null)
            {
                string updatedParams = "";

                foreach (KeyValuePair<string, object> info in parcelInfo)
                {
                    updatedParams += " " + info.Key + "=@" + info.Key + ",";
                }

                updatedParams = updatedParams.Remove(updatedParams.Length - 1);

                string query = "UPDATE ParcelInfo SET" + updatedParams + " WHERE ParcelTrackID=@ParcelTrackID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ParcelTrackID", trackId);

                foreach (KeyValuePair<string, object> info in parcelInfo)
                {
                    cmd.Parameters.AddWithValue("@" + info.Key, info.Value);
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public string GetLastTrackId()
        {
            SqlCommand cmd = new SqlCommand("SELECT ParcelTrackID FROM ParcelInfo WHERE ParcelTrackID=(SELECT max(ParcelTrackID) FROM parcelInfo)", conn);
            string trackId = cmd.ExecuteScalar().ToString();
            conn.Close();
            return trackId;
        }

        public SqlDataAdapter searchParcel(string trackId)
        {
            if (doesParcelExist(trackId))
            {
                SqlCommand cmd = new SqlCommand("select * from ParcelInfo where ParcelTrackID=@ParcelTrackID", conn);
                cmd.Parameters.AddWithValue("@ParcelTrackID", trackId);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                conn.Close();
                return data;
            }
            return null;
        }

        // OOP Concept - Encapsulation - private method. It cannot be accessed from outside this class.
        private bool doesParcelExist(string trackId)
        {
            SqlCommand cmd = new SqlCommand("select COUNT(*) from ParcelInfo where ParcelTrackID=@ParcelTrackID", conn);
            cmd.Parameters.AddWithValue("@ParcelTrackID", trackId);

            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count > 0;
        }

    }
}
