using parcelCompany.DataLinkLayer.DataInteraction;
using parcelCompany.DataLinkLayer.Models;
using parcelCompany.UserInterfaceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcelCompany
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void registerNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomerPage = new CreateCustomer();
            createCustomerPage.Show();
            this.Hide();
        }

        private void updateExistingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomerPage = new UpdateCustomer();
            updateCustomerPage.Show();
            this.Hide();
        }

        private void deleteExistingCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomerPage = new DeleteCustomer();
            deleteCustomerPage.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomerPage = new SearchCustomer();
            searchCustomerPage.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewParcel viewParcelPage = new ViewParcel(Root.Dashboard, "");
            viewParcelPage.Show();
            this.Hide();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateParcel createParcelPage = new CreateParcel();
            createParcelPage.Show();
            this.Hide();
        }

        private void searchbttn_Click(object sender, EventArgs e)
        {
            ViewParcel viewParcelPage = new ViewParcel(Root.Dashboard, searchtextBox.Text);
            viewParcelPage.Show();
            this.Hide();
        }
    }
}
