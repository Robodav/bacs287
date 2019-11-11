namespace project7
{
    partial class frmGetTickets
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnGetTickets = new System.Windows.Forms.Button();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(89, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(476, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "The Stack Overflows";
            // 
            // btnGetTickets
            // 
            this.btnGetTickets.Location = new System.Drawing.Point(246, 245);
            this.btnGetTickets.Name = "btnGetTickets";
            this.btnGetTickets.Size = new System.Drawing.Size(146, 63);
            this.btnGetTickets.TabIndex = 1;
            this.btnGetTickets.Text = "Get Tickets";
            this.btnGetTickets.UseVisualStyleBackColor = true;
            this.btnGetTickets.Click += new System.EventHandler(this.BtnGetTickets_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Location = new System.Drawing.Point(46, 41);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(36, 13);
            this.linkAdmin.TabIndex = 2;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Admin";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAdmin_LinkClicked);
            // 
            // frmGetTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 437);
            this.Controls.Add(this.linkAdmin);
            this.Controls.Add(this.btnGetTickets);
            this.Controls.Add(this.lblName);
            this.Name = "frmGetTickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGetTickets;
        private System.Windows.Forms.LinkLabel linkAdmin;
    }
}