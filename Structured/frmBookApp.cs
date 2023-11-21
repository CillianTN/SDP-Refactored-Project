using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogGroomSystem22
{
    public partial class frmBookApp : Form
    {
        public frmBookApp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            int price = 0;

            if (cbEar.CheckState == CheckState.Checked)
            {
                price += 25;
            }
            if (cbNails.CheckState == CheckState.Checked)
            {
                price += 10;
            }
            if (cbTrim.CheckState == CheckState.Checked)
            {
                price += 15;

            }

            txtPrice.Text = price.ToString();
        }

        private void frmBookApp_Load(object sender, EventArgs e)
        {
            txtAppId.Text = appFunctions.getNextAppId().ToString("000");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search
            dgvClientInfo.DataSource = clientFunctions.getClients(txtForenameSearch.Text.ToUpper()).Tables["CS"];

            //if null

            if (dgvClientInfo.Rows.Count == 1)
            {
                MessageBox.Show("No clients were found with this name, please search again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForenameSearch.Focus();
                txtForenameSearch.Clear();
                return;
            }
        }

        private void dgvClientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientFunctions client = new clientFunctions();
            client.getClient(Convert.ToInt32(dgvClientInfo.Rows[dgvClientInfo.CurrentCell.RowIndex].Cells[0].Value));

            txtClientForename.Text = client.getForename().ToString();
            txtClientSurname.Text = client.getSurname().ToString();
            txtClientId.Text = client.getId().ToString();
            txtEmail.Text = client.getEmail().ToString();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtClientForename.Text.Equals(""))
            {
                MessageBox.Show("Please select someone from the Data Grid, text boxes cannot be null! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientForename.Focus();
                return;
            }
            if (txtClientSurname.Text.Equals(""))
            {
                MessageBox.Show("Please select someone from the Data Grid, text boxes cannot be null! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientSurname.Focus();
                return;
            }
            if (txtClientId.Text.Equals(""))
            {
                MessageBox.Show("Please select someone from the Data Grid, text boxes cannot be null! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientId.Focus();
                return;
            }

            if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Please select someone from the Data Grid, text boxes cannot be null! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtPrice.Text.Equals("0"))
            {
                MessageBox.Show("Price cannot be 0, please select something from the checkboxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (txtDetails.Text.Equals(""))
            {
                MessageBox.Show("Details Cannot be Null, please enter text ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDetails.Focus();
                return;
            }

            if (txtAppTime.Text.Equals(""))
            {
                MessageBox.Show("Please generate a time and select one, it cannot be Null! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDetails.Focus();
                return;
            }
            /*
            appFunctions anAppointment = new appFunctions(
                Convert.ToInt32(txtAppId.Text),
                txtClientForename.Text.ToUpper(),
                txtClientSurname.Text.ToUpper(),
                Convert.ToInt32(txtClientId.Text),
                txtEmail.Text.ToUpper(),
                txtPrice.Text,
                txtAppTime.Text,
                dtpAppDate.Text,
                txtStatus.Text,
                txtDetails.Text);*/

            // New code for factory
            var anAppointment = appointmentFactory.createApp(
                Convert.ToInt32(txtAppId.Text),
                txtClientForename.Text.ToUpper(),
                txtClientSurname.Text.ToUpper(),
                Convert.ToInt32(txtClientId.Text),
                txtEmail.Text.ToUpper(),
                txtPrice.Text,
                txtAppTime.Text,
                dtpAppDate.Text,
                txtStatus.Text,
                txtDetails.Text
            );


            DialogResult dResult = MessageBox.Show("Are you sure you wish to make an appointment for " +
                txtClientForename.Text + " " + txtClientSurname.Text + " on " + txtAppTime.Text + " " + dtpAppDate.Text + "\nWith Details: " + txtDetails.Text, "Are you sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
            {
                anAppointment.addAppointment();
                MessageBox.Show("Appointment successfully booked.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Appointment has not been added.", "Appointment Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboAppTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpAppDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenTime_Click(object sender, EventArgs e)
        {
            dgvTimes.Visible = true;
            dgvTimes.DataSource = appFunctions.getAppTime(dtpAppDate.Text).Tables["AT"];

            //If No Time Slot Found
            if (dgvTimes.Rows.Count == 1)
            {
                MessageBox.Show("No times found for this date. Please try another date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAppDate.Focus();
                return;

            }

        }

        private void dgvTimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appFunctions appointmentTime = new appFunctions();
            appointmentTime.getATime(Convert.ToString(dgvTimes.Rows[dgvTimes.CurrentCell.RowIndex].Cells[0].Value));

            txtAppTime.Text = appointmentTime.getAppTime().ToString();

        }

        // Factory Method
        public class appointmentFactory
        {
            public static appFunctions createApp(int appointmentId, string clientForename, string clientSurname, int clientId, string email, string price, string appTime, string appDate, string status, string details)
            {
                return new appFunctions(appointmentId, clientForename, clientSurname, clientId, email, price, appTime, appDate, status, details);
            }
        }

    }
}


