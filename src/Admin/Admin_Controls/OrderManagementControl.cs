﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarStoreApp.Forms.post_login_customer.customer_controls;

namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    public partial class OrderManagementControl : UserControl
    {
        private GroupBox grpCarPartOrders;
        private DataGridView dgvCarPartOrders;
        private GroupBox grpCarOrders;
        private DataGridView dgvCarOrders;

        string connectionString = "Data Source=DESKTOP-SFJGOEO\\SQLEXPRESS;Initial Catalog=CarStoreDB;Integrated Security=True;Encrypt=False";

        public OrderManagementControl()
        {
            InitializeComponent();
            LoadCarOrders();
            LoadCarPartsOrders();
        }

        private void LoadCarOrders()
        {
            try
            {
                string query = "SELECT OrderID, CarID, OrderDate, TotalAmount FROM CustomerOrder WHERE CarID IS NOT NULL";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable carOrdersTable = new DataTable();
                    adapter.Fill(carOrdersTable);
                    dgvCarOrders.DataSource = carOrdersTable;

                    // Add "Edit" button column
                    if (!dgvCarOrders.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "View",
                            Text = "View",
                            UseColumnTextForButtonValue = true
                        };
                        dgvCarOrders.Columns.Add(viewButtonColumn);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarPartsOrders()
        {
            try
            {
                string query = "SELECT OrderID, OrderDate, TotalAmount FROM CustomerOrder WHERE CarID IS NULL";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable carPartsOrdersTable = new DataTable();
                    adapter.Fill(carPartsOrdersTable);
                    dgvCarPartOrders.DataSource = carPartsOrdersTable;

                    // Add "Edit" button column
                    if (!dgvCarPartOrders.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "View",
                            Text = "View",
                            UseColumnTextForButtonValue = true
                        };
                        dgvCarPartOrders.Columns.Add(viewButtonColumn);
                    }
                }
            }

            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCarOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarOrders.Columns["View"].Index && e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dgvCarOrders.Rows[e.RowIndex].Cells["OrderId"].Value);
                // Open OrderCarDetail form
                OrderCarDetail orderCarDetailForm = new OrderCarDetail(orderId);
                orderCarDetailForm.ShowDialog();
            }
        }

        private void DgvCarPartOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarPartOrders.Columns["View"].Index && e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dgvCarPartOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                // Open OrderCarPartDetail form
                OrderCarPartDetail orderCarPartDetailForm = new OrderCarPartDetail(orderId);
                orderCarPartDetailForm.ShowDialog();
            }
        }
    }
}
