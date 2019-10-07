namespace project3
{
    partial class frmProject3
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
            this.picSandwich = new System.Windows.Forms.PictureBox();
            this.picFries = new System.Windows.Forms.PictureBox();
            this.picNuggets = new System.Windows.Forms.PictureBox();
            this.picSalad = new System.Windows.Forms.PictureBox();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.picDrPepper = new System.Windows.Forms.PictureBox();
            this.groupNutrition = new System.Windows.Forms.GroupBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblSodium = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtSodium = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.listItems = new System.Windows.Forms.ListBox();
            this.lblSandwich = new System.Windows.Forms.Label();
            this.lblNuggets = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.lblFries = new System.Windows.Forms.Label();
            this.lblSalad = new System.Windows.Forms.Label();
            this.lblDrPepper = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSandwich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuggets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).BeginInit();
            this.groupNutrition.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSandwich
            // 
            this.picSandwich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSandwich.Image = global::project3.Properties.Resources.Chicken_Sandwich;
            this.picSandwich.Location = new System.Drawing.Point(50, 31);
            this.picSandwich.Name = "picSandwich";
            this.picSandwich.Size = new System.Drawing.Size(190, 130);
            this.picSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSandwich.TabIndex = 0;
            this.picSandwich.TabStop = false;
            this.picSandwich.Click += new System.EventHandler(this.PicSandwich_Click);
            // 
            // picFries
            // 
            this.picFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFries.Image = global::project3.Properties.Resources.fries;
            this.picFries.Location = new System.Drawing.Point(50, 202);
            this.picFries.Name = "picFries";
            this.picFries.Size = new System.Drawing.Size(190, 130);
            this.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFries.TabIndex = 1;
            this.picFries.TabStop = false;
            this.picFries.Click += new System.EventHandler(this.PicFries_Click);
            // 
            // picNuggets
            // 
            this.picNuggets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNuggets.Image = global::project3.Properties.Resources.nuggets;
            this.picNuggets.Location = new System.Drawing.Point(266, 31);
            this.picNuggets.Name = "picNuggets";
            this.picNuggets.Size = new System.Drawing.Size(190, 130);
            this.picNuggets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNuggets.TabIndex = 2;
            this.picNuggets.TabStop = false;
            this.picNuggets.Click += new System.EventHandler(this.PicNuggets_Click);
            // 
            // picSalad
            // 
            this.picSalad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSalad.Image = global::project3.Properties.Resources.salad;
            this.picSalad.Location = new System.Drawing.Point(266, 202);
            this.picSalad.Name = "picSalad";
            this.picSalad.Size = new System.Drawing.Size(190, 130);
            this.picSalad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSalad.TabIndex = 3;
            this.picSalad.TabStop = false;
            this.picSalad.Click += new System.EventHandler(this.PicSalad_Click);
            // 
            // picCola
            // 
            this.picCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCola.Image = global::project3.Properties.Resources.CocaCola;
            this.picCola.Location = new System.Drawing.Point(485, 31);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(80, 130);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCola.TabIndex = 4;
            this.picCola.TabStop = false;
            this.picCola.Click += new System.EventHandler(this.PicCola_Click);
            // 
            // picDrPepper
            // 
            this.picDrPepper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDrPepper.Image = global::project3.Properties.Resources.Dr__Pepper;
            this.picDrPepper.Location = new System.Drawing.Point(485, 202);
            this.picDrPepper.Name = "picDrPepper";
            this.picDrPepper.Size = new System.Drawing.Size(80, 130);
            this.picDrPepper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDrPepper.TabIndex = 5;
            this.picDrPepper.TabStop = false;
            this.picDrPepper.Click += new System.EventHandler(this.PicDrPepper_Click);
            // 
            // groupNutrition
            // 
            this.groupNutrition.BackColor = System.Drawing.Color.White;
            this.groupNutrition.Controls.Add(this.txtProtein);
            this.groupNutrition.Controls.Add(this.txtFat);
            this.groupNutrition.Controls.Add(this.txtSodium);
            this.groupNutrition.Controls.Add(this.txtCalories);
            this.groupNutrition.Controls.Add(this.lblProtein);
            this.groupNutrition.Controls.Add(this.lblFat);
            this.groupNutrition.Controls.Add(this.lblSodium);
            this.groupNutrition.Controls.Add(this.lblCalories);
            this.groupNutrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNutrition.Location = new System.Drawing.Point(65, 370);
            this.groupNutrition.Name = "groupNutrition";
            this.groupNutrition.Size = new System.Drawing.Size(426, 106);
            this.groupNutrition.TabIndex = 6;
            this.groupNutrition.TabStop = false;
            this.groupNutrition.Text = "Nutritional Totals:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalories.Location = new System.Drawing.Point(26, 24);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(63, 18);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Calories";
            // 
            // lblSodium
            // 
            this.lblSodium.AutoSize = true;
            this.lblSodium.BackColor = System.Drawing.SystemColors.Control;
            this.lblSodium.Location = new System.Drawing.Point(149, 24);
            this.lblSodium.Name = "lblSodium";
            this.lblSodium.Size = new System.Drawing.Size(59, 18);
            this.lblSodium.TabIndex = 1;
            this.lblSodium.Text = "Sodium";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.BackColor = System.Drawing.SystemColors.Control;
            this.lblFat.Location = new System.Drawing.Point(238, 24);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(29, 18);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "Fat";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.SystemColors.Control;
            this.lblProtein.Location = new System.Drawing.Point(311, 24);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(55, 18);
            this.lblProtein.TabIndex = 3;
            this.lblProtein.Text = "Protein";
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(29, 55);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.ReadOnly = true;
            this.txtCalories.Size = new System.Drawing.Size(94, 24);
            this.txtCalories.TabIndex = 4;
            this.txtCalories.Text = "0";
            // 
            // txtSodium
            // 
            this.txtSodium.Location = new System.Drawing.Point(151, 55);
            this.txtSodium.Name = "txtSodium";
            this.txtSodium.ReadOnly = true;
            this.txtSodium.Size = new System.Drawing.Size(57, 24);
            this.txtSodium.TabIndex = 6;
            this.txtSodium.Text = "0";
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(241, 55);
            this.txtFat.Name = "txtFat";
            this.txtFat.ReadOnly = true;
            this.txtFat.Size = new System.Drawing.Size(44, 24);
            this.txtFat.TabIndex = 7;
            this.txtFat.Text = "0";
            // 
            // txtProtein
            // 
            this.txtProtein.Location = new System.Drawing.Point(314, 55);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.ReadOnly = true;
            this.txtProtein.Size = new System.Drawing.Size(52, 24);
            this.txtProtein.TabIndex = 8;
            this.txtProtein.Text = "0";
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(590, 31);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(192, 368);
            this.listItems.TabIndex = 7;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            // 
            // lblSandwich
            // 
            this.lblSandwich.AutoSize = true;
            this.lblSandwich.Location = new System.Drawing.Point(50, 12);
            this.lblSandwich.Name = "lblSandwich";
            this.lblSandwich.Size = new System.Drawing.Size(126, 13);
            this.lblSandwich.TabIndex = 8;
            this.lblSandwich.Text = "Chicken Sandwich $3.15";
            // 
            // lblNuggets
            // 
            this.lblNuggets.AutoSize = true;
            this.lblNuggets.Location = new System.Drawing.Point(266, 12);
            this.lblNuggets.Name = "lblNuggets";
            this.lblNuggets.Size = new System.Drawing.Size(119, 13);
            this.lblNuggets.TabIndex = 9;
            this.lblNuggets.Text = "Chicken Nuggets $4.75";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(485, 12);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(58, 13);
            this.lblCola.TabIndex = 10;
            this.lblCola.Text = "Cola $2.75";
            // 
            // lblFries
            // 
            this.lblFries.AutoSize = true;
            this.lblFries.Location = new System.Drawing.Point(53, 183);
            this.lblFries.Name = "lblFries";
            this.lblFries.Size = new System.Drawing.Size(93, 13);
            this.lblFries.TabIndex = 11;
            this.lblFries.Text = "Waffle Fries $1.85";
            // 
            // lblSalad
            // 
            this.lblSalad.AutoSize = true;
            this.lblSalad.Location = new System.Drawing.Point(266, 183);
            this.lblSalad.Name = "lblSalad";
            this.lblSalad.Size = new System.Drawing.Size(106, 13);
            this.lblSalad.TabIndex = 12;
            this.lblSalad.Text = "Chicken Salad $7.19";
            // 
            // lblDrPepper
            // 
            this.lblDrPepper.AutoSize = true;
            this.lblDrPepper.Location = new System.Drawing.Point(485, 183);
            this.lblDrPepper.Name = "lblDrPepper";
            this.lblDrPepper.Size = new System.Drawing.Size(88, 13);
            this.lblDrPepper.TabIndex = 13;
            this.lblDrPepper.Text = "Dr. Pepper $2.75";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(590, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(609, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(649, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "0.00";
            // 
            // frmProject3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 488);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDrPepper);
            this.Controls.Add(this.lblSalad);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblNuggets);
            this.Controls.Add(this.lblSandwich);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.groupNutrition);
            this.Controls.Add(this.picDrPepper);
            this.Controls.Add(this.picCola);
            this.Controls.Add(this.picSalad);
            this.Controls.Add(this.picNuggets);
            this.Controls.Add(this.picFries);
            this.Controls.Add(this.picSandwich);
            this.Name = "frmProject3";
            this.Text = "Project 3 - Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picSandwich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuggets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrPepper)).EndInit();
            this.groupNutrition.ResumeLayout(false);
            this.groupNutrition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSandwich;
        private System.Windows.Forms.PictureBox picFries;
        private System.Windows.Forms.PictureBox picNuggets;
        private System.Windows.Forms.PictureBox picSalad;
        private System.Windows.Forms.PictureBox picCola;
        private System.Windows.Forms.PictureBox picDrPepper;
        private System.Windows.Forms.GroupBox groupNutrition;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.TextBox txtSodium;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblSodium;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.ListBox listItems;
        private System.Windows.Forms.Label lblSandwich;
        private System.Windows.Forms.Label lblNuggets;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.Label lblSalad;
        private System.Windows.Forms.Label lblDrPepper;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

