namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class OrderCarPartDetail
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
            groupBoxOrderInfo = new GroupBox();
            lblTotalAmount = new Label();
            lblTotalAmountLabel = new Label();
            lblOrderDate = new Label();
            lblOrderDateLabel = new Label();
            lblOrderID = new Label();
            lblOrderIDLabel = new Label();
            btnClose = new Button();
            groupBoxCustomerInfo = new GroupBox();
            lblPhone = new Label();
            lblPhoneLabel = new Label();
            lblEmail = new Label();
            lblEmailLabel = new Label();
            lblLastName = new Label();
            lblLastNameLabel = new Label();
            lblFirstName = new Label();
            lblFirstNameLabel = new Label();
            lblCustomerID = new Label();
            lblCustomerIDLabel = new Label();
            groupBoxCarParts = new GroupBox();
            dgvCarParts = new DataGridView();
            groupBoxOrderInfo.SuspendLayout();
            groupBoxCustomerInfo.SuspendLayout();
            groupBoxCarParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarParts).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOrderInfo
            // 
            groupBoxOrderInfo.BackColor = Color.Azure;
            groupBoxOrderInfo.Controls.Add(lblTotalAmount);
            groupBoxOrderInfo.Controls.Add(lblTotalAmountLabel);
            groupBoxOrderInfo.Controls.Add(lblOrderDate);
            groupBoxOrderInfo.Controls.Add(lblOrderDateLabel);
            groupBoxOrderInfo.Controls.Add(lblOrderID);
            groupBoxOrderInfo.Controls.Add(lblOrderIDLabel);
            groupBoxOrderInfo.Location = new Point(18, 12);
            groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            groupBoxOrderInfo.Size = new Size(399, 120);
            groupBoxOrderInfo.TabIndex = 1;
            groupBoxOrderInfo.TabStop = false;
            groupBoxOrderInfo.Text = "Order Information";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(115, 90);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 15);
            lblTotalAmount.TabIndex = 5;
            // 
            // lblTotalAmountLabel
            // 
            lblTotalAmountLabel.AutoSize = true;
            lblTotalAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmountLabel.Location = new Point(20, 90);
            lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            lblTotalAmountLabel.Size = new Size(85, 15);
            lblTotalAmountLabel.TabIndex = 4;
            lblTotalAmountLabel.Text = "Total Amount:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(115, 60);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(0, 15);
            lblOrderDate.TabIndex = 3;
            // 
            // lblOrderDateLabel
            // 
            lblOrderDateLabel.AutoSize = true;
            lblOrderDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderDateLabel.Location = new Point(20, 60);
            lblOrderDateLabel.Name = "lblOrderDateLabel";
            lblOrderDateLabel.Size = new Size(73, 15);
            lblOrderDateLabel.TabIndex = 2;
            lblOrderDateLabel.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(115, 30);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(0, 15);
            lblOrderID.TabIndex = 1;
            // 
            // lblOrderIDLabel
            // 
            lblOrderIDLabel.AutoSize = true;
            lblOrderIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderIDLabel.Location = new Point(20, 30);
            lblOrderIDLabel.Name = "lblOrderIDLabel";
            lblOrderIDLabel.Size = new Size(59, 15);
            lblOrderIDLabel.TabIndex = 0;
            lblOrderIDLabel.Text = "Order ID:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SlateGray;
            btnClose.Location = new Point(805, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 36);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // groupBoxCustomerInfo
            // 
            groupBoxCustomerInfo.BackColor = Color.Azure;
            groupBoxCustomerInfo.Controls.Add(lblPhone);
            groupBoxCustomerInfo.Controls.Add(lblPhoneLabel);
            groupBoxCustomerInfo.Controls.Add(lblEmail);
            groupBoxCustomerInfo.Controls.Add(lblEmailLabel);
            groupBoxCustomerInfo.Controls.Add(lblLastName);
            groupBoxCustomerInfo.Controls.Add(lblLastNameLabel);
            groupBoxCustomerInfo.Controls.Add(lblFirstName);
            groupBoxCustomerInfo.Controls.Add(lblFirstNameLabel);
            groupBoxCustomerInfo.Controls.Add(lblCustomerID);
            groupBoxCustomerInfo.Controls.Add(lblCustomerIDLabel);
            groupBoxCustomerInfo.Location = new Point(441, 12);
            groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            groupBoxCustomerInfo.Size = new Size(506, 120);
            groupBoxCustomerInfo.TabIndex = 7;
            groupBoxCustomerInfo.TabStop = false;
            groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(335, 60);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 15);
            lblPhone.TabIndex = 9;
            // 
            // lblPhoneLabel
            // 
            lblPhoneLabel.AutoSize = true;
            lblPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneLabel.Location = new Point(276, 60);
            lblPhoneLabel.Name = "lblPhoneLabel";
            lblPhoneLabel.Size = new Size(45, 15);
            lblPhoneLabel.TabIndex = 8;
            lblPhoneLabel.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(335, 30);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 15);
            lblEmail.TabIndex = 7;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.AutoSize = true;
            lblEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailLabel.Location = new Point(276, 30);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(39, 15);
            lblEmailLabel.TabIndex = 6;
            lblEmailLabel.Text = "Email:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(110, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 15);
            lblLastName.TabIndex = 5;
            // 
            // lblLastNameLabel
            // 
            lblLastNameLabel.AutoSize = true;
            lblLastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastNameLabel.Location = new Point(20, 90);
            lblLastNameLabel.Name = "lblLastNameLabel";
            lblLastNameLabel.Size = new Size(68, 15);
            lblLastNameLabel.TabIndex = 4;
            lblLastNameLabel.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(110, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 15);
            lblFirstName.TabIndex = 3;
            // 
            // lblFirstNameLabel
            // 
            lblFirstNameLabel.AutoSize = true;
            lblFirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstNameLabel.Location = new Point(20, 60);
            lblFirstNameLabel.Name = "lblFirstNameLabel";
            lblFirstNameLabel.Size = new Size(70, 15);
            lblFirstNameLabel.TabIndex = 2;
            lblFirstNameLabel.Text = "First Name:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(110, 30);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 15);
            lblCustomerID.TabIndex = 1;
            // 
            // lblCustomerIDLabel
            // 
            lblCustomerIDLabel.AutoSize = true;
            lblCustomerIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerIDLabel.Location = new Point(20, 30);
            lblCustomerIDLabel.Name = "lblCustomerIDLabel";
            lblCustomerIDLabel.Size = new Size(80, 15);
            lblCustomerIDLabel.TabIndex = 0;
            lblCustomerIDLabel.Text = "Customer ID:";
            // 
            // groupBoxCarParts
            // 
            groupBoxCarParts.Controls.Add(dgvCarParts);
            groupBoxCarParts.Location = new Point(18, 149);
            groupBoxCarParts.Name = "groupBoxCarParts";
            groupBoxCarParts.Size = new Size(929, 345);
            groupBoxCarParts.TabIndex = 8;
            groupBoxCarParts.TabStop = false;
            groupBoxCarParts.Text = "Order Car Parts";
            // 
            // dgvCarParts
            // 
            dgvCarParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarParts.BackgroundColor = Color.Azure;
            dgvCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarParts.Location = new Point(18, 30);
            dgvCarParts.Name = "dgvCarParts";
            dgvCarParts.RowHeadersWidth = 51;
            dgvCarParts.Size = new Size(893, 294);
            dgvCarParts.TabIndex = 6;
            // 
            // OrderCarPartDetail
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            ClientSize = new Size(968, 571);
            Controls.Add(groupBoxCarParts);
            Controls.Add(btnClose);
            Controls.Add(groupBoxCustomerInfo);
            Controls.Add(groupBoxOrderInfo);
            MaximizeBox = false;
            Name = "OrderCarPartDetail";
            groupBoxOrderInfo.ResumeLayout(false);
            groupBoxOrderInfo.PerformLayout();
            groupBoxCustomerInfo.ResumeLayout(false);
            groupBoxCustomerInfo.PerformLayout();
            groupBoxCarParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarParts).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLastNameLabel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFirstNameLabel;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerIDLabel;
        private System.Windows.Forms.GroupBox groupBoxCarParts;
        private System.Windows.Forms.DataGridView dgvCarParts;
    }
}