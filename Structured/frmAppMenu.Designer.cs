
namespace DogGroomSystem22
{
    partial class frmAppMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppMenu));
            this.btnBookApp = new System.Windows.Forms.Button();
            this.btnCancelApp = new System.Windows.Forms.Button();
            this.btnUpcomingApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookApp
            // 
            this.btnBookApp.Location = new System.Drawing.Point(73, 49);
            this.btnBookApp.Name = "btnBookApp";
            this.btnBookApp.Size = new System.Drawing.Size(141, 60);
            this.btnBookApp.TabIndex = 0;
            this.btnBookApp.Text = "Book Appointment";
            this.btnBookApp.UseVisualStyleBackColor = true;
            this.btnBookApp.Click += new System.EventHandler(this.btnBookApp_Click);
            // 
            // btnCancelApp
            // 
            this.btnCancelApp.Location = new System.Drawing.Point(73, 152);
            this.btnCancelApp.Name = "btnCancelApp";
            this.btnCancelApp.Size = new System.Drawing.Size(141, 60);
            this.btnCancelApp.TabIndex = 1;
            this.btnCancelApp.Text = "Cancel Appointment";
            this.btnCancelApp.UseVisualStyleBackColor = true;
            this.btnCancelApp.Click += new System.EventHandler(this.btnCancelApp_Click);
            // 
            // btnUpcomingApp
            // 
            this.btnUpcomingApp.Location = new System.Drawing.Point(73, 255);
            this.btnUpcomingApp.Name = "btnUpcomingApp";
            this.btnUpcomingApp.Size = new System.Drawing.Size(141, 60);
            this.btnUpcomingApp.TabIndex = 2;
            this.btnUpcomingApp.Text = "Upcoming Appointments";
            this.btnUpcomingApp.UseVisualStyleBackColor = true;
            this.btnUpcomingApp.Click += new System.EventHandler(this.btnUpcomingApp_Click);
            // 
            // frmAppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(293, 389);
            this.Controls.Add(this.btnUpcomingApp);
            this.Controls.Add(this.btnCancelApp);
            this.Controls.Add(this.btnBookApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppMenu";
            this.Text = "Appointment Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookApp;
        private System.Windows.Forms.Button btnCancelApp;
        private System.Windows.Forms.Button btnUpcomingApp;
    }
}