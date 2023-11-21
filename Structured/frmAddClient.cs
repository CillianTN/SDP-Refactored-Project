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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            string message = "Do you wish to cancel?";
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

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            txtClientId.Text = clientFunctions.getNextClientId().ToString("000");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            //Validation


            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (txtCity.Text.Equals(""))
            {
                MessageBox.Show("City must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }

            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Town must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered to add Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be numeric to add a Client.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!txtEmail.Text.Contains("@"))
                {
                MessageBox.Show("Enter a valid email please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (!txtPhone.Text.StartsWith("0"))
            {
                MessageBox.Show("Number must start with 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            //Add Client

            clientFunctions aClient = new clientFunctions(Convert.ToInt32(txtClientId.Text), txtForename.Text.ToUpper(), txtSurname.Text.ToUpper(), txtCity.Text.ToUpper(),
                txtTown.Text.ToUpper(), txtStreet.Text.ToUpper(), txtEmail.Text.ToUpper(), txtPhone.Text.ToUpper());


            //Check 
           DialogResult dialogResult =  MessageBox.Show("Is this information correct?" + "\nName: " + txtForename.Text + " " + txtSurname.Text + "\nAddress: " +
                txtCity.Text + ", " + txtTown.Text + ", " + txtStreet.Text + "\nEmail: " + txtEmail.Text + "\nPhone: " + txtPhone.Text +
                "\nIf yes, select Yes to add user to database, otherwise, select No.", "Before adding...." , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        
        if(dialogResult == DialogResult.Yes)
            {
                aClient.addClient();
                MessageBox.Show("Client " + txtForename.Text + " " + txtSurname.Text + " added successfully, with Client ID " + txtClientId.Text + "\n\nUser has been given Status 'A' for Active.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClientId.Text = clientFunctions.getNextClientId().ToString();
                txtForename.Clear();
                txtSurname.Clear();
                txtCity.Clear();
                txtTown.Clear();
                txtStreet.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtForename.Focus();
            }
            else
            {
                //Do Nothing. Doesn't add user to DB, but closes menu.
            }

        }

 
    }
}
