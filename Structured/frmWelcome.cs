using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogGroomSystem22
{
    public partial class frmWelcome : Form

    {

        SqlConnection conn;
        public frmWelcome()
        {
            InitializeComponent();
            conn = new SqlConnection(dbConnect.sqlConnectionString);
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    lblStatus.Text = "Disconnected";
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    conn.Open();
                    lblStatus.Text = "Connected!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStripMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmClientsMenu openClientsMenu = new frmClientsMenu();
            openClientsMenu.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you wish to exit Dog Groom System?";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClientsMenu clientsMenu = new frmClientsMenu();
            clientsMenu.Show();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            frmAppMenu appsMenu = new frmAppMenu();
            appsMenu.Show();
        }
    }
}
