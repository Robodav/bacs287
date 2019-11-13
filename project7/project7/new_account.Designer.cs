namespace project7
{
    partial class frmNewAccount
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTogglePassView = new System.Windows.Forms.Button();
            this.lblTogglePassView = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(80, 87);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(70, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(53, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(142, 87);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(47, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(164, 309);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Submit";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTogglePassView
            // 
            this.btnTogglePassView.Location = new System.Drawing.Point(284, 201);
            this.btnTogglePassView.Name = "btnTogglePassView";
            this.btnTogglePassView.Size = new System.Drawing.Size(22, 22);
            this.btnTogglePassView.TabIndex = 9;
            this.btnTogglePassView.UseVisualStyleBackColor = true;
            this.btnTogglePassView.Click += new System.EventHandler(this.btnTogglePassView_Click);
            // 
            // lblTogglePassView
            // 
            this.lblTogglePassView.AutoSize = true;
            this.lblTogglePassView.Location = new System.Drawing.Point(312, 206);
            this.lblTogglePassView.Name = "lblTogglePassView";
            this.lblTogglePassView.Size = new System.Drawing.Size(79, 13);
            this.lblTogglePassView.TabIndex = 10;
            this.lblTogglePassView.Text = "Toggle Visibility";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(142, 248);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(136, 20);
            this.txtConfirm.TabIndex = 12;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Confirm Password:";
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 384);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTogglePassView);
            this.Controls.Add(this.btnTogglePassView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "frmNewAccount";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTogglePassView;
        private System.Windows.Forms.Label lblTogglePassView;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label1;
    }
}