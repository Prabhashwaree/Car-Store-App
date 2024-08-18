using System.Windows.Forms;

namespace CarStoreApp
{
    partial class LoginForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            cmbRole = new ComboBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            lbLogin = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbType = new Label();
            lbText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(79, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ControlLightLight;
            lblPassword.Cursor = Cursors.IBeam;
            lblPassword.Location = new Point(79, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(79, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(79, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Location = new Point(79, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Azure;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Customer", "Admin" });
            cmbRole.Location = new Point(79, 189);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 23);
            cmbRole.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.YellowGreen;
            btnRegister.Location = new Point(79, 296);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 28);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = CarStoreApp1.Properties.Resources._360_F_294688686_eBbqaZUVeRr8BoCDuhxsWl4fjwV51FcV;
            pictureBox1.Location = new Point(-15, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 360);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = Color.FloralWhite;
            lbLogin.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(151, 30);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(72, 26);
            lbLogin.TabIndex = 8;
            lbLogin.Text = "Login";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Window;
            flowLayoutPanel1.Location = new Point(43, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(271, 337);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.BackColor = SystemColors.ControlLightLight;
            lbType.Cursor = Cursors.IBeam;
            lbType.Location = new Point(79, 171);
            lbType.Name = "lbType";
            lbType.Size = new Size(31, 15);
            lbType.TabIndex = 10;
            lbType.Text = "Type";
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.BackColor = Color.FloralWhite;
            lbText.Cursor = Cursors.SizeAll;
            lbText.Location = new Point(116, 269);
            lbText.Name = "lbText";
            lbText.Size = new Size(131, 15);
            lbText.TabIndex = 11;
            lbText.Text = "Don't have an account?";
            // 
            // LoginForm
            // 
            ClientSize = new Size(796, 361);
            Controls.Add(lbText);
            Controls.Add(lbType);
            Controls.Add(lbLogin);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbType;
        private Label lbText;
    }

}

