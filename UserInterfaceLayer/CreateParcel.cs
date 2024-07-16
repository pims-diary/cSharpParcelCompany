using parcelCompany.Controllers;
using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.DataLinkLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace parcelCompany.UserInterfaceLayer
{
    public partial class CreateParcel : Form
    {
        public CreateParcel()
        {
            InitializeComponent();
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            validateFields();

            ParcelDetails parcel = populateBasicParcelData();

            ParcelController parcelController = new ParcelController();

            parcel = parcelController.calculateCosts(parcel);

            parcel.parcelTrackId = parcelController.generateTrackId();

            ParcelData parcelData = new ParcelData();
            parcelData.CreateParcel(parcel);

            clearAllFields();
            UiUtility.showSucces(Resources.Messages.CreateParcelSuccessBody + parcel.parcelTrackId, "Success!");
        }

        private void step2ClearButton_Click(object sender, EventArgs e)
        {
            UiUtility.clearAllRadioButtons(vesselPanel.Controls);
            UiUtility.clearAllRadioButtons(containerPanel.Controls);
            UiUtility.clearAllRadioButtons(pickUpPanel.Controls);
        }

        private void step3ClearButton_Click(object sender, EventArgs e)
        {
            UiUtility.clearAllFields(step3Tab.Controls);
        }

        private void step4ClearButton_Click(object sender, EventArgs e)
        {
            UiUtility.clearAllFields(step4Tab.Controls);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void CreateParcel_Load(object sender, EventArgs e)
        {
            DriverData driverData = new DriverData();
            Dictionary<string, string> driverDetails = driverData.GetDriversNameAndID();
            driverComboBox.DataSource = new BindingSource(driverDetails, null);
            driverComboBox.DisplayMember = "Value";
            driverComboBox.ValueMember = "Key";
        }

        private void selectDriverButton_Click(object sender, EventArgs e)
        {
            string driverId = ((string)driverComboBox.SelectedValue).Trim();
            DriverData driverData = new DriverData();
            SqlDataAdapter adapter = driverData.ShowDriverDetails(driverId);
            UiUtility.populateDataGrid(adapter, driverDataGridView);
        }

        private void step5ClearButton_Click(object sender, EventArgs e)
        {
            driverDataGridView.DataSource = null;
            driverDataGridView.Refresh();
        }

        private void previewCostButton_Click(object sender, EventArgs e)
        {
            validateFields();

            ParcelDetails parcel = populateBasicParcelData();

            ParcelController parcelController = new ParcelController();

            parcel = parcelController.calculateCosts(parcel);

            deliveryCostTextBox.Text = "$" + parcel.delivery.deliveryCost;
            parcelCostTextBox.Text = "$" + parcel.container.parcelCost;
            taxTextBox.Text = "$" + parcel.tax;
            totalCostTextBox.Text = "$" + parcel.totalCost;

        }

        private void validateFields()
        {
            string vesselSize = UiUtility.getSelectedRadioValue(vesselPanel);
            string containerType = UiUtility.getSelectedRadioValue(containerPanel);
            string pickUpType = UiUtility.getSelectedRadioValue(pickUpPanel);
            if (vesselSize == "" || containerType == "" || pickUpType == "")
            {
                UiUtility.showError("All fields from Step 1 tab are mandatory. Please make a selection for all fields.", "Save Failed!");
                return;
            }

            foreach (TextBox textbox in step3Tab.Controls.OfType<TextBox>())
            {
                if (UiUtility.isTextBoxEmpty(textbox))
                {
                    UiUtility.showError("Fields in Step 2 tab cannot be left empty", "Save Failed!");
                    return;
                }
            }

            foreach (TextBox textbox in step4Tab.Controls.OfType<TextBox>())
            {
                if (UiUtility.isTextBoxEmpty(textbox))
                {
                    UiUtility.showError("Fields in Step 3 tab cannot be left empty", "Save Failed!");
                    return;
                }
            }
            
            if (driverDataGridView.DataSource == null)
            {
                UiUtility.showError("Please select a Driver in Step 4 tab", "Save Failed!");
                return;
            }
        }

        public ParcelDetails populateBasicParcelData()
        {
            ParcelDetails parcel = new ParcelDetails();
            ContainerDetails container = new ContainerDetails();
            SenderDetails sender = new SenderDetails();
            ReceiverDetails receiver = new ReceiverDetails();
            DriverDetails driver = new DriverDetails();
            DeliveryDetails delivery = new DeliveryDetails();

            ParcelController parcelController = new ParcelController();

            string vesselSize = UiUtility.getSelectedRadioValue(vesselPanel);
            string containerType = UiUtility.getSelectedRadioValue(containerPanel);
            string pickUpType = UiUtility.getSelectedRadioValue(pickUpPanel);


            container = parcelController.setContainerType(container, containerType);
            container = parcelController.setVesselType(container, vesselSize);

            delivery = parcelController.setPickUpType(delivery, pickUpType);

            DataGridViewRow customerRow = customerDataGridView.Rows[0];
            parcel.customerId = ((string)customerRow.Cells[0].Value).Trim();

            sender.senderName = senderNameTextBox.Text;
            sender.senderAddress = senderAddressTextBox.Text;
            sender.senderEmail = senderEmailTextBox.Text;
            sender.senderPhone = senderPhoneTextBox.Text;

            receiver.receiverName = receiverNameTextBox.Text;
            receiver.receiverAddress = receiverAddressTextBox.Text;
            receiver.receiverPhone = receiverMobileTextBox.Text;

            delivery.deliveryStatus = Resources.DeliveryStatus.Initiated;
            delivery.pickUpDate = DateTime.Now;
            delivery = fillUpOptionalFields(delivery);

            DataGridViewRow row = driverDataGridView.Rows[0];
            driver.driverName = (string)row.Cells[1].Value;
            driver.driverPhone = (string)row.Cells[2].Value;
            driver.driverVehiclePlate = (string)row.Cells[3].Value;

            parcel.container = container;
            parcel.sender = sender;
            parcel.receiver = receiver;
            parcel.driver = driver;
            parcel.delivery = delivery;

            return parcel;
        }

        public DeliveryDetails fillUpOptionalFields(DeliveryDetails delivery)
        {
            if (receiverNoteText.Text.Length == 0)
            {
                delivery.customerNotes = "N/A";
            }
            else
            {
                delivery.customerNotes = receiverNoteText.Text;
            }

            if (deliveryNotesText.Text.Length == 0)
            {
                delivery.deliveryNotes = "N/A";
            }
            else
            {
                delivery.deliveryNotes = deliveryNotesText.Text;
            }

            return delivery;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            SqlDataAdapter data = customerData.searchCustomer(customerIdTextBox.Text);
            UiUtility.populateDataGrid(data, customerDataGridView);
        }

        private void step1ClearBtn_Click(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = null;
            customerDataGridView.Refresh();
        }

        private void clearAllFields()
        {
            customerDataGridView.DataSource = null;
            customerDataGridView.Refresh();

            UiUtility.clearAllRadioButtons(vesselPanel.Controls);
            UiUtility.clearAllRadioButtons(containerPanel.Controls);
            UiUtility.clearAllRadioButtons(pickUpPanel.Controls);

            UiUtility.clearAllFields(step3Tab.Controls);

            UiUtility.clearAllFields(step4Tab.Controls);

            driverDataGridView.DataSource = null;
            driverDataGridView.Refresh();
        }
    }
}
