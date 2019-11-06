namespace project7
{
    partial class frmOrder
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
            this.grpTickets = new System.Windows.Forms.GroupBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.comboLower = new System.Windows.Forms.ComboBox();
            this.comboClub = new System.Windows.Forms.ComboBox();
            this.comboUpper = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTickets
            // 
            this.grpTickets.Controls.Add(this.lblQuantity);
            this.grpTickets.Controls.Add(this.btnBuy);
            this.grpTickets.Controls.Add(this.comboUpper);
            this.grpTickets.Controls.Add(this.comboClub);
            this.grpTickets.Controls.Add(this.comboLower);
            this.grpTickets.Controls.Add(this.lblUpper);
            this.grpTickets.Controls.Add(this.lblClub);
            this.grpTickets.Controls.Add(this.lblLower);
            this.grpTickets.Location = new System.Drawing.Point(12, 32);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Size = new System.Drawing.Size(379, 239);
            this.grpTickets.TabIndex = 0;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Tickets";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(45, 53);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(110, 13);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower Level: $125.00";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(45, 99);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(96, 13);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Club Level: $75.00";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(45, 149);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(104, 13);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Upper Deck: $50.00";
            // 
            // comboLower
            // 
            this.comboLower.FormattingEnabled = true;
            this.comboLower.Location = new System.Drawing.Point(228, 53);
            this.comboLower.Name = "comboLower";
            this.comboLower.Size = new System.Drawing.Size(121, 21);
            this.comboLower.TabIndex = 3;
            // 
            // comboClub
            // 
            this.comboClub.FormattingEnabled = true;
            this.comboClub.Location = new System.Drawing.Point(228, 99);
            this.comboClub.Name = "comboClub";
            this.comboClub.Size = new System.Drawing.Size(121, 21);
            this.comboClub.TabIndex = 4;
            // 
            // comboUpper
            // 
            this.comboUpper.FormattingEnabled = true;
            this.comboUpper.Location = new System.Drawing.Point(228, 146);
            this.comboUpper.Name = "comboUpper";
            this.comboUpper.Size = new System.Drawing.Size(121, 21);
            this.comboUpper.TabIndex = 5;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(147, 198);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(117, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(287, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity:";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 305);
            this.Controls.Add(this.grpTickets);
            this.Name = "frmOrder";
            this.Text = "Tickets";
            this.grpTickets.ResumeLayout(false);
            this.grpTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox comboUpper;
        private System.Windows.Forms.ComboBox comboClub;
        private System.Windows.Forms.ComboBox comboLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblLower;
    }
}