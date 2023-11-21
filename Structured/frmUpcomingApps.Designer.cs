
namespace DogGroomSystem22
{
    partial class frmUpcomingApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpcomingApps));
            this.btnUpcomingApps = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.dgvUpcoming = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcoming)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpcomingApps
            // 
            this.btnUpcomingApps.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpcomingApps.Location = new System.Drawing.Point(12, 21);
            this.btnUpcomingApps.Name = "btnUpcomingApps";
            this.btnUpcomingApps.Size = new System.Drawing.Size(219, 36);
            this.btnUpcomingApps.TabIndex = 0;
            this.btnUpcomingApps.Text = "Upcoming Appointments";
            this.btnUpcomingApps.UseVisualStyleBackColor = false;
            this.btnUpcomingApps.Click += new System.EventHandler(this.btnUpcomingApps_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.Location = new System.Drawing.Point(657, 21);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(176, 36);
            this.btnReminder.TabIndex = 1;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // dgvUpcoming
            // 
            this.dgvUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcoming.Location = new System.Drawing.Point(12, 82);
            this.dgvUpcoming.Name = "dgvUpcoming";
            this.dgvUpcoming.RowHeadersWidth = 51;
            this.dgvUpcoming.RowTemplate.Height = 29;
            this.dgvUpcoming.Size = new System.Drawing.Size(821, 466);
            this.dgvUpcoming.TabIndex = 2;
            this.dgvUpcoming.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpcoming_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUpcomingApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(845, 594);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvUpcoming);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnUpcomingApps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpcomingApps";
            this.Text = "Upcoming Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcoming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpcomingApps;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.DataGridView dgvUpcoming;
        private System.Windows.Forms.Button btnExit;
    }
}