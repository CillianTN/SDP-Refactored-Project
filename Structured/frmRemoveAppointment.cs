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
    public partial class frmRemoveAppointment : Form
    {
        public frmRemoveAppointment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search Appointment

            dgvAppDelete.DataSource = appFunctions.getAppointments(txtClientForenameSearch.Text.ToUpper()).Tables["AS"];

            //If empt

            if (dgvAppDelete.Rows.Count == 1)
            {
                MessageBox.Show("No clients were found with this name, please search again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientForenameSearch.Focus();
                txtClientForenameSearch.Clear();
                return;
            }

        }

        private void dgvAppDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appFunctions anAppointment = new appFunctions();

            anAppointment.getAppointment(Convert.ToInt32(dgvAppDelete.Rows[dgvAppDelete.CurrentCell.RowIndex].Cells[0].Value));

            txtForename.Text = anAppointment.getForenameApp().ToString();
            txtSurname.Text = anAppointment.getSurnameApp().ToString();
            txtClientId.Text = anAppointment.getClientId().ToString();
            txtAppDate.Text = anAppointment.getAppDate().ToString();
            txtAppTime.Text = anAppointment.getAppTime().ToString();
            txtAppId.Text = anAppointment.getAppId().ToString();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appFunctions remAppointment = new appFunctions();
            remAppointment.setAppId(Convert.ToInt32(txtAppId.Text));

            //Confirm Msg
            DialogResult yesNo = MessageBox.Show("Are you sure you wish to remove this appointment? With details " +
                "\nName: " + txtForename.Text + " " + txtSurname.Text + "\nDate " + txtAppDate.Text + "\nTime: " +
                txtAppTime.Text + " AppID: " + txtAppId.Text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == yesNo)
            {
                remAppointment.removeAppointment(Convert.ToInt32(txtAppId.Text));
                MessageBox.Show("Success, Client " + txtForename.Text + " " + txtSurname.Text + " appointment booked for " +
                    txtAppDate.Text + " at " + txtAppTime.Text + " has been successfully cancelled.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAppDate.Clear();
                txtAppId.Clear();
                txtAppTime.Clear();
                txtClientId.Clear();
                txtForename.Clear();
                txtSurname.Clear();


                RefreshDataGridView();
            }
            else
            {
                //Do nothing...
                MessageBox.Show("Appointment cancellation has been aborted...", "Aborted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private void RefreshDataGridView()
        {
            // Assuming you have a method to get the appointments dataset
            dgvAppDelete.DataSource = appFunctions.getAppointments(txtClientForenameSearch.Text.ToUpper()).Tables["AS"];
        }
    }
}
