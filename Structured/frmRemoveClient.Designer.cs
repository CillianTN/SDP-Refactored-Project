
namespace DogGroomSystem22
{
    partial class frmRemoveClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveClient));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtForenameSearch = new System.Windows.Forms.TextBox();
            this.lblSearchForename = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvClientRemove = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(860, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtForenameSearch
            // 
            this.txtForenameSearch.Location = new System.Drawing.Point(717, 31);
            this.txtForenameSearch.Name = "txtForenameSearch";
            this.txtForenameSearch.Size = new System.Drawing.Size(125, 27);
            this.txtForenameSearch.TabIndex = 1;
            // 
            // lblSearchForename
            // 
            this.lblSearchForename.AutoSize = true;
            this.lblSearchForename.Location = new System.Drawing.Point(577, 34);
            this.lblSearchForename.Name = "lblSearchForename";
            this.lblSearchForename.Size = new System.Drawing.Size(115, 20);
            this.lblSearchForename.TabIndex = 2;
            this.lblSearchForename.Text = "Search Surname";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(607, 462);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Client";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(860, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvClientRemove
            // 
            this.dgvClientRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientRemove.Location = new System.Drawing.Point(33, 81);
            this.dgvClientRemove.Name = "dgvClientRemove";
            this.dgvClientRemove.RowHeadersWidth = 51;
            this.dgvClientRemove.RowTemplate.Height = 29;
            this.dgvClientRemove.Size = new System.Drawing.Size(540, 410);
            this.dgvClientRemove.TabIndex = 6;
            this.dgvClientRemove.Visible = false;
            this.dgvClientRemove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientRemove_CellContentClick);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtClientID);
            this.grpDetails.Controls.Add(this.txtPhone);
            this.grpDetails.Controls.Add(this.txtEmail);
            this.grpDetails.Controls.Add(this.txtStreet);
            this.grpDetails.Controls.Add(this.txtTown);
            this.grpDetails.Controls.Add(this.txtCity);
            this.grpDetails.Controls.Add(this.txtSurname);
            this.grpDetails.Controls.Add(this.txtForename);
            this.grpDetails.Controls.Add(this.lblClientId);
            this.grpDetails.Controls.Add(this.lblPhone);
            this.grpDetails.Controls.Add(this.lblEmail);
            this.grpDetails.Controls.Add(this.lblStreet);
            this.grpDetails.Controls.Add(this.lblTown);
            this.grpDetails.Controls.Add(this.lblCity);
            this.grpDetails.Controls.Add(this.lblSurname);
            this.grpDetails.Controls.Add(this.lblForename);
            this.grpDetails.Location = new System.Drawing.Point(607, 81);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(347, 359);
            this.grpDetails.TabIndex = 7;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Client Details";
            this.grpDetails.Visible = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Location = new System.Drawing.Point(112, 276);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(86, 27);
            this.txtClientID.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(112, 241);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 27);
            this.txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(112, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 27);
            this.txtEmail.TabIndex = 13;
            // 
            // txtStreet
            // 
            this.txtStreet.Enabled = false;
            this.txtStreet.Location = new System.Drawing.Point(112, 174);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(181, 27);
            this.txtStreet.TabIndex = 12;
            // 
            // txtTown
            // 
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(112, 140);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(181, 27);
            this.txtTown.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(112, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 27);
            this.txtCity.TabIndex = 10;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(112, 69);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(181, 27);
            this.txtSurname.TabIndex = 9;
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(112, 35);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(181, 27);
            this.txtForename.TabIndex = 8;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(6, 283);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(66, 20);
            this.lblClientId.TabIndex = 7;
            this.lblClientId.Text = "Client ID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 248);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(7, 177);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 20);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(6, 143);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(44, 20);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "Town";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 109);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(7, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(7, 38);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(75, 20);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename";
            // 
            // frmRemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(982, 531);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvClientRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSearchForename);
            this.Controls.Add(this.txtForenameSearch);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveClient";
            this.Text = "Remove Client";
            this.Load += new System.EventHandler(this.frmRemoveClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientRemove)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtForenameSearch;
        private System.Windows.Forms.Label lblSearchForename;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvClientRemove;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
    }
}