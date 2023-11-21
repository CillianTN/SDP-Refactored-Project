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
    public partial class frmEmailReminder : Form
    {
        public frmEmailReminder()
        {
            InitializeComponent();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            dgvRemind.DataSource = appFunctions.generateAppointmentReminders().Tables["AS"];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemind_Click(object sender, EventArgs e)
        {
            String emailMsg = "Dear " + lblName.Text + "\n\nAppointment ID: " + lblAppId.Text + "\nThis is a reminder that you have an appointment on " +
                lblDate.Text + " at " + lblTime.Text + " at the Dog Groom Center Tralee.\nIf you cannot make this appointment, please call to the front desk, or phone us to cancel." +
                "\n\n Yours sincerely,\nThe Dog Groom Center.";

            MessageBox.Show("Google Disabled this feature. Thanks so much Google you're the bestest. ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            /*String email = lblEmail.Text;

            appFunctions sendEmailReminder = new appFunctions(email, emailMsg);
            sendEmailReminder.sendEmail();

            sendEmailReminder.setAppId(Convert.ToInt32(lblAppId.Text));
            sendEmailReminder.updateStatus();



            MessageBox.Show("Email has been successfully sent to " + lblName.Text + " at the email " + lblEmail.Text + ".\n\nUser has been assigned status 'R' to indicate they've been reminded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            */
            this.Close();
        }

        private void dgvRemind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appFunctions appRemind = new appFunctions();
            appRemind.getAppointment(Convert.ToInt32(dgvRemind.Rows[dgvRemind.CurrentCell.RowIndex].Cells[0].Value));

            lblAppId.Text = appRemind.getAppId().ToString();
            lblName.Text = appRemind.getForenameApp().ToString();
            lblDate.Text = appRemind.getAppDate().ToString();
            lblTime.Text = appRemind.getAppTime().ToString();
            lblEmail.Text = appRemind.getEmailApp().ToString();
        }
    }
}
