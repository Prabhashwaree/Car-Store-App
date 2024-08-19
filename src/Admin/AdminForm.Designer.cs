using System;

namespace CarStoreApp
{
    partial class AdminForm
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
            panelSideMenu = new Panel();
            lblCarStores = new Label();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnReports = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            btnCarParts = new Button();
            btnCars = new Button();
            btnDashboard = new Button();
            panelMainContent = new Panel();
            panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.LightBlue;
            panelSideMenu.Controls.Add(lblCarStores);
            panelSideMenu.Controls.Add(pictureBox1);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnReports);
            panelSideMenu.Controls.Add(btnOrders);
            panelSideMenu.Controls.Add(btnCustomers);
            panelSideMenu.Controls.Add(btnCarParts);
            panelSideMenu.Controls.Add(btnCars);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Padding = new Padding(0, 60, 0, 0);
            panelSideMenu.Size = new Size(131, 612);
            panelSideMenu.TabIndex = 1;
            // 
            // lblCarStores
            // 
            lblCarStores.AutoSize = true;
            lblCarStores.BackColor = Color.DarkSlateGray;
            lblCarStores.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCarStores.ForeColor = SystemColors.ControlLightLight;
            lblCarStores.Location = new Point(7, 17);
            lblCarStores.Name = "lblCarStores";
            lblCarStores.Size = new Size(116, 28);
            lblCarStores.TabIndex = 0;
            lblCarStores.Text = "Car Stores";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SlateGray;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLogout.Location = new Point(0, 566);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 46);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.LightSkyBlue;
            btnReports.Dock = DockStyle.Top;
            btnReports.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnReports.Location = new Point(0, 327);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(131, 54);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += BtnReports_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.LightSkyBlue;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnOrders.Location = new Point(0, 279);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(131, 48);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.LightSkyBlue;
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCustomers.Location = new Point(0, 226);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(131, 53);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += BtnCustomers_Click;
            // 
            // btnCarParts
            // 
            btnCarParts.BackColor = Color.LightSkyBlue;
            btnCarParts.Dock = DockStyle.Top;
            btnCarParts.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCarParts.Location = new Point(0, 172);
            btnCarParts.Name = "btnCarParts";
            btnCarParts.Size = new Size(131, 54);
            btnCarParts.TabIndex = 4;
            btnCarParts.Text = "Car Parts";
            btnCarParts.UseVisualStyleBackColor = false;
            btnCarParts.Click += BtnCarParts_Click;
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.LightSkyBlue;
            btnCars.Dock = DockStyle.Top;
            btnCars.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCars.Location = new Point(0, 116);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(131, 56);
            btnCars.TabIndex = 5;
            btnCars.Text = "Cars";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += BtnCars_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightSkyBlue;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDashboard.Location = new Point(0, 60);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 56);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Overview";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += BtnDashboard_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(131, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(887, 612);
            panelMainContent.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 612);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideMenu);
            MaximizeBox = false;
            Name = "AdminForm";
            Text = "Admin Dashboard";
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCarStores;
    }
}