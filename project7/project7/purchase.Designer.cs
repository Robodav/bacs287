namespace project7
{
    partial class frmPurchase
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCSV = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(214, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Cost:";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(75, 93);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(102, 13);
            this.lblCreditCard.TabIndex = 1;
            this.lblCreditCard.Text = "Credit Card Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name on card:";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Location = new System.Drawing.Point(146, 195);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(31, 13);
            this.lblCSV.TabIndex = 3;
            this.lblCSV.Text = "CSV:";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(203, 90);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(245, 20);
            this.txtCreditCard.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtCSV
            // 
            this.txtCSV.Location = new System.Drawing.Point(203, 192);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(49, 20);
            this.txtCSV.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(203, 245);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 302);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCSV);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.lblTotal);
            this.Name = "frmPurchase";
            this.Text = "Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.Button btnSubmit;
    }
}