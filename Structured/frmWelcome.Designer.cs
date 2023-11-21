
namespace DogGroomSystem22
{
    partial class frmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.btnTestCon = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnApps = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(28, 389);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(94, 29);
            this.btnTestCon.TabIndex = 0;
            this.btnTestCon.Text = "Test Connection";
            this.btnTestCon.UseVisualStyleBackColor = true;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 421);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(99, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Disconnected";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(186, 262);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(137, 51);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients Menu";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnApps
            // 
            this.btnApps.Location = new System.Drawing.Point(477, 262);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(137, 51);
            this.btnApps.TabIndex = 5;
            this.btnApps.Text = "Appointments Menu";
            this.btnApps.UseVisualStyleBackColor = true;
            this.btnApps.Click += new System.EventHandler(this.btnApps_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(354, 346);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(94, 29);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnApps);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnTestCon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnApps;
        private System.Windows.Forms.Button btnAdmin;
    }
}

