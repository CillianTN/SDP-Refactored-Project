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
    public partial class frmClientsMenu : Form
    {
        public frmClientsMenu()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmAddClient openClient = new frmAddClient();
            openClient.Show();
            this.Close();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            frmRemoveClient openRemoveClients = new frmRemoveClient();
            openRemoveClients.Show();
            this.Close();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            frmClientUpdate openUpdateCustomer = new frmClientUpdate();
            openUpdateCustomer.Show();
            this.Close();
        }
    }
}
