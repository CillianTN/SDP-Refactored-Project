
namespace DogGroomSystem22
{
    partial class frmRemoveAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveAppointment));
            dgvAppDelete = new System.Windows.Forms.DataGridView();
            lblForenameSearch = new System.Windows.Forms.Label();
            txtClientForenameSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            grpAppInfo = new System.Windows.Forms.GroupBox();
            txtAppId = new System.Windows.Forms.TextBox();
            txtAppTime = new System.Windows.Forms.TextBox();
            txtAppDate = new System.Windows.Forms.TextBox();
            txtClientId = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            txtForename = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblappId = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblClientId = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblForename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvAppDelete).BeginInit();
            grpAppInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAppDelete
            // 
            dgvAppDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppDelete.Location = new System.Drawing.Point(35, 88);
            dgvAppDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvAppDelete.Name = "dgvAppDelete";
            dgvAppDelete.RowHeadersWidth = 51;
            dgvAppDelete.RowTemplate.Height = 29;
            dgvAppDelete.Size = new System.Drawing.Size(844, 479);
            dgvAppDelete.TabIndex = 0;
            dgvAppDelete.CellContentClick += dgvAppDelete_CellContentClick;
            // 
            // lblForenameSearch
            // 
            lblForenameSearch.AutoSize = true;
            lblForenameSearch.Location = new System.Drawing.Point(35, 31);
            lblForenameSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForenameSearch.Name = "lblForenameSearch";
            lblForenameSearch.Size = new System.Drawing.Size(140, 25);
            lblForenameSearch.TabIndex = 1;
            lblForenameSearch.Text = "Client Forename";
            // 
            // txtClientForenameSearch
            // 
            txtClientForenameSearch.Location = new System.Drawing.Point(234, 31);
            txtClientForenameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtClientForenameSearch.MaxLength = 25;
            txtClientForenameSearch.Name = "txtClientForenameSearch";
            txtClientForenameSearch.Size = new System.Drawing.Size(190, 31);
            txtClientForenameSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(761, 31);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(118, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // grpAppInfo
            // 
            grpAppInfo.Controls.Add(txtAppId);
            grpAppInfo.Controls.Add(txtAppTime);
            grpAppInfo.Controls.Add(txtAppDate);
            grpAppInfo.Controls.Add(txtClientId);
            grpAppInfo.Controls.Add(txtSurname);
            grpAppInfo.Controls.Add(txtForename);
            grpAppInfo.Controls.Add(btnExit);
            grpAppInfo.Controls.Add(btnCancel);
            grpAppInfo.Controls.Add(lblappId);
            grpAppInfo.Controls.Add(lblTime);
            grpAppInfo.Controls.Add(lblDate);
            grpAppInfo.Controls.Add(lblClientId);
            grpAppInfo.Controls.Add(lblSurname);
            grpAppInfo.Controls.Add(lblForename);
            grpAppInfo.Location = new System.Drawing.Point(902, 16);
            grpAppInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpAppInfo.Name = "grpAppInfo";
            grpAppInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpAppInfo.Size = new System.Drawing.Size(388, 535);
            grpAppInfo.TabIndex = 4;
            grpAppInfo.TabStop = false;
            grpAppInfo.Text = "Appointment Info";
            // 
            // txtAppId
            // 
            txtAppId.Enabled = false;
            txtAppId.Location = new System.Drawing.Point(209, 276);
            txtAppId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new System.Drawing.Size(155, 31);
            txtAppId.TabIndex = 13;
            // 
            // txtAppTime
            // 
            txtAppTime.Enabled = false;
            txtAppTime.Location = new System.Drawing.Point(209, 234);
            txtAppTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAppTime.Name = "txtAppTime";
            txtAppTime.Size = new System.Drawing.Size(155, 31);
            txtAppTime.TabIndex = 12;
            // 
            // txtAppDate
            // 
            txtAppDate.Enabled = false;
            txtAppDate.Location = new System.Drawing.Point(209, 191);
            txtAppDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAppDate.Name = "txtAppDate";
            txtAppDate.Size = new System.Drawing.Size(155, 31);
            txtAppDate.TabIndex = 11;
            // 
            // txtClientId
            // 
            txtClientId.Enabled = false;
            txtClientId.Location = new System.Drawing.Point(168, 125);
            txtClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new System.Drawing.Size(155, 31);
            txtClientId.TabIndex = 10;
            // 
            // txtSurname
            // 
            txtSurname.Enabled = false;
            txtSurname.Location = new System.Drawing.Point(168, 80);
            txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(212, 31);
            txtSurname.TabIndex = 9;
            // 
            // txtForename
            // 
            txtForename.Enabled = false;
            txtForename.Location = new System.Drawing.Point(168, 38);
            txtForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtForename.Name = "txtForename";
            txtForename.Size = new System.Drawing.Size(212, 31);
            txtForename.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(8, 475);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(118, 36);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit Menu";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(168, 475);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(212, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel Appointment";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblappId
            // 
            lblappId.AutoSize = true;
            lblappId.Location = new System.Drawing.Point(9, 280);
            lblappId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblappId.Name = "lblappId";
            lblappId.Size = new System.Drawing.Size(141, 25);
            lblappId.TabIndex = 5;
            lblappId.Text = "Appointment ID";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new System.Drawing.Point(9, 238);
            lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(161, 25);
            lblTime.TabIndex = 4;
            lblTime.Text = "Appointment Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(9, 195);
            lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(160, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Appointment Date";
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Location = new System.Drawing.Point(9, 129);
            lblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new System.Drawing.Size(79, 25);
            lblClientId.TabIndex = 2;
            lblClientId.Text = "Client ID";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(10, 80);
            lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(82, 25);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(8, 38);
            lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(91, 25);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            // 
            // frmRemoveAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(1305, 604);
            Controls.Add(grpAppInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtClientForenameSearch);
            Controls.Add(lblForenameSearch);
            Controls.Add(dgvAppDelete);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "frmRemoveAppointment";
            Text = "Cancel Appointment";
            ((System.ComponentModel.ISupportInitialize)dgvAppDelete).EndInit();
            grpAppInfo.ResumeLayout(false);
            grpAppInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppDelete;
        private System.Windows.Forms.Label lblForenameSearch;
        private System.Windows.Forms.TextBox txtClientForenameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpAppInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblappId;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.TextBox txtAppTime;
        private System.Windows.Forms.TextBox txtAppDate;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
    }
}