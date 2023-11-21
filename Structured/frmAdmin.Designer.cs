
namespace DogGroomSystem22
{
    partial class frmAdmin
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
            this.btnGenRev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenRev
            // 
            this.btnGenRev.Location = new System.Drawing.Point(253, 13);
            this.btnGenRev.Name = "btnGenRev";
            this.btnGenRev.Size = new System.Drawing.Size(209, 29);
            this.btnGenRev.TabIndex = 0;
            this.btnGenRev.Text = "Generate Revenue";
            this.btnGenRev.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenRev);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenRev;
    }
}