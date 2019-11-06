namespace project7
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
            this.lblSales = new System.Windows.Forms.Label();
            this.grpSeats = new System.Windows.Forms.GroupBox();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLowerNum = new System.Windows.Forms.Label();
            this.lblClubNum = new System.Windows.Forms.Label();
            this.lblUpperNum = new System.Windows.Forms.Label();
            this.lblSalesNum = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.grpSeats.SuspendLayout();
            this.grpLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(108, 47);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(60, 13);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Total Sales";
            // 
            // grpSeats
            // 
            this.grpSeats.Controls.Add(this.lblLowerNum);
            this.grpSeats.Controls.Add(this.lblClubNum);
            this.grpSeats.Controls.Add(this.lblUpperNum);
            this.grpSeats.Controls.Add(this.lblUpper);
            this.grpSeats.Controls.Add(this.lblClub);
            this.grpSeats.Controls.Add(this.lblLower);
            this.grpSeats.Location = new System.Drawing.Point(23, 73);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(284, 92);
            this.grpSeats.TabIndex = 1;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Seats Remaining";
            // 
            // grpLookup
            // 
            this.grpLookup.Controls.Add(this.btnFind);
            this.grpLookup.Controls.Add(this.textBox1);
            this.grpLookup.Controls.Add(this.lblConfirmation);
            this.grpLookup.Location = new System.Drawing.Point(313, 73);
            this.grpLookup.Name = "grpLookup";
            this.grpLookup.Size = new System.Drawing.Size(291, 92);
            this.grpLookup.TabIndex = 2;
            this.grpLookup.TabStop = false;
            this.grpLookup.Text = "Guest Lookup";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(32, 32);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(68, 13);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower Level:";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(106, 32);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(60, 13);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Club Level:";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(172, 32);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(68, 13);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Upper Deck:";
            // 
            // lblLowerNum
            // 
            this.lblLowerNum.AutoSize = true;
            this.lblLowerNum.Location = new System.Drawing.Point(32, 63);
            this.lblLowerNum.Name = "lblLowerNum";
            this.lblLowerNum.Size = new System.Drawing.Size(13, 13);
            this.lblLowerNum.TabIndex = 3;
            this.lblLowerNum.Text = "0";
            // 
            // lblClubNum
            // 
            this.lblClubNum.AutoSize = true;
            this.lblClubNum.Location = new System.Drawing.Point(106, 63);
            this.lblClubNum.Name = "lblClubNum";
            this.lblClubNum.Size = new System.Drawing.Size(13, 13);
            this.lblClubNum.TabIndex = 4;
            this.lblClubNum.Text = "0";
            // 
            // lblUpperNum
            // 
            this.lblUpperNum.AutoSize = true;
            this.lblUpperNum.Location = new System.Drawing.Point(172, 63);
            this.lblUpperNum.Name = "lblUpperNum";
            this.lblUpperNum.Size = new System.Drawing.Size(13, 13);
            this.lblUpperNum.TabIndex = 5;
            this.lblUpperNum.Text = "0";
            // 
            // lblSalesNum
            // 
            this.lblSalesNum.AutoSize = true;
            this.lblSalesNum.Location = new System.Drawing.Point(215, 47);
            this.lblSalesNum.Name = "lblSalesNum";
            this.lblSalesNum.Size = new System.Drawing.Size(34, 13);
            this.lblSalesNum.TabIndex = 3;
            this.lblSalesNum.Text = "$0.00";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(6, 32);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmation.TabIndex = 4;
            this.lblConfirmation.Text = "Confirmation Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(86, 58);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Location = new System.Drawing.Point(23, 171);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.Size = new System.Drawing.Size(581, 267);
            this.dataCustomers.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.dataCustomers);
            this.Controls.Add(this.lblSalesNum);
            this.Controls.Add(this.grpLookup);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.lblSales);
            this.Name = "frmAdmin";
            this.Text = "admin";
            this.grpSeats.ResumeLayout(false);
            this.grpSeats.PerformLayout();
            this.grpLookup.ResumeLayout(false);
            this.grpLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.Label lblLowerNum;
        private System.Windows.Forms.Label lblClubNum;
        private System.Windows.Forms.Label lblUpperNum;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.GroupBox grpLookup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblSalesNum;
        private System.Windows.Forms.DataGridView dataCustomers;
    }
}