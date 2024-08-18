namespace CarStoreApp
{
    partial class CustomerForm
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
            btnLogout = new Button();
            btnOrders = new Button();
            btnViewCarParts = new Button();
            btnViewCars = new Button();
            btnDashboard = new Button();
            panelMainContent = new Panel();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.LightBlue;
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnOrders);
            panelSideMenu.Controls.Add(btnViewCarParts);
            panelSideMenu.Controls.Add(btnViewCars);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(131, 612);
            panelSideMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SlateGray;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.MenuText;
            btnLogout.Location = new Point(0, 566);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 46);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.LightSkyBlue;
            btnOrders.Dock = DockStyle.Top;
            btnOrders.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnOrders.ForeColor = SystemColors.MenuText;
            btnOrders.Location = new Point(0, 163);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(131, 48);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "My Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // btnViewCarParts
            // 
            btnViewCarParts.BackColor = Color.LightSkyBlue;
            btnViewCarParts.Dock = DockStyle.Top;
            btnViewCarParts.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnViewCarParts.ForeColor = SystemColors.MenuText;
            btnViewCarParts.Location = new Point(0, 110);
            btnViewCarParts.Name = "btnViewCarParts";
            btnViewCarParts.Size = new Size(131, 53);
            btnViewCarParts.TabIndex = 3;
            btnViewCarParts.Text = "View Car Parts";
            btnViewCarParts.UseVisualStyleBackColor = false;
            btnViewCarParts.Click += BtnViewCarParts_Click;
            // 
            // btnViewCars
            // 
            btnViewCars.BackColor = Color.LightSkyBlue;
            btnViewCars.Dock = DockStyle.Top;
            btnViewCars.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnViewCars.ForeColor = SystemColors.MenuText;
            btnViewCars.Location = new Point(0, 56);
            btnViewCars.Name = "btnViewCars";
            btnViewCars.Size = new Size(131, 54);
            btnViewCars.TabIndex = 2;
            btnViewCars.Text = "View Cars";
            btnViewCars.UseVisualStyleBackColor = false;
            btnViewCars.Click += BtnViewCars_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.LightSkyBlue;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = SystemColors.MenuText;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 56);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += BtnDashboard_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(131, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(844, 612);
            panelMainContent.TabIndex = 0;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 612);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideMenu);
            MaximizeBox = false;
            Name = "CustomerForm";
            Text = "Customer Dashboard";
            panelSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

    }
}