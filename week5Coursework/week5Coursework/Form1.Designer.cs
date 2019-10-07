namespace week5Coursework
{
    partial class frmWeek5
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
            this.picApples = new System.Windows.Forms.PictureBox();
            this.picPeas = new System.Windows.Forms.PictureBox();
            this.picPeach = new System.Windows.Forms.PictureBox();
            this.picCarrots = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblApples = new System.Windows.Forms.Label();
            this.lblPeas = new System.Windows.Forms.Label();
            this.lblPeach = new System.Windows.Forms.Label();
            this.lblCarrots = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picApples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarrots)).BeginInit();
            this.SuspendLayout();
            // 
            // picApples
            // 
            this.picApples.Image = global::week5Coursework.Properties.Resources.Apples;
            this.picApples.Location = new System.Drawing.Point(31, 39);
            this.picApples.Name = "picApples";
            this.picApples.Size = new System.Drawing.Size(180, 130);
            this.picApples.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picApples.TabIndex = 0;
            this.picApples.TabStop = false;
            this.picApples.Click += new System.EventHandler(this.PicApples_Click);
            // 
            // picPeas
            // 
            this.picPeas.Image = global::week5Coursework.Properties.Resources.peas;
            this.picPeas.Location = new System.Drawing.Point(228, 39);
            this.picPeas.Name = "picPeas";
            this.picPeas.Size = new System.Drawing.Size(180, 130);
            this.picPeas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPeas.TabIndex = 1;
            this.picPeas.TabStop = false;
            this.picPeas.Click += new System.EventHandler(this.PicPeas_Click);
            // 
            // picPeach
            // 
            this.picPeach.Image = global::week5Coursework.Properties.Resources.peach;
            this.picPeach.Location = new System.Drawing.Point(31, 205);
            this.picPeach.Name = "picPeach";
            this.picPeach.Size = new System.Drawing.Size(180, 130);
            this.picPeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPeach.TabIndex = 2;
            this.picPeach.TabStop = false;
            this.picPeach.Click += new System.EventHandler(this.PicPeach_Click);
            // 
            // picCarrots
            // 
            this.picCarrots.Image = global::week5Coursework.Properties.Resources.carrots;
            this.picCarrots.Location = new System.Drawing.Point(228, 205);
            this.picCarrots.Name = "picCarrots";
            this.picCarrots.Size = new System.Drawing.Size(180, 130);
            this.picCarrots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCarrots.TabIndex = 3;
            this.picCarrots.TabStop = false;
            this.picCarrots.Click += new System.EventHandler(this.PicCarrots_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(541, 111);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(516, 62);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(100, 20);
            this.txtCalories.TabIndex = 6;
            this.txtCalories.Text = "0";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(512, 39);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(119, 20);
            this.lblCalories.TabIndex = 7;
            this.lblCalories.Text = "Total Calories";
            // 
            // lblApples
            // 
            this.lblApples.AutoSize = true;
            this.lblApples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApples.Location = new System.Drawing.Point(31, 13);
            this.lblApples.Name = "lblApples";
            this.lblApples.Size = new System.Drawing.Size(64, 20);
            this.lblApples.TabIndex = 8;
            this.lblApples.Text = "Apples";
            // 
            // lblPeas
            // 
            this.lblPeas.AutoSize = true;
            this.lblPeas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeas.Location = new System.Drawing.Point(224, 16);
            this.lblPeas.Name = "lblPeas";
            this.lblPeas.Size = new System.Drawing.Size(49, 20);
            this.lblPeas.TabIndex = 9;
            this.lblPeas.Text = "Peas";
            // 
            // lblPeach
            // 
            this.lblPeach.AutoSize = true;
            this.lblPeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeach.Location = new System.Drawing.Point(31, 182);
            this.lblPeach.Name = "lblPeach";
            this.lblPeach.Size = new System.Drawing.Size(59, 20);
            this.lblPeach.TabIndex = 10;
            this.lblPeach.Text = "Peach";
            // 
            // lblCarrots
            // 
            this.lblCarrots.AutoSize = true;
            this.lblCarrots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrots.Location = new System.Drawing.Point(224, 182);
            this.lblCarrots.Name = "lblCarrots";
            this.lblCarrots.Size = new System.Drawing.Size(68, 20);
            this.lblCarrots.TabIndex = 11;
            this.lblCarrots.Text = "Carrots";
            // 
            // frmWeek5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 412);
            this.Controls.Add(this.lblCarrots);
            this.Controls.Add(this.lblPeach);
            this.Controls.Add(this.lblPeas);
            this.Controls.Add(this.lblApples);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picCarrots);
            this.Controls.Add(this.picPeach);
            this.Controls.Add(this.picPeas);
            this.Controls.Add(this.picApples);
            this.Name = "frmWeek5";
            this.Text = "Week 5 coursework";
            ((System.ComponentModel.ISupportInitialize)(this.picApples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarrots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picApples;
        private System.Windows.Forms.PictureBox picPeas;
        private System.Windows.Forms.PictureBox picPeach;
        private System.Windows.Forms.PictureBox picCarrots;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblApples;
        private System.Windows.Forms.Label lblPeas;
        private System.Windows.Forms.Label lblPeach;
        private System.Windows.Forms.Label lblCarrots;
    }
}

