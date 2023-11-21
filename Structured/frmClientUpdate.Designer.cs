
namespace DogGroomSystem22
{
    partial class frmClientUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientUpdate));
            this.lblForenameSearch = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpClientUpdate = new System.Windows.Forms.GroupBox();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.txtClientStreet = new System.Windows.Forms.TextBox();
            this.txtClientTown = new System.Windows.Forms.TextBox();
            this.txtClientCity = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.txtClientForename = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGrpForename = new System.Windows.Forms.Label();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpClientUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForenameSearch
            // 
            this.lblForenameSearch.AutoSize = true;
            this.lblForenameSearch.Location = new System.Drawing.Point(40, 52);
            this.lblForenameSearch.Name = "lblForenameSearch";
            this.lblForenameSearch.Size = new System.Drawing.Size(115, 20);
            this.lblForenameSearch.TabIndex = 0;
            this.lblForenameSearch.Text = "Search Surname";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(186, 52);
            this.txtForename.MaxLength = 25;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(155, 27);
            this.txtForename.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpClientUpdate
            // 
            this.grpClientUpdate.Controls.Add(this.btnClientUpdate);
            this.grpClientUpdate.Controls.Add(this.lblClientId);
            this.grpClientUpdate.Controls.Add(this.txtClientId);
            this.grpClientUpdate.Controls.Add(this.txtClientPhone);
            this.grpClientUpdate.Controls.Add(this.txtClientEmail);
            this.grpClientUpdate.Controls.Add(this.txtClientStreet);
            this.grpClientUpdate.Controls.Add(this.txtClientTown);
            this.grpClientUpdate.Controls.Add(this.txtClientCity);
            this.grpClientUpdate.Controls.Add(this.txtClientSurname);
            this.grpClientUpdate.Controls.Add(this.txtClientForename);
            this.grpClientUpdate.Controls.Add(this.lblPhone);
            this.grpClientUpdate.Controls.Add(this.lblEmail);
            this.grpClientUpdate.Controls.Add(this.lblStreet);
            this.grpClientUpdate.Controls.Add(this.lblTown);
            this.grpClientUpdate.Controls.Add(this.lblCity);
            this.grpClientUpdate.Controls.Add(this.lblSurname);
            this.grpClientUpdate.Controls.Add(this.lblGrpForename);
            this.grpClientUpdate.Location = new System.Drawing.Point(801, 13);
            this.grpClientUpdate.Name = "grpClientUpdate";
            this.grpClientUpdate.Size = new System.Drawing.Size(250, 425);
            this.grpClientUpdate.TabIndex = 3;
            this.grpClientUpdate.TabStop = false;
            this.grpClientUpdate.Text = "Client Details";
            this.grpClientUpdate.Visible = false;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(62, 377);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(129, 29);
            this.btnClientUpdate.TabIndex = 16;
            this.btnClientUpdate.Text = "Update Client";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            this.btnClientUpdate.Click += new System.EventHandler(this.btnClientUpdate_Click);
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(7, 305);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(66, 20);
            this.lblClientId.TabIndex = 15;
            this.lblClientId.Text = "Client ID";
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(88, 305);
            this.txtClientId.MaxLength = 3;
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(89, 27);
            this.txtClientId.TabIndex = 14;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(88, 262);
            this.txtClientPhone.MaxLength = 14;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(137, 27);
            this.txtClientPhone.TabIndex = 13;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(88, 222);
            this.txtClientEmail.MaxLength = 75;
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(137, 27);
            this.txtClientEmail.TabIndex = 12;
            // 
            // txtClientStreet
            // 
            this.txtClientStreet.Location = new System.Drawing.Point(88, 183);
            this.txtClientStreet.MaxLength = 75;
            this.txtClientStreet.Name = "txtClientStreet";
            this.txtClientStreet.Size = new System.Drawing.Size(137, 27);
            this.txtClientStreet.TabIndex = 11;
            // 
            // txtClientTown
            // 
            this.txtClientTown.Location = new System.Drawing.Point(88, 144);
            this.txtClientTown.MaxLength = 30;
            this.txtClientTown.Name = "txtClientTown";
            this.txtClientTown.Size = new System.Drawing.Size(137, 27);
            this.txtClientTown.TabIndex = 10;
            // 
            // txtClientCity
            // 
            this.txtClientCity.Location = new System.Drawing.Point(71, 105);
            this.txtClientCity.MaxLength = 25;
            this.txtClientCity.Name = "txtClientCity";
            this.txtClientCity.Size = new System.Drawing.Size(154, 27);
            this.txtClientCity.TabIndex = 9;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(88, 67);
            this.txtClientSurname.MaxLength = 25;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(137, 27);
            this.txtClientSurname.TabIndex = 8;
            // 
            // txtClientForename
            // 
            this.txtClientForename.Location = new System.Drawing.Point(88, 30);
            this.txtClientForename.MaxLength = 25;
            this.txtClientForename.Name = "txtClientForename";
            this.txtClientForename.Size = new System.Drawing.Size(137, 27);
            this.txtClientForename.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 262);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(7, 183);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 20);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(7, 144);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(44, 20);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "Town";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 105);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(7, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblGrpForename
            // 
            this.lblGrpForename.AutoSize = true;
            this.lblGrpForename.Location = new System.Drawing.Point(7, 33);
            this.lblGrpForename.Name = "lblGrpForename";
            this.lblGrpForename.Size = new System.Drawing.Size(75, 20);
            this.lblGrpForename.TabIndex = 0;
            this.lblGrpForename.Text = "Forename";
            // 
            // grdClients
            // 
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Location = new System.Drawing.Point(40, 91);
            this.grdClients.Name = "grdClients";
            this.grdClients.RowHeadersWidth = 51;
            this.grdClients.RowTemplate.Height = 29;
            this.grdClients.Size = new System.Drawing.Size(738, 334);
            this.grdClients.TabIndex = 4;
            this.grdClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClients_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(499, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmClientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdClients);
            this.Controls.Add(this.grpClientUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblForenameSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientUpdate";
            this.Text = "Customer Update";
            this.grpClientUpdate.ResumeLayout(false);
            this.grpClientUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForenameSearch;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpClientUpdate;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.TextBox txtClientStreet;
        private System.Windows.Forms.TextBox txtClientTown;
        private System.Windows.Forms.TextBox txtClientCity;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientForename;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGrpForename;
        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.Button btnExit;
    }
}