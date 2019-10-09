namespace project5
{
    partial class frmProject5
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpCarrier = new System.Windows.Forms.GroupBox();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picUSPS = new System.Windows.Forms.PictureBox();
            this.picFedex = new System.Windows.Forms.PictureBox();
            this.picUPS = new System.Windows.Forms.PictureBox();
            this.radUPS = new System.Windows.Forms.RadioButton();
            this.radFedex = new System.Windows.Forms.RadioButton();
            this.radUSPS = new System.Windows.Forms.RadioButton();
            this.lblUpcharge = new System.Windows.Forms.Label();
            this.grpCarrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUSPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUPS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(34, 83);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(130, 17);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Package Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(37, 103);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(127, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(34, 178);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(144, 17);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Shipping Distance:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(37, 198);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(141, 20);
            this.txtDistance.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(37, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // grpCarrier
            // 
            this.grpCarrier.Controls.Add(this.radUSPS);
            this.grpCarrier.Controls.Add(this.radFedex);
            this.grpCarrier.Controls.Add(this.radUPS);
            this.grpCarrier.Controls.Add(this.picUSPS);
            this.grpCarrier.Controls.Add(this.picFedex);
            this.grpCarrier.Controls.Add(this.picUPS);
            this.grpCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarrier.Location = new System.Drawing.Point(271, 70);
            this.grpCarrier.Name = "grpCarrier";
            this.grpCarrier.Size = new System.Drawing.Size(200, 302);
            this.grpCarrier.TabIndex = 5;
            this.grpCarrier.TabStop = false;
            this.grpCarrier.Text = "Carrier";
            // 
            // lblCalculator
            // 
            this.lblCalculator.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(0, 9);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(771, 47);
            this.lblCalculator.TabIndex = 6;
            this.lblCalculator.Text = "Two Eight Seven Shipping Calculator";
            this.lblCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(542, 130);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(168, 26);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Shipping Cost:";
            // 
            // lblCostDisplay
            // 
            this.lblCostDisplay.AutoSize = true;
            this.lblCostDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblCostDisplay.Location = new System.Drawing.Point(579, 178);
            this.lblCostDisplay.Name = "lblCostDisplay";
            this.lblCostDisplay.Size = new System.Drawing.Size(71, 26);
            this.lblCostDisplay.TabIndex = 8;
            this.lblCostDisplay.Text = "$0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(515, 278);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(222, 42);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Shipping Price";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // picUSPS
            // 
            this.picUSPS.Image = global::project5.Properties.Resources.usps2;
            this.picUSPS.Location = new System.Drawing.Point(71, 208);
            this.picUSPS.Name = "picUSPS";
            this.picUSPS.Size = new System.Drawing.Size(100, 50);
            this.picUSPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUSPS.TabIndex = 2;
            this.picUSPS.TabStop = false;
            // 
            // picFedex
            // 
            this.picFedex.Image = global::project5.Properties.Resources.fedex;
            this.picFedex.Location = new System.Drawing.Point(71, 128);
            this.picFedex.Name = "picFedex";
            this.picFedex.Size = new System.Drawing.Size(100, 50);
            this.picFedex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFedex.TabIndex = 1;
            this.picFedex.TabStop = false;
            // 
            // picUPS
            // 
            this.picUPS.Image = global::project5.Properties.Resources.UPS;
            this.picUPS.Location = new System.Drawing.Point(71, 46);
            this.picUPS.Name = "picUPS";
            this.picUPS.Size = new System.Drawing.Size(100, 50);
            this.picUPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUPS.TabIndex = 0;
            this.picUPS.TabStop = false;
            // 
            // radUPS
            // 
            this.radUPS.AutoSize = true;
            this.radUPS.Location = new System.Drawing.Point(23, 60);
            this.radUPS.Name = "radUPS";
            this.radUPS.Size = new System.Drawing.Size(14, 13);
            this.radUPS.TabIndex = 3;
            this.radUPS.TabStop = true;
            this.radUPS.UseVisualStyleBackColor = true;
            // 
            // radFedex
            // 
            this.radFedex.AutoSize = true;
            this.radFedex.Location = new System.Drawing.Point(23, 149);
            this.radFedex.Name = "radFedex";
            this.radFedex.Size = new System.Drawing.Size(14, 13);
            this.radFedex.TabIndex = 4;
            this.radFedex.TabStop = true;
            this.radFedex.UseVisualStyleBackColor = true;
            // 
            // radUSPS
            // 
            this.radUSPS.AutoSize = true;
            this.radUSPS.Location = new System.Drawing.Point(23, 225);
            this.radUSPS.Name = "radUSPS";
            this.radUSPS.Size = new System.Drawing.Size(14, 13);
            this.radUSPS.TabIndex = 5;
            this.radUSPS.TabStop = true;
            this.radUSPS.UseVisualStyleBackColor = true;
            // 
            // lblUpcharge
            // 
            this.lblUpcharge.AutoSize = true;
            this.lblUpcharge.Location = new System.Drawing.Point(547, 234);
            this.lblUpcharge.Name = "lblUpcharge";
            this.lblUpcharge.Size = new System.Drawing.Size(0, 13);
            this.lblUpcharge.TabIndex = 10;
            // 
            // frmProject5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 416);
            this.Controls.Add(this.lblUpcharge);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCostDisplay);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCalculator);
            this.Controls.Add(this.grpCarrier);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Name = "frmProject5";
            this.Text = "Project 5";
            this.grpCarrier.ResumeLayout(false);
            this.grpCarrier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUSPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpCarrier;
        private System.Windows.Forms.PictureBox picUSPS;
        private System.Windows.Forms.PictureBox picFedex;
        private System.Windows.Forms.PictureBox picUPS;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radUSPS;
        private System.Windows.Forms.RadioButton radFedex;
        private System.Windows.Forms.RadioButton radUPS;
        private System.Windows.Forms.Label lblUpcharge;
    }
}

