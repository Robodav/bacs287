namespace project4
{
    partial class frmProject4
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
            this.grpLoops = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radSumOdd = new System.Windows.Forms.RadioButton();
            this.radProduct = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpTuition = new System.Windows.Forms.GroupBox();
            this.lstTuition = new System.Windows.Forms.ListBox();
            this.btnCalcTuition = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.grpMillionaire = new System.Windows.Forms.GroupBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblTotalYears = new System.Windows.Forms.Label();
            this.txtTotalYears = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpLoops.SuspendLayout();
            this.grpTuition.SuspendLayout();
            this.grpMillionaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoops
            // 
            this.grpLoops.Controls.Add(this.txtOutput);
            this.grpLoops.Controls.Add(this.txtInput);
            this.grpLoops.Controls.Add(this.btnCalculate);
            this.grpLoops.Controls.Add(this.radSumOdd);
            this.grpLoops.Controls.Add(this.radProduct);
            this.grpLoops.Controls.Add(this.lblOutput);
            this.grpLoops.Controls.Add(this.lblInput);
            this.grpLoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoops.Location = new System.Drawing.Point(27, 27);
            this.grpLoops.Name = "grpLoops";
            this.grpLoops.Size = new System.Drawing.Size(558, 137);
            this.grpLoops.TabIndex = 0;
            this.grpLoops.TabStop = false;
            this.grpLoops.Text = "Loops";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(125, 93);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 26);
            this.txtOutput.TabIndex = 6;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(125, 39);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(418, 42);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 55);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // radSumOdd
            // 
            this.radSumOdd.AutoSize = true;
            this.radSumOdd.Location = new System.Drawing.Point(264, 93);
            this.radSumOdd.Name = "radSumOdd";
            this.radSumOdd.Size = new System.Drawing.Size(122, 24);
            this.radSumOdd.TabIndex = 3;
            this.radSumOdd.TabStop = true;
            this.radSumOdd.Text = "Sum of Odd";
            this.radSumOdd.UseVisualStyleBackColor = true;
            // 
            // radProduct
            // 
            this.radProduct.AutoSize = true;
            this.radProduct.Location = new System.Drawing.Point(264, 42);
            this.radProduct.Name = "radProduct";
            this.radProduct.Size = new System.Drawing.Size(89, 24);
            this.radProduct.TabIndex = 2;
            this.radProduct.TabStop = true;
            this.radProduct.Text = "Product";
            this.radProduct.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(35, 93);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 18);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(44, 42);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(49, 18);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input:";
            // 
            // grpTuition
            // 
            this.grpTuition.Controls.Add(this.lstTuition);
            this.grpTuition.Controls.Add(this.btnCalcTuition);
            this.grpTuition.Controls.Add(this.txtYears);
            this.grpTuition.Controls.Add(this.lblYears);
            this.grpTuition.Controls.Add(this.txtTotalCost);
            this.grpTuition.Controls.Add(this.lblTotalCost);
            this.grpTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTuition.Location = new System.Drawing.Point(27, 186);
            this.grpTuition.Name = "grpTuition";
            this.grpTuition.Size = new System.Drawing.Size(558, 193);
            this.grpTuition.TabIndex = 1;
            this.grpTuition.TabStop = false;
            this.grpTuition.Text = "Display Tuition";
            // 
            // lstTuition
            // 
            this.lstTuition.FormattingEnabled = true;
            this.lstTuition.ItemHeight = 20;
            this.lstTuition.Location = new System.Drawing.Point(38, 26);
            this.lstTuition.Name = "lstTuition";
            this.lstTuition.Size = new System.Drawing.Size(248, 124);
            this.lstTuition.TabIndex = 6;
            // 
            // btnCalcTuition
            // 
            this.btnCalcTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTuition.Location = new System.Drawing.Point(413, 83);
            this.btnCalcTuition.Name = "btnCalcTuition";
            this.btnCalcTuition.Size = new System.Drawing.Size(116, 48);
            this.btnCalcTuition.TabIndex = 5;
            this.btnCalcTuition.Text = "Calculate";
            this.btnCalcTuition.UseVisualStyleBackColor = true;
            this.btnCalcTuition.Click += new System.EventHandler(this.BtnCalcTuition_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(433, 25);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(77, 26);
            this.txtYears.TabIndex = 4;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(317, 26);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(110, 20);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Enter Years:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(150, 162);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(136, 23);
            this.txtTotalCost.TabIndex = 2;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(38, 162);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(86, 20);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "TotalCost";
            // 
            // grpMillionaire
            // 
            this.grpMillionaire.Controls.Add(this.btnCompute);
            this.grpMillionaire.Controls.Add(this.txtTotalYears);
            this.grpMillionaire.Controls.Add(this.lblTotalYears);
            this.grpMillionaire.Controls.Add(this.lblDeposit);
            this.grpMillionaire.Controls.Add(this.txtDeposit);
            this.grpMillionaire.Controls.Add(this.txtInterest);
            this.grpMillionaire.Controls.Add(this.lblInterest);
            this.grpMillionaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMillionaire.Location = new System.Drawing.Point(27, 402);
            this.grpMillionaire.Name = "grpMillionaire";
            this.grpMillionaire.Size = new System.Drawing.Size(558, 198);
            this.grpMillionaire.TabIndex = 2;
            this.grpMillionaire.TabStop = false;
            this.grpMillionaire.Text = "Who wants to be a millionaire?";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(89, 38);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(114, 20);
            this.lblInterest.TabIndex = 0;
            this.lblInterest.Text = "Interest rate:";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(209, 38);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(44, 26);
            this.txtInterest.TabIndex = 1;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(209, 84);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(133, 26);
            this.txtDeposit.TabIndex = 2;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(60, 87);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(143, 20);
            this.lblDeposit.TabIndex = 3;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // lblTotalYears
            // 
            this.lblTotalYears.AutoSize = true;
            this.lblTotalYears.Location = new System.Drawing.Point(15, 145);
            this.lblTotalYears.Name = "lblTotalYears";
            this.lblTotalYears.Size = new System.Drawing.Size(188, 20);
            this.lblTotalYears.TabIndex = 4;
            this.lblTotalYears.Text = "Total amount of years:";
            // 
            // txtTotalYears
            // 
            this.txtTotalYears.Location = new System.Drawing.Point(209, 145);
            this.txtTotalYears.Name = "txtTotalYears";
            this.txtTotalYears.Size = new System.Drawing.Size(77, 26);
            this.txtTotalYears.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(413, 78);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(116, 38);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(177, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmProject4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 648);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpMillionaire);
            this.Controls.Add(this.grpTuition);
            this.Controls.Add(this.grpLoops);
            this.Name = "frmProject4";
            this.Text = "Project 4";
            this.grpLoops.ResumeLayout(false);
            this.grpLoops.PerformLayout();
            this.grpTuition.ResumeLayout(false);
            this.grpTuition.PerformLayout();
            this.grpMillionaire.ResumeLayout(false);
            this.grpMillionaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoops;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radSumOdd;
        private System.Windows.Forms.RadioButton radProduct;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpTuition;
        private System.Windows.Forms.Button btnCalcTuition;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstTuition;
        private System.Windows.Forms.GroupBox grpMillionaire;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtTotalYears;
        private System.Windows.Forms.Label lblTotalYears;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Button btnClose;
    }
}

