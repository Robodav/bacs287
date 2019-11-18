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
            this.lblLowerNum = new System.Windows.Forms.Label();
            this.lblClubNum = new System.Windows.Forms.Label();
            this.lblUpperNum = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtConfirmation = new System.Windows.Forms.TextBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblSalesNum = new System.Windows.Forms.Label();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.grpSeats.SuspendLayout();
            this.grpLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.ForeColor = System.Drawing.Color.Red;
            this.lblSales.Location = new System.Drawing.Point(144, 58);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(122, 25);
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
            this.grpSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeats.Location = new System.Drawing.Point(31, 90);
            this.grpSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSeats.Size = new System.Drawing.Size(379, 113);
            this.grpSeats.TabIndex = 1;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Seats Remaining";
            // 
            // lblLowerNum
            // 
            this.lblLowerNum.AutoSize = true;
            this.lblLowerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerNum.Location = new System.Drawing.Point(20, 78);
            this.lblLowerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowerNum.Name = "lblLowerNum";
            this.lblLowerNum.Size = new System.Drawing.Size(17, 17);
            this.lblLowerNum.TabIndex = 3;
            this.lblLowerNum.Text = "0";
            // 
            // lblClubNum
            // 
            this.lblClubNum.AutoSize = true;
            this.lblClubNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubNum.Location = new System.Drawing.Point(146, 78);
            this.lblClubNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubNum.Name = "lblClubNum";
            this.lblClubNum.Size = new System.Drawing.Size(17, 17);
            this.lblClubNum.TabIndex = 4;
            this.lblClubNum.Text = "0";
            // 
            // lblUpperNum
            // 
            this.lblUpperNum.AutoSize = true;
            this.lblUpperNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperNum.Location = new System.Drawing.Point(258, 78);
            this.lblUpperNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpperNum.Name = "lblUpperNum";
            this.lblUpperNum.Size = new System.Drawing.Size(17, 17);
            this.lblUpperNum.TabIndex = 5;
            this.lblUpperNum.Text = "0";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(258, 39);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(98, 17);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Upper Deck:";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(146, 39);
            this.lblClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(89, 17);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Club Level:";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(20, 39);
            this.lblLower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(100, 17);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower Level:";
            // 
            // grpLookup
            // 
            this.grpLookup.Controls.Add(this.btnFind);
            this.grpLookup.Controls.Add(this.txtConfirmation);
            this.grpLookup.Controls.Add(this.lblConfirmation);
            this.grpLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLookup.Location = new System.Drawing.Point(417, 90);
            this.grpLookup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLookup.Name = "grpLookup";
            this.grpLookup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLookup.Size = new System.Drawing.Size(388, 113);
            this.grpLookup.TabIndex = 2;
            this.grpLookup.TabStop = false;
            this.grpLookup.Text = "Guest Lookup";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(115, 71);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 34);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Location = new System.Drawing.Point(181, 39);
            this.txtConfirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmation.TabIndex = 5;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(8, 39);
            this.lblConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(165, 17);
            this.lblConfirmation.TabIndex = 4;
            this.lblConfirmation.Text = "Confirmation Number:";
            // 
            // lblSalesNum
            // 
            this.lblSalesNum.AutoSize = true;
            this.lblSalesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesNum.ForeColor = System.Drawing.Color.Red;
            this.lblSalesNum.Location = new System.Drawing.Point(287, 58);
            this.lblSalesNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesNum.Name = "lblSalesNum";
            this.lblSalesNum.Size = new System.Drawing.Size(66, 25);
            this.lblSalesNum.TabIndex = 3;
            this.lblSalesNum.Text = "$0.00";
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Location = new System.Drawing.Point(31, 210);
            this.dataCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.Size = new System.Drawing.Size(775, 329);
            this.dataCustomers.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 554);
            this.Controls.Add(this.dataCustomers);
            this.Controls.Add(this.lblSalesNum);
            this.Controls.Add(this.grpLookup);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.lblSales);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtConfirmation;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblSalesNum;
        private System.Windows.Forms.DataGridView dataCustomers;
    }
}