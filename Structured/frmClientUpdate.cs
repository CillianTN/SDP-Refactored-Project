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
    public partial class frmClientUpdate : Form
    {
        public frmClientUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdClients.DataSource = clientFunctions.getClients(txtForename.Text.ToUpper()).Tables["CS"];

            //If No Client Found
            if(grdClients.Rows.Count == 1)
            {
                MessageBox.Show("No clients found matching this. Please try another name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;

            }

            

            grdClients.Visible = true;
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            //Validation 

            if (txtClientForename.Text.Equals(""))
            {
                MessageBox.Show("Forename is null, please enter a forename before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientForename.Focus();
                return;
            }

            if (txtClientSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname is null, please enter a forename before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientSurname.Focus();
                return;
            }

            if (txtClientCity.Text.Equals(""))
            {
                MessageBox.Show("City is null, please enter a city before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientCity.Focus();
                return;

            }

            if (txtClientTown.Text.Equals(""))
            {
                MessageBox.Show("Town is null, please enter a town before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientTown.Focus();
                return;
            }

            if (txtClientStreet.Text.Equals(""))
            {
                MessageBox.Show("Street is null, please enter a street before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientStreet.Focus();
                return;

            }

            if (txtClientEmail.Text.Equals(""))
            {
                MessageBox.Show("Email is null, please enter an email before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientEmail.Focus();
                return;
            }

            if (txtClientPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number is null, please enter a phone number before continuing.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientPhone.Focus();
                return;

            }


            clientFunctions client = new clientFunctions();
            client.setId(Convert.ToInt32(txtClientId.Text));
            client.setForename(txtClientForename.Text.ToUpper());
            client.setSurname(txtClientSurname.Text.ToUpper());
            client.setCity(txtClientCity.Text.ToUpper());
            client.setTown(txtClientTown.Text.ToUpper());
            client.setStreet(txtClientStreet.Text.ToUpper());
            client.setEmail(txtClientEmail.Text.ToUpper());
            client.setPhone(txtClientPhone.Text);


            DialogResult dialogRes = MessageBox.Show("Are you sure you wish to update the client with these details?" + "\nName: " + txtClientForename.Text + " " + txtClientSurname.Text +
                "\nAddress: " + txtClientCity.Text + ", " + txtClientTown.Text + ", " + txtClientStreet.Text + "\nEmail: " + txtClientEmail.Text +
                "\nPhone Number: " + txtClientPhone.Text, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogRes == DialogResult.Yes)
            {
                client.updateClient();
                MessageBox.Show("Client Updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

        }

        private void grdClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientFunctions client = new clientFunctions();
            client.getClient(Convert.ToInt32(grdClients.Rows[grdClients.CurrentCell.RowIndex].Cells[0].Value));

            txtClientId.Text = client.getId().ToString();
            txtClientForename.Text = client.getForename();
            txtClientSurname.Text = client.getSurname();
            txtClientCity.Text = client.getCity();
            txtClientTown.Text = client.getTown();
            txtClientStreet.Text = client.getStreet();
            txtClientEmail.Text = client.getEmail();
            txtClientPhone.Text = client.getPhone();

            grpClientUpdate.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you wish to exit the Update Menu?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
