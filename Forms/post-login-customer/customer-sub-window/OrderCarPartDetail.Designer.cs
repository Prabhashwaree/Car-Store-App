namespace CarStoreApp.Forms.post_login_customer.customer_controls
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
            dgvCarParts = new DataGridView();
            btnClose = new Button();
            groupBoxOrderDetails = new GroupBox();
            lblStaticAmount = new Label();
            lblStaticOrderDate = new Label();
            lblStaticOrderID = new Label();
            lblOrderId = new Label();
            lblOrderDate = new Label();
            lblTotalAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarParts).BeginInit();
            groupBoxOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCarParts
            // 
            dgvCarParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarParts.BackgroundColor = Color.Azure;
            dgvCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarParts.Location = new Point(18, 97);
            dgvCarParts.Name = "dgvCarParts";
            dgvCarParts.RowHeadersWidth = 51;
            dgvCarParts.Size = new Size(754, 336);
            dgvCarParts.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SlateGray;
            btnClose.Location = new Point(579, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(193, 37);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // groupBoxOrderDetails
            // 
            groupBoxOrderDetails.BackColor = Color.Azure;
            groupBoxOrderDetails.Controls.Add(lblStaticAmount);
            groupBoxOrderDetails.Controls.Add(lblStaticOrderDate);
            groupBoxOrderDetails.Controls.Add(lblStaticOrderID);
            groupBoxOrderDetails.Controls.Add(lblOrderId);
            groupBoxOrderDetails.Controls.Add(lblOrderDate);
            groupBoxOrderDetails.Controls.Add(lblTotalAmount);
            groupBoxOrderDetails.Location = new Point(18, 11);
            groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            groupBoxOrderDetails.Size = new Size(754, 64);
            groupBoxOrderDetails.TabIndex = 8;
            groupBoxOrderDetails.TabStop = false;
            groupBoxOrderDetails.Text = "Order Details";
            // 
            // lblStaticAmount
            // 
            lblStaticAmount.AutoSize = true;
            lblStaticAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticAmount.Location = new Point(524, 31);
            lblStaticAmount.Name = "lblStaticAmount";
            lblStaticAmount.Size = new Size(85, 15);
            lblStaticAmount.TabIndex = 13;
            lblStaticAmount.Text = "Total Amount:";
            // 
            // lblStaticOrderDate
            // 
            lblStaticOrderDate.AutoSize = true;
            lblStaticOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticOrderDate.Location = new Point(228, 31);
            lblStaticOrderDate.Name = "lblStaticOrderDate";
            lblStaticOrderDate.Size = new Size(73, 15);
            lblStaticOrderDate.TabIndex = 12;
            lblStaticOrderDate.Text = "Order Date:";
            // 
            // lblStaticOrderID
            // 
            lblStaticOrderID.AutoSize = true;
            lblStaticOrderID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticOrderID.Location = new Point(23, 30);
            lblStaticOrderID.Name = "lblStaticOrderID";
            lblStaticOrderID.Size = new Size(59, 15);
            lblStaticOrderID.TabIndex = 11;
            lblStaticOrderID.Text = "Order ID:";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(109, 31);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(0, 15);
            lblOrderId.TabIndex = 8;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(314, 32);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(0, 15);
            lblOrderDate.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(616, 31);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 15);
            lblTotalAmount.TabIndex = 10;
            // 
            // OrderCarPartDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_7741479;
            ClientSize = new Size(784, 488);
            Controls.Add(groupBoxOrderDetails);
            Controls.Add(dgvCarParts);
            Controls.Add(btnClose);
            Name = "OrderCarPartDetail";
            Text = "Order Car Part Details";
            ((System.ComponentModel.ISupportInitialize)dgvCarParts).EndInit();
            groupBoxOrderDetails.ResumeLayout(false);
            groupBoxOrderDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

    }
}