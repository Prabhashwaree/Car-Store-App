using System.Windows.Forms;
using System;

namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class CustomerManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            dataGridViewCustomers = new DataGridView();
            groupBoxSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(290, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.BackgroundColor = Color.Azure;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(20, 93);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.RowTemplate.Height = 24;
            dataGridViewCustomers.Size = new Size(845, 367);
            dataGridViewCustomers.TabIndex = 1;
            dataGridViewCustomers.CellClick += DataGridViewCustomers_CellClick;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Location = new Point(536, 10);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(329, 62);
            groupBoxSearch.TabIndex = 20;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // CustomerManagementControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            Controls.Add(groupBoxSearch);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomerManagementControl";
            Size = new Size(891, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

    }
}
