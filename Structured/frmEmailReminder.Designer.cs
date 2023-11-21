
namespace DogGroomSystem22
{
    partial class frmEmailReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmailReminder));
            this.btnApps = new System.Windows.Forms.Button();
            this.dgvRemind = new System.Windows.Forms.DataGridView();
            this.btnRemind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAppId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDgsTralee = new System.Windows.Forms.Label();
            this.lblSincere = new System.Windows.Forms.Label();
            this.lblParagraph2 = new System.Windows.Forms.Label();
            this.lblParagraph1 = new System.Windows.Forms.Label();
            this.lblAppIdLeft = new System.Windows.Forms.Label();
            this.lblDear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemind)).BeginInit();
            this.grpEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApps
            // 
            this.btnApps.Location = new System.Drawing.Point(28, 13);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(126, 39);
            this.btnApps.TabIndex = 0;
            this.btnApps.Text = "To be Reminded";
            this.btnApps.UseVisualStyleBackColor = true;
            this.btnApps.Click += new System.EventHandler(this.btnApps_Click);
            // 
            // dgvRemind
            // 
            this.dgvRemind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemind.Location = new System.Drawing.Point(28, 84);
            this.dgvRemind.Name = "dgvRemind";
            this.dgvRemind.RowHeadersWidth = 51;
            this.dgvRemind.RowTemplate.Height = 29;
            this.dgvRemind.Size = new System.Drawing.Size(478, 323);
            this.dgvRemind.TabIndex = 1;
            this.dgvRemind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemind_CellContentClick);
            // 
            // btnRemind
            // 
            this.btnRemind.Location = new System.Drawing.Point(920, 399);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Size = new System.Drawing.Size(154, 39);
            this.btnRemind.TabIndex = 2;
            this.btnRemind.Text = "Send Reminder";
            this.btnRemind.UseVisualStyleBackColor = true;
            this.btnRemind.Click += new System.EventHandler(this.btnRemind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.lblEmail);
            this.grpEmail.Controls.Add(this.lblEmailTo);
            this.grpEmail.Controls.Add(this.lblTime);
            this.grpEmail.Controls.Add(this.lblDate);
            this.grpEmail.Controls.Add(this.lblAppId);
            this.grpEmail.Controls.Add(this.lblName);
            this.grpEmail.Controls.Add(this.lblDgsTralee);
            this.grpEmail.Controls.Add(this.lblSincere);
            this.grpEmail.Controls.Add(this.lblParagraph2);
            this.grpEmail.Controls.Add(this.lblParagraph1);
            this.grpEmail.Controls.Add(this.lblAppIdLeft);
            this.grpEmail.Controls.Add(this.lblDear);
            this.grpEmail.Location = new System.Drawing.Point(528, 13);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(558, 380);
            this.grpEmail.TabIndex = 4;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email Info";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmail.Location = new System.Drawing.Point(103, 308);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(7, 308);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(90, 20);
            this.lblEmailTo.TabIndex = 10;
            this.lblEmailTo.Text = "Emailing To:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(458, 112);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(363, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.ForeColor = System.Drawing.Color.Maroon;
            this.lblAppId.Location = new System.Drawing.Point(146, 71);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(52, 20);
            this.lblAppId.TabIndex = 7;
            this.lblAppId.Text = "AppID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(54, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "NAME";
            // 
            // lblDgsTralee
            // 
            this.lblDgsTralee.AutoSize = true;
            this.lblDgsTralee.Location = new System.Drawing.Point(7, 249);
            this.lblDgsTralee.Name = "lblDgsTralee";
            this.lblDgsTralee.Size = new System.Drawing.Size(183, 20);
            this.lblDgsTralee.TabIndex = 5;
            this.lblDgsTralee.Text = "Dog Groom Service Tralee";
            // 
            // lblSincere
            // 
            this.lblSincere.AutoSize = true;
            this.lblSincere.Location = new System.Drawing.Point(7, 220);
            this.lblSincere.Name = "lblSincere";
            this.lblSincere.Size = new System.Drawing.Size(108, 20);
            this.lblSincere.TabIndex = 4;
            this.lblSincere.Text = "Yours sincerely,";
            // 
            // lblParagraph2
            // 
            this.lblParagraph2.AutoSize = true;
            this.lblParagraph2.Location = new System.Drawing.Point(7, 185);
            this.lblParagraph2.Name = "lblParagraph2";
            this.lblParagraph2.Size = new System.Drawing.Size(493, 20);
            this.lblParagraph2.TabIndex = 3;
            this.lblParagraph2.Text = "If you cannot make this appointment, please phone, or call into the office";
            // 
            // lblParagraph1
            // 
            this.lblParagraph1.AutoSize = true;
            this.lblParagraph1.Location = new System.Drawing.Point(7, 112);
            this.lblParagraph1.Name = "lblParagraph1";
            this.lblParagraph1.Size = new System.Drawing.Size(349, 20);
            this.lblParagraph1.TabIndex = 2;
            this.lblParagraph1.Text = "This is a reminder that you have an appointment on";
            // 
            // lblAppIdLeft
            // 
            this.lblAppIdLeft.AutoSize = true;
            this.lblAppIdLeft.Location = new System.Drawing.Point(7, 71);
            this.lblAppIdLeft.Name = "lblAppIdLeft";
            this.lblAppIdLeft.Size = new System.Drawing.Size(132, 20);
            this.lblAppIdLeft.TabIndex = 1;
            this.lblAppIdLeft.Text = "Apppointment ID: ";
            // 
            // lblDear
            // 
            this.lblDear.AutoSize = true;
            this.lblDear.Location = new System.Drawing.Point(7, 27);
            this.lblDear.Name = "lblDear";
            this.lblDear.Size = new System.Drawing.Size(41, 20);
            this.lblDear.TabIndex = 0;
            this.lblDear.Text = "Dear";
            // 
            // frmEmailReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.grpEmail);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemind);
            this.Controls.Add(this.dgvRemind);
            this.Controls.Add(this.btnApps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmailReminder";
            this.Text = "Email Reminder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemind)).EndInit();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApps;
        private System.Windows.Forms.DataGridView dgvRemind;
        private System.Windows.Forms.Button btnRemind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDgsTralee;
        private System.Windows.Forms.Label lblSincere;
        private System.Windows.Forms.Label lblParagraph2;
        private System.Windows.Forms.Label lblParagraph1;
        private System.Windows.Forms.Label lblAppIdLeft;
        private System.Windows.Forms.Label lblDear;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailTo;
    }
}