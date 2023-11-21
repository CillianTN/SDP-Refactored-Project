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
    public partial class frmAppMenu : Form
    {
        public frmAppMenu()
        {
            InitializeComponent();
        }

        private void btnBookApp_Click(object sender, EventArgs e)
        {
            frmBookApp bookApp = new frmBookApp();
            bookApp.Show();
            this.Close();
        }

        private void btnUpcomingApp_Click(object sender, EventArgs e)
        {
            frmUpcomingApps upcomingApps = new frmUpcomingApps();
            upcomingApps.Show();
            this.Close();
        }

        private void btnCancelApp_Click(object sender, EventArgs e)
        {
            frmRemoveAppointment remApp = new frmRemoveAppointment();
            remApp.Show();
            this.Close();
        }
    }
}
