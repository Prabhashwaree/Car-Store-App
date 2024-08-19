﻿using System;
using System.Windows.Forms;
using CarStoreApp.Forms.post_login_customer.customer_controls;

namespace CarStoreApp
{
    public partial class CustomerForm : Form
    {
        private Panel panelSideMenu;
        private Button btnViewCars;
        private Button btnViewCarParts;
        private Button btnOrders;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel panelMainContent;

        private int customerID;

        public CustomerForm(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            // Load dashboard controls into panelMainContent initially 
            panelMainContent.Controls.Clear();
            s dashboard = new s(customerID);
            dashboard.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(dashboard);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard(); // Load the default dashboard view
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //close admin window
            this.Close();
        }

        private void BtnViewCars_Click(object sender, EventArgs e)
        {
            // Load view car controls into panelMainContent
            panelMainContent.Controls.Clear();
            ViewCarControl carControl = new ViewCarControl(customerID);
            carControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(carControl);
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            // Load order controls into panelMainContent
            panelMainContent.Controls.Clear();
            OrderControl orderControl = new OrderControl(customerID);
            orderControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(orderControl);
        }
        private void BtnViewCarParts_Click(object sender, EventArgs e)
        {
            // Load view car parts controls into panelMainContent
            panelMainContent.Controls.Clear();
            ViewCarPartControl carPartControl = new ViewCarPartControl(customerID);
            carPartControl.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(carPartControl);
        }
        

    }
}
