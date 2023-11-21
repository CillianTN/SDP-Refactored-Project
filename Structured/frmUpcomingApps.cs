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
    public partial class frmUpcomingApps : Form
    {
        public frmUpcomingApps()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            frmEmailReminder reminder = new frmEmailReminder();
            reminder.Show();
            this.Close();
        }

        private void dgvUpcoming_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpcomingApps_Click(object sender, EventArgs e)
        {
            //Generate
            dgvUpcoming.DataSource = appFunctions.generateUpcomingApps().Tables["AS"];
        }
    }
}
