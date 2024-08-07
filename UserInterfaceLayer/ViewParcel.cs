using parcelCompany.DataLinkLayer.DataInteraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace parcelCompany.UserInterfaceLayer
{
    public enum Root
    {
        Dashboard,
        Home
    }
    public partial class ViewParcel : Form
    {
        private Root root;
        private Dictionary<string, object> parcelQuery = new Dictionary<string, object>();
        string prepopulatedId = "";

        public ViewParcel(Root root, string customer)
        {
            InitializeComponent();
            this.root = root;
            this.prepopulatedId = customer;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ParcelData parcelData = new ParcelData();
            SqlDataAdapter data = parcelData.searchParcel(trackIdTextBox.Text);
            UiUtility.populateDataGrid(data, parcelDataGridView);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            parcelDataGridView.DataSource = null;
            parcelDataGridView.Refresh();
            trackIdTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.root == Root.Dashboard)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else if (this.root == Root.Home)
            {
                Home home = new Home();
                home.Show();
            }
            this.Hide();
        }

        private void ViewParcel_Load(object sender, EventArgs e)
        {
            if (this.root == Root.Home)
            {
                updateButton.Hide();
            }
            else if (this.root == Root.Dashboard)
            {
                updateButton.Show();
            }
            trackIdTextBox.Text = this.prepopulatedId;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (parcelDataGridView.DataSource != null)
            {
                Dictionary<string, object> updatedParcel = new Dictionary<string, object>();

                DataGridViewRow row = parcelDataGridView.Rows[0];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (this.parcelQuery[cell.OwningColumn.Name] != cell.Value)
                    {
                        updatedParcel.Add(cell.OwningColumn.Name, cell.Value);
                    }
                }

                ParcelData parcelData = new ParcelData();
                parcelData.UpdateParcel(updatedParcel, (string)this.parcelQuery["parcelTrackID"]);
            }
        }

        private void registerQueryData()
        {
            if (this.parcelQuery != null)
            {
                this.parcelQuery.Clear();
            }
            if (parcelDataGridView.DataSource != null)
            {
                DataGridViewRow row = parcelDataGridView.Rows[0];
                foreach(DataGridViewCell cell in row.Cells)
                {
                    this.parcelQuery.Add(cell.OwningColumn.Name, cell.Value);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exitbttn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
