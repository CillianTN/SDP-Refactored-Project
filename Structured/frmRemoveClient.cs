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
    public partial class frmRemoveClient : Form
    {
        public frmRemoveClient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRemoveClient_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search

            dgvClientRemove.DataSource = clientFunctions.getClients(txtForenameSearch.Text.ToUpper()).Tables["CS"];

            //If Null

            if(dgvClientRemove.Rows.Count == 1)
            {
                MessageBox.Show("No clients were found with this name, please search again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForenameSearch.Focus();
                txtForenameSearch.Clear();
                return;
            }

            dgvClientRemove.Visible = true;




        }

        private void dgvClientRemove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            clientFunctions aClient = new clientFunctions();
            aClient.getClient(Convert.ToInt32(dgvClientRemove.Rows[dgvClientRemove.CurrentCell.RowIndex].Cells[0].Value));

            txtForename.Text = aClient.getForename().ToString();
            txtSurname.Text = aClient.getSurname().ToString();
            txtCity.Text = aClient.getCity().ToString();
            txtTown.Text = aClient.getTown().ToString();
            txtStreet.Text = aClient.getTown().ToString();
            txtEmail.Text = aClient.getEmail().ToString();
            txtPhone.Text = aClient.getPhone().ToString();
            txtClientID.Text = aClient.getId().ToString();

            grpDetails.Visible = true;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Instantiate Client Variables

            clientFunctions remClient = new clientFunctions();

            remClient.setId(Convert.ToInt32(txtClientID.Text));


            //Confirm Message
            DialogResult sure = MessageBox.Show("Are you sure you wish to remove this client, with info " +
                "\nName: " + txtForename.Text + " " + txtSurname.Text + "\nAddress: " + txtCity.Text + txtTown.Text + txtStreet.Text +
                "\nEmail: " + txtEmail.Text + "\nPhone: " + txtPhone.Text,"Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(sure == DialogResult.Yes)
            {
                remClient.removeClient(Convert.ToInt32(txtClientID.Text));
                //Confirm Removal
                MessageBox.Show("Success, Client " + txtClientID.Text + " with name " + txtForename.Text + " " + txtSurname.Text +
                    " has successfully been updated with staus 'R' for removed in the Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClientID.Clear();
                txtCity.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtForename.Clear();
                txtSurname.Clear();

                this.Close();
            }
            else
            {
                //Do nothing
                MessageBox.Show("Client has NOT been removed from database.", "Cancelled.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
