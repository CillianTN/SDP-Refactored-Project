
namespace DogGroomSystem22
{
    partial class frmClientsMenu
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(41, 81);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(134, 29);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(41, 174);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(134, 29);
            this.btnRemoveClient.TabIndex = 1;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(41, 127);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(134, 29);
            this.btnUpdateClient.TabIndex = 2;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // frmClientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 290);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnAddClient);
            this.Name = "frmClientsMenu";
            this.Text = "Clients Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnUpdateClient;
    }
}