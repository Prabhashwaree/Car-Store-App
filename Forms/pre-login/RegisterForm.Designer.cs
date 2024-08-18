namespace CarStoreApp
{
    partial class RegisterForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtNIC = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblNIC = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            lbSignup = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(108, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(108, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(108, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(108, 167);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(210, 23);
            txtNIC.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(108, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(108, 304);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(210, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = SystemColors.ControlLightLight;
            lblFirstName.Location = new Point(29, 68);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = SystemColors.ControlLightLight;
            lblLastName.Location = new Point(29, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(29, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Username";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.BackColor = SystemColors.ControlLightLight;
            lblNIC.Location = new Point(29, 167);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(27, 15);
            lblNIC.TabIndex = 11;
            lblNIC.Text = "NIC";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(29, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(29, 234);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.ControlLightLight;
            lblPhone.Location = new Point(29, 269);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.ControlLightLight;
            lblAddress.Location = new Point(29, 304);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DeepSkyBlue;
            btnRegister.Location = new Point(169, 344);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(149, 28);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SlateGray;
            btnCancel.Location = new Point(29, 344);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 28);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = CarStoreApp1.Properties.Resources.login_image5;
            pictureBox1.Location = new Point(347, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 389);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.BackColor = Color.FloralWhite;
            lbSignup.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignup.Location = new Point(141, 21);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(83, 26);
            lbSignup.TabIndex = 19;
            lbSignup.Text = "Signup";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Window;
            flowLayoutPanel1.Location = new Point(-2, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 389);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 388);
            Controls.Add(lbSignup);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblNIC);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtNIC);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "RegisterForm";
            Text = "Register Customer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbSignup;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}