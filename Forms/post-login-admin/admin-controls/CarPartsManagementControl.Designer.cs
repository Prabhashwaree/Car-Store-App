namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class CarPartsManagementControl
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
            txtPartName = new TextBox();
            txtPartNumber = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtSearch = new TextBox();
            txtQuatity = new TextBox();
            lblPartName = new Label();
            lblPartNumber = new Label();
            lblPrice = new Label();
            btnSave = new Button();
            dataGridViewCarParts = new DataGridView();
            lblQuantity = new Label();
            groupBoxSearch = new GroupBox();
            groupBoxDescription = new GroupBox();
            groupBoxCarPartDetails = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).BeginInit();
            groupBoxSearch.SuspendLayout();
            groupBoxDescription.SuspendLayout();
            groupBoxCarPartDetails.SuspendLayout();
            SuspendLayout();
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(141, 28);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(316, 23);
            txtPartName.TabIndex = 0;
            // 
            // txtPartNumber
            // 
            txtPartNumber.Location = new Point(141, 58);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.Size = new Size(316, 23);
            txtPartNumber.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(141, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(316, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(21, 28);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(311, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // txtQuatity
            // 
            txtQuatity.Location = new Point(141, 121);
            txtQuatity.Name = "txtQuatity";
            txtQuatity.Size = new Size(316, 23);
            txtQuatity.TabIndex = 11;
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPartName.Location = new Point(21, 31);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(66, 15);
            lblPartName.TabIndex = 4;
            lblPartName.Text = "Part Name";
            // 
            // lblPartNumber
            // 
            lblPartNumber.AutoSize = true;
            lblPartNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPartNumber.Location = new Point(21, 61);
            lblPartNumber.Name = "lblPartNumber";
            lblPartNumber.Size = new Size(79, 15);
            lblPartNumber.TabIndex = 5;
            lblPartNumber.Text = "Part Number";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(21, 91);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Location = new Point(684, 107);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 37);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSaveOrEdit_Click;
            // 
            // dataGridViewCarParts
            // 
            dataGridViewCarParts.BackgroundColor = Color.Azure;
            dataGridViewCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarParts.Location = new Point(23, 258);
            dataGridViewCarParts.Name = "dataGridViewCarParts";
            dataGridViewCarParts.RowHeadersWidth = 51;
            dataGridViewCarParts.RowTemplate.Height = 24;
            dataGridViewCarParts.Size = new Size(854, 241);
            dataGridViewCarParts.TabIndex = 9;
            dataGridViewCarParts.CellClick += DataGridViewCars_CellClick;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuantity.Location = new Point(20, 121);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(55, 15);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Location = new Point(501, 190);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(376, 62);
            groupBoxSearch.TabIndex = 19;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // groupBoxDescription
            // 
            groupBoxDescription.BackColor = Color.Azure;
            groupBoxDescription.Controls.Add(txtDescription);
            groupBoxDescription.Location = new Point(501, 30);
            groupBoxDescription.Name = "groupBoxDescription";
            groupBoxDescription.Size = new Size(350, 62);
            groupBoxDescription.TabIndex = 18;
            groupBoxDescription.TabStop = false;
            groupBoxDescription.Text = "Description";
            // 
            // groupBoxCarPartDetails
            // 
            groupBoxCarPartDetails.BackColor = Color.Azure;
            groupBoxCarPartDetails.Controls.Add(lblPartName);
            groupBoxCarPartDetails.Controls.Add(txtPartName);
            groupBoxCarPartDetails.Controls.Add(txtPartNumber);
            groupBoxCarPartDetails.Controls.Add(txtQuatity);
            groupBoxCarPartDetails.Controls.Add(btnSave);
            groupBoxCarPartDetails.Controls.Add(txtPrice);
            groupBoxCarPartDetails.Controls.Add(lblQuantity);
            groupBoxCarPartDetails.Controls.Add(lblPartNumber);
            groupBoxCarPartDetails.Controls.Add(lblPrice);
            groupBoxCarPartDetails.Location = new Point(23, 11);
            groupBoxCarPartDetails.Name = "groupBoxCarPartDetails";
            groupBoxCarPartDetails.Size = new Size(854, 156);
            groupBoxCarPartDetails.TabIndex = 17;
            groupBoxCarPartDetails.TabStop = false;
            groupBoxCarPartDetails.Text = "Car Part Details";
            // 
            // CarPartsManagementControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxDescription);
            Controls.Add(groupBoxCarPartDetails);
            Controls.Add(dataGridViewCarParts);
            Name = "CarPartsManagementControl";
            Size = new Size(901, 526);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxDescription.ResumeLayout(false);
            groupBoxDescription.PerformLayout();
            groupBoxCarPartDetails.ResumeLayout(false);
            groupBoxCarPartDetails.PerformLayout();
            ResumeLayout(false);
        }


        #endregion


    }
}
