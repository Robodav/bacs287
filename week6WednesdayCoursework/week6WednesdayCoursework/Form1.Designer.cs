namespace week6WednesdayCoursework
{
    partial class frmWed
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
            this.imgCoat = new System.Windows.Forms.PictureBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoat)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCoat
            // 
            this.imgCoat.BackColor = System.Drawing.Color.White;
            this.imgCoat.Image = global::week6WednesdayCoursework.Properties.Resources.shopping;
            this.imgCoat.Location = new System.Drawing.Point(415, 31);
            this.imgCoat.Name = "imgCoat";
            this.imgCoat.Size = new System.Drawing.Size(300, 390);
            this.imgCoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgCoat.TabIndex = 0;
            this.imgCoat.TabStop = false;
            this.imgCoat.Visible = false;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuery.Location = new System.Drawing.Point(100, 73);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(219, 20);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.Text = "What is the temp outside?";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTemp.Location = new System.Drawing.Point(151, 113);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(122, 193);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 60);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Outfit";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOutput.Location = new System.Drawing.Point(104, 287);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(195, 54);
            this.txtOutput.TabIndex = 4;
            // 
            // frmWed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.imgCoat);
            this.Name = "frmWed";
            this.Text = "Cold Outside";
            ((System.ComponentModel.ISupportInitialize)(this.imgCoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCoat;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

