
namespace DogGroomSystem22
{
    partial class frmBookApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookApp));
            grpAppInfo = new System.Windows.Forms.GroupBox();
            txtAppTime = new System.Windows.Forms.TextBox();
            btnGenTime = new System.Windows.Forms.Button();
            txtDetails = new System.Windows.Forms.TextBox();
            lblDetails = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnBookApp = new System.Windows.Forms.Button();
            txtPrice = new System.Windows.Forms.TextBox();
            btnGetPrice = new System.Windows.Forms.Button();
            cbEar = new System.Windows.Forms.CheckBox();
            cbNails = new System.Windows.Forms.CheckBox();
            cbTrim = new System.Windows.Forms.CheckBox();
            dtpAppDate = new System.Windows.Forms.DateTimePicker();
            txtStatus = new System.Windows.Forms.TextBox();
            txtClientId = new System.Windows.Forms.TextBox();
            txtClientSurname = new System.Windows.Forms.TextBox();
            txtClientForename = new System.Windows.Forms.TextBox();
            txtAppId = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblClientId = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblForename = new System.Windows.Forms.Label();
            lblAppId = new System.Windows.Forms.Label();
            dgvClientInfo = new System.Windows.Forms.DataGridView();
            lblClientForenameSearch = new System.Windows.Forms.Label();
            txtForenameSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvTimes = new System.Windows.Forms.DataGridView();
            grpAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTimes).BeginInit();
            SuspendLayout();
            // 
            // grpAppInfo
            // 
            grpAppInfo.Controls.Add(txtAppTime);
            grpAppInfo.Controls.Add(btnGenTime);
            grpAppInfo.Controls.Add(txtDetails);
            grpAppInfo.Controls.Add(lblDetails);
            grpAppInfo.Controls.Add(txtEmail);
            grpAppInfo.Controls.Add(lblEmail);
            grpAppInfo.Controls.Add(btnCancel);
            grpAppInfo.Controls.Add(btnBookApp);
            grpAppInfo.Controls.Add(txtPrice);
            grpAppInfo.Controls.Add(btnGetPrice);
            grpAppInfo.Controls.Add(cbEar);
            grpAppInfo.Controls.Add(cbNails);
            grpAppInfo.Controls.Add(cbTrim);
            grpAppInfo.Controls.Add(dtpAppDate);
            grpAppInfo.Controls.Add(txtStatus);
            grpAppInfo.Controls.Add(txtClientId);
            grpAppInfo.Controls.Add(txtClientSurname);
            grpAppInfo.Controls.Add(txtClientForename);
            grpAppInfo.Controls.Add(txtAppId);
            grpAppInfo.Controls.Add(lblStatus);
            grpAppInfo.Controls.Add(lblTime);
            grpAppInfo.Controls.Add(lblDate);
            grpAppInfo.Controls.Add(lblPrice);
            grpAppInfo.Controls.Add(lblClientId);
            grpAppInfo.Controls.Add(lblSurname);
            grpAppInfo.Controls.Add(lblForename);
            grpAppInfo.Controls.Add(lblAppId);
            grpAppInfo.Location = new System.Drawing.Point(974, 29);
            grpAppInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpAppInfo.Name = "grpAppInfo";
            grpAppInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpAppInfo.Size = new System.Drawing.Size(391, 839);
            grpAppInfo.TabIndex = 0;
            grpAppInfo.TabStop = false;
            grpAppInfo.Text = "Appointment Info";
            // 
            // txtAppTime
            // 
            txtAppTime.Enabled = false;
            txtAppTime.Location = new System.Drawing.Point(116, 640);
            txtAppTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAppTime.Name = "txtAppTime";
            txtAppTime.Size = new System.Drawing.Size(155, 31);
            txtAppTime.TabIndex = 27;
            // 
            // btnGenTime
            // 
            btnGenTime.Location = new System.Drawing.Point(116, 592);
            btnGenTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnGenTime.Name = "btnGenTime";
            btnGenTime.Size = new System.Drawing.Size(189, 36);
            btnGenTime.TabIndex = 26;
            btnGenTime.Text = "Generate Times";
            btnGenTime.UseVisualStyleBackColor = true;
            btnGenTime.Click += btnGenTime_Click;
            // 
            // txtDetails
            // 
            txtDetails.Location = new System.Drawing.Point(116, 731);
            txtDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtDetails.MaxLength = 100;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new System.Drawing.Size(223, 31);
            txtDetails.TabIndex = 25;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new System.Drawing.Point(21, 735);
            lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new System.Drawing.Size(65, 25);
            lblDetails.TabIndex = 24;
            lblDetails.Text = "Details";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new System.Drawing.Point(114, 471);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(225, 31);
            txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(21, 475);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(54, 25);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(254, 795);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(118, 36);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBookApp
            // 
            btnBookApp.Location = new System.Drawing.Point(21, 795);
            btnBookApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnBookApp.Name = "btnBookApp";
            btnBookApp.Size = new System.Drawing.Size(200, 36);
            btnBookApp.TabIndex = 20;
            btnBookApp.Text = "Book Appointment";
            btnBookApp.UseVisualStyleBackColor = true;
            btnBookApp.Click += btnBookApp_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = System.Drawing.SystemColors.Info;
            txtPrice.Enabled = false;
            txtPrice.Location = new System.Drawing.Point(189, 401);
            txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(133, 31);
            txtPrice.TabIndex = 19;
            // 
            // btnGetPrice
            // 
            btnGetPrice.Location = new System.Drawing.Point(21, 401);
            btnGetPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnGetPrice.Name = "btnGetPrice";
            btnGetPrice.Size = new System.Drawing.Size(118, 36);
            btnGetPrice.TabIndex = 18;
            btnGetPrice.Text = "Get Price";
            btnGetPrice.UseVisualStyleBackColor = true;
            btnGetPrice.Click += btnGetPrice_Click;
            // 
            // cbEar
            // 
            cbEar.AutoSize = true;
            cbEar.Location = new System.Drawing.Point(116, 344);
            cbEar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cbEar.Name = "cbEar";
            cbEar.Size = new System.Drawing.Size(110, 29);
            cbEar.TabIndex = 17;
            cbEar.Text = "Ear Wash";
            cbEar.UseVisualStyleBackColor = true;
            // 
            // cbNails
            // 
            cbNails.AutoSize = true;
            cbNails.Location = new System.Drawing.Point(116, 305);
            cbNails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cbNails.Name = "cbNails";
            cbNails.Size = new System.Drawing.Size(100, 29);
            cbNails.TabIndex = 16;
            cbNails.Text = "Nail Cut";
            cbNails.UseVisualStyleBackColor = true;
            // 
            // cbTrim
            // 
            cbTrim.AutoSize = true;
            cbTrim.Location = new System.Drawing.Point(116, 268);
            cbTrim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cbTrim.Name = "cbTrim";
            cbTrim.Size = new System.Drawing.Size(71, 29);
            cbTrim.TabIndex = 15;
            cbTrim.Text = "Trim";
            cbTrim.UseVisualStyleBackColor = true;
            // 
            // dtpAppDate
            // 
            dtpAppDate.CustomFormat = "dd-MM-yyyy";
            dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpAppDate.Location = new System.Drawing.Point(116, 539);
            dtpAppDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpAppDate.MinDate = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            dtpAppDate.Name = "dtpAppDate";
            dtpAppDate.Size = new System.Drawing.Size(223, 31);
            dtpAppDate.TabIndex = 13;
            dtpAppDate.Value = new System.DateTime(2023, 11, 21, 0, 0, 0, 0);
            dtpAppDate.ValueChanged += dtpAppDate_ValueChanged;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new System.Drawing.Point(116, 681);
            txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStatus.MaxLength = 1;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(79, 31);
            txtStatus.TabIndex = 12;
            txtStatus.Text = "N";
            // 
            // txtClientId
            // 
            txtClientId.Enabled = false;
            txtClientId.Location = new System.Drawing.Point(158, 201);
            txtClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new System.Drawing.Size(112, 31);
            txtClientId.TabIndex = 11;
            // 
            // txtClientSurname
            // 
            txtClientSurname.Enabled = false;
            txtClientSurname.Location = new System.Drawing.Point(158, 156);
            txtClientSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtClientSurname.Name = "txtClientSurname";
            txtClientSurname.Size = new System.Drawing.Size(164, 31);
            txtClientSurname.TabIndex = 10;
            // 
            // txtClientForename
            // 
            txtClientForename.Enabled = false;
            txtClientForename.Location = new System.Drawing.Point(158, 106);
            txtClientForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtClientForename.Name = "txtClientForename";
            txtClientForename.Size = new System.Drawing.Size(164, 31);
            txtClientForename.TabIndex = 9;
            // 
            // txtAppId
            // 
            txtAppId.Enabled = false;
            txtAppId.Location = new System.Drawing.Point(189, 60);
            txtAppId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new System.Drawing.Size(133, 31);
            txtAppId.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(21, 690);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(60, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new System.Drawing.Point(21, 640);
            lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(50, 25);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(21, 545);
            lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(49, 25);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(21, 268);
            lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(49, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Location = new System.Drawing.Point(21, 210);
            lblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new System.Drawing.Size(74, 25);
            lblClientId.TabIndex = 3;
            lblClientId.Text = "ClientID";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(21, 156);
            lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(82, 25);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(21, 106);
            lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(91, 25);
            lblForename.TabIndex = 1;
            lblForename.Text = "Forename";
            // 
            // lblAppId
            // 
            lblAppId.AutoSize = true;
            lblAppId.Location = new System.Drawing.Point(21, 60);
            lblAppId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAppId.Name = "lblAppId";
            lblAppId.Size = new System.Drawing.Size(141, 25);
            lblAppId.TabIndex = 0;
            lblAppId.Text = "Appointment ID";
            // 
            // dgvClientInfo
            // 
            dgvClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientInfo.Location = new System.Drawing.Point(60, 89);
            dgvClientInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvClientInfo.Name = "dgvClientInfo";
            dgvClientInfo.RowHeadersWidth = 51;
            dgvClientInfo.RowTemplate.Height = 29;
            dgvClientInfo.Size = new System.Drawing.Size(862, 569);
            dgvClientInfo.TabIndex = 1;
            dgvClientInfo.CellContentClick += dgvClientInfo_CellContentClick;
            // 
            // lblClientForenameSearch
            // 
            lblClientForenameSearch.AutoSize = true;
            lblClientForenameSearch.Location = new System.Drawing.Point(60, 29);
            lblClientForenameSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientForenameSearch.Name = "lblClientForenameSearch";
            lblClientForenameSearch.Size = new System.Drawing.Size(131, 25);
            lblClientForenameSearch.TabIndex = 2;
            lblClientForenameSearch.Text = "Client Surname";
            // 
            // txtForenameSearch
            // 
            txtForenameSearch.Location = new System.Drawing.Point(235, 29);
            txtForenameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtForenameSearch.MaxLength = 25;
            txtForenameSearch.Name = "txtForenameSearch";
            txtForenameSearch.Size = new System.Drawing.Size(235, 31);
            txtForenameSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(538, 28);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(118, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTimes
            // 
            dgvTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimes.Location = new System.Drawing.Point(60, 688);
            dgvTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvTimes.Name = "dgvTimes";
            dgvTimes.RowHeadersWidth = 51;
            dgvTimes.RowTemplate.Height = 29;
            dgvTimes.Size = new System.Drawing.Size(862, 172);
            dgvTimes.TabIndex = 5;
            dgvTimes.TabStop = false;
            dgvTimes.Visible = false;
            dgvTimes.CellContentClick += dgvTimes_CellContentClick;
            // 
            // frmBookApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SlateGray;
            ClientSize = new System.Drawing.Size(1398, 904);
            Controls.Add(dgvTimes);
            Controls.Add(btnSearch);
            Controls.Add(txtForenameSearch);
            Controls.Add(lblClientForenameSearch);
            Controls.Add(dgvClientInfo);
            Controls.Add(grpAppInfo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "frmBookApp";
            Text = "Book Appointment";
            Load += frmBookApp_Load;
            grpAppInfo.ResumeLayout(false);
            grpAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTimes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAppInfo;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientForename;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.DataGridView dgvClientInfo;
        private System.Windows.Forms.Label lblClientForenameSearch;
        private System.Windows.Forms.TextBox txtForenameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBookApp;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.CheckBox cbEar;
        private System.Windows.Forms.CheckBox cbNails;
        private System.Windows.Forms.CheckBox cbTrim;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnGenTime;
        private System.Windows.Forms.DataGridView dgvTimes;
        private System.Windows.Forms.TextBox txtAppTime;
    }
}