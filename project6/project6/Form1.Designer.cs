namespace project6
{
    partial class frmProject6
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblChampionships = new System.Windows.Forms.Label();
            this.lblWhoWon = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpChampionships = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtChampionships = new System.Windows.Forms.TextBox();
            this.grpWhoWon = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtThisYear = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.grpFilter.SuspendLayout();
            this.grpChampionships.SuspendLayout();
            this.grpWhoWon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(192, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MLB World Series Data Set";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(84, 82);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(125, 24);
            this.lblTeams.TabIndex = 1;
            this.lblTeams.Text = "Total Teams";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(6, 39);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(121, 20);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Select a filter:";
            // 
            // lblChampionships
            // 
            this.lblChampionships.AutoSize = true;
            this.lblChampionships.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampionships.Location = new System.Drawing.Point(6, 20);
            this.lblChampionships.Name = "lblChampionships";
            this.lblChampionships.Size = new System.Drawing.Size(331, 20);
            this.lblChampionships.TabIndex = 3;
            this.lblChampionships.Text = "Who has won this many championships?";
            // 
            // lblWhoWon
            // 
            this.lblWhoWon.AutoSize = true;
            this.lblWhoWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoWon.Location = new System.Drawing.Point(40, 16);
            this.lblWhoWon.Name = "lblWhoWon";
            this.lblWhoWon.Size = new System.Drawing.Size(165, 20);
            this.lblWhoWon.TabIndex = 4;
            this.lblWhoWon.Text = "Who won this year?";
            // 
            // comboFilter
            // 
            this.comboFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            "Winners with Years",
            "Deduplicated",
            "One-time Champs"});
            this.comboFilter.Location = new System.Drawing.Point(139, 33);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(225, 32);
            this.comboFilter.TabIndex = 5;
            this.comboFilter.Text = "Select an Item";
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.ComboFilter_SelectedIndexChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblFilter);
            this.grpFilter.Controls.Add(this.comboFilter);
            this.grpFilter.Location = new System.Drawing.Point(353, 82);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(385, 100);
            this.grpFilter.TabIndex = 6;
            this.grpFilter.TabStop = false;
            // 
            // grpChampionships
            // 
            this.grpChampionships.Controls.Add(this.btnCalculate);
            this.grpChampionships.Controls.Add(this.txtChampionships);
            this.grpChampionships.Controls.Add(this.lblChampionships);
            this.grpChampionships.Location = new System.Drawing.Point(353, 198);
            this.grpChampionships.Name = "grpChampionships";
            this.grpChampionships.Size = new System.Drawing.Size(385, 105);
            this.grpChampionships.TabIndex = 7;
            this.grpChampionships.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(233, 50);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 33);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtChampionships
            // 
            this.txtChampionships.Location = new System.Drawing.Point(44, 57);
            this.txtChampionships.Name = "txtChampionships";
            this.txtChampionships.Size = new System.Drawing.Size(138, 20);
            this.txtChampionships.TabIndex = 4;
            // 
            // grpWhoWon
            // 
            this.grpWhoWon.Controls.Add(this.btnSubmit);
            this.grpWhoWon.Controls.Add(this.txtThisYear);
            this.grpWhoWon.Controls.Add(this.lblWhoWon);
            this.grpWhoWon.Location = new System.Drawing.Point(353, 324);
            this.grpWhoWon.Name = "grpWhoWon";
            this.grpWhoWon.Size = new System.Drawing.Size(385, 88);
            this.grpWhoWon.TabIndex = 8;
            this.grpWhoWon.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(233, 35);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtThisYear
            // 
            this.txtThisYear.Location = new System.Drawing.Point(44, 50);
            this.txtThisYear.Name = "txtThisYear";
            this.txtThisYear.Size = new System.Drawing.Size(138, 20);
            this.txtThisYear.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(546, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(27, 115);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(298, 316);
            this.lstTeams.TabIndex = 10;
            // 
            // frmProject6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpWhoWon);
            this.Controls.Add(this.grpChampionships);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmProject6";
            this.Text = "Project 6";
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpChampionships.ResumeLayout(false);
            this.grpChampionships.PerformLayout();
            this.grpWhoWon.ResumeLayout(false);
            this.grpWhoWon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblChampionships;
        private System.Windows.Forms.Label lblWhoWon;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpChampionships;
        private System.Windows.Forms.GroupBox grpWhoWon;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtChampionships;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtThisYear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstTeams;
    }
}

