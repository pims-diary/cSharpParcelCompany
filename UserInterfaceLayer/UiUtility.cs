using parcelCompany.DataLinkLayer.DataInteraction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace parcelCompany.UserInterfaceLayer
{
    internal class UiUtility
    {
        public static bool isTextBoxEmpty(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }
        
        public static void showError(string bodyText, string title)
        {
            MessageBox.Show(bodyText, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void showSucces(string bodyText, string title)
        {
            MessageBox.Show(bodyText, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool isEmpty(string fieldText, string fieldName)
        {
            if (string.IsNullOrEmpty(fieldText))
            {
                UiUtility.showError(
                    fieldName + Resources.Messages.EmptyFieldBody,
                    Resources.Messages.EmptyFieldTitle
                    );
                return true;
            }

            return false;
        }

        public static void clearAllFields(ControlCollection controls)
        {
            foreach (TextBox textBox in controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
        }

        public static void clearAllRadioButtons(ControlCollection controls)
        {
            foreach (RadioButton radioButton in controls.OfType<RadioButton>())
            { 
                radioButton.Checked = false; 
            }
        }

        public static string getSelectedRadioValue(Panel panel)
        {
            var checkedButton = panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                return checkedButton.Text;
            }
            return "";
        }

        public static void populateDataGrid(SqlDataAdapter data, DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            if (data != null)
            {
                data.Fill(dt);
                dataGridView.DataSource = dt;
            }
            else
            {
                showError("No matching records were found.", "Search failure!");
            }
        }

        public static string doubleToString(double myNumber)
        {
            string s = string.Format("{0:0.00}", myNumber);

            return s;
        }
    }
}

