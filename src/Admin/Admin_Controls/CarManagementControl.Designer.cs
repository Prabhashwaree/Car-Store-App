namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class CarManagementControl
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
            dataGridViewCars = new DataGridView();
            btnSave = new Button();
            txtSearch = new TextBox();
            groupBoxCarDetails = new GroupBox();
            lblPrice = new Label();
            groupBoxDescription = new GroupBox();
            txtDescription = new TextBox();
            lblYear = new Label();
            lblManufacturer = new Label();
            lblModel = new Label();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtManufacturer = new TextBox();
            txtModel = new TextBox();
            groupBoxSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            groupBoxCarDetails.SuspendLayout();
            groupBoxDescription.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.BackgroundColor = Color.Azure;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(17, 263);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(865, 250);
            dataGridViewCars.TabIndex = 0;
            dataGridViewCars.CellClick += DataGridViewCars_CellClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Location = new Point(688, 103);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSaveOrEdit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // groupBoxCarDetails
            // 
            groupBoxCarDetails.BackColor = Color.Azure;
            groupBoxCarDetails.Controls.Add(lblPrice);
            groupBoxCarDetails.Controls.Add(groupBoxDescription);
            groupBoxCarDetails.Controls.Add(btnSave);
            groupBoxCarDetails.Controls.Add(lblYear);
            groupBoxCarDetails.Controls.Add(lblManufacturer);
            groupBoxCarDetails.Controls.Add(lblModel);
            groupBoxCarDetails.Controls.Add(txtPrice);
            groupBoxCarDetails.Controls.Add(txtYear);
            groupBoxCarDetails.Controls.Add(txtManufacturer);
            groupBoxCarDetails.Controls.Add(txtModel);
            groupBoxCarDetails.Location = new Point(17, 13);
            groupBoxCarDetails.Name = "groupBoxCarDetails";
            groupBoxCarDetails.Size = new Size(865, 156);
            groupBoxCarDetails.TabIndex = 14;
            groupBoxCarDetails.TabStop = false;
            groupBoxCarDetails.Text = "Car Details";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(19, 117);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Price:";
            // 
            // groupBoxDescription
            // 
            groupBoxDescription.Controls.Add(txtDescription);
            groupBoxDescription.Location = new Point(522, 22);
            groupBoxDescription.Name = "groupBoxDescription";
            groupBoxDescription.Size = new Size(322, 64);
            groupBoxDescription.TabIndex = 15;
            groupBoxDescription.TabStop = false;
            groupBoxDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(22, 22);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(284, 30);
            txtDescription.TabIndex = 6;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYear.Location = new Point(19, 88);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(34, 15);
            lblYear.TabIndex = 17;
            lblYear.Text = "Year:";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblManufacturer.Location = new Point(19, 59);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(87, 15);
            lblManufacturer.TabIndex = 16;
            lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModel.Location = new Point(20, 32);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(45, 15);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 114);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(256, 23);
            txtPrice.TabIndex = 14;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(130, 85);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(256, 23);
            txtYear.TabIndex = 13;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(130, 56);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(256, 23);
            txtManufacturer.TabIndex = 12;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(130, 29);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(256, 23);
            txtModel.TabIndex = 11;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Location = new Point(539, 191);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(343, 62);
            groupBoxSearch.TabIndex = 16;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // CarManagementControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxCarDetails);
            Controls.Add(dataGridViewCars);
            Name = "CarManagementControl";
            Size = new Size(901, 526);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            groupBoxCarDetails.ResumeLayout(false);
            groupBoxCarDetails.PerformLayout();
            groupBoxDescription.ResumeLayout(false);
            groupBoxDescription.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


    }
}
