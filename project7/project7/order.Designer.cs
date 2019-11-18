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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.comboUpper = new System.Windows.Forms.ComboBox();
            this.comboClub = new System.Windows.Forms.ComboBox();
            this.comboLower = new System.Windows.Forms.ComboBox();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
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
            this.grpTickets.Location = new System.Drawing.Point(16, 39);
            this.grpTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTickets.Size = new System.Drawing.Size(505, 294);
            this.grpTickets.TabIndex = 0;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Tickets";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(383, 20);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 17);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(168, 234);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(156, 42);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // comboUpper
            // 
            this.comboUpper.FormattingEnabled = true;
            this.comboUpper.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "Other"});
            this.comboUpper.Location = new System.Drawing.Point(304, 180);
            this.comboUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboUpper.Name = "comboUpper";
            this.comboUpper.Size = new System.Drawing.Size(160, 24);
            this.comboUpper.TabIndex = 5;
            // 
            // comboClub
            // 
            this.comboClub.FormattingEnabled = true;
            this.comboClub.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "Other"});
            this.comboClub.Location = new System.Drawing.Point(304, 122);
            this.comboClub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboClub.Name = "comboClub";
            this.comboClub.Size = new System.Drawing.Size(160, 24);
            this.comboClub.TabIndex = 4;
            // 
            // comboLower
            // 
            this.comboLower.FormattingEnabled = true;
            this.comboLower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboLower.Location = new System.Drawing.Point(304, 65);
            this.comboLower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboLower.Name = "comboLower";
            this.comboLower.Size = new System.Drawing.Size(160, 24);
            this.comboLower.TabIndex = 3;
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(60, 183);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(153, 17);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Upper Deck: $50.00";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(60, 122);
            this.lblClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(144, 17);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Club Level: $75.00";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(60, 65);
            this.lblLower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(164, 17);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower Level: $125.00";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.grpTickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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