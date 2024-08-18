using System;

namespace CarStoreApp.Forms.post_login_customer.customer_controls
{
    partial class OrderCarDetail
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
            grpOrderDetails = new GroupBox();
            btnClose = new Button();
            lblStaticDescription = new Label();
            lblStaticPrice = new Label();
            lblStaticYear = new Label();
            lblStaticManufact = new Label();
            lblStaticModel = new Label();
            lblStaticCarID = new Label();
            lblStaticAmount = new Label();
            lblStaticOrderDate = new Label();
            lblStaticOrderID = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            lblManufacturer = new Label();
            lblModel = new Label();
            lblCarID = new Label();
            lblTotalAmount = new Label();
            lblOrderDate = new Label();
            lblOrderID = new Label();
            grpOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpOrderDetails
            // 
            grpOrderDetails.BackColor = Color.Azure;
            grpOrderDetails.Controls.Add(btnClose);
            grpOrderDetails.Controls.Add(lblStaticDescription);
            grpOrderDetails.Controls.Add(lblStaticPrice);
            grpOrderDetails.Controls.Add(lblStaticYear);
            grpOrderDetails.Controls.Add(lblStaticManufact);
            grpOrderDetails.Controls.Add(lblStaticModel);
            grpOrderDetails.Controls.Add(lblStaticCarID);
            grpOrderDetails.Controls.Add(lblStaticAmount);
            grpOrderDetails.Controls.Add(lblStaticOrderDate);
            grpOrderDetails.Controls.Add(lblStaticOrderID);
            grpOrderDetails.Controls.Add(lblDescription);
            grpOrderDetails.Controls.Add(lblPrice);
            grpOrderDetails.Controls.Add(lblYear);
            grpOrderDetails.Controls.Add(lblManufacturer);
            grpOrderDetails.Controls.Add(lblModel);
            grpOrderDetails.Controls.Add(lblCarID);
            grpOrderDetails.Controls.Add(lblTotalAmount);
            grpOrderDetails.Controls.Add(lblOrderDate);
            grpOrderDetails.Controls.Add(lblOrderID);
            grpOrderDetails.Location = new Point(29, 16);
            grpOrderDetails.Margin = new Padding(4);
            grpOrderDetails.Name = "grpOrderDetails";
            grpOrderDetails.Padding = new Padding(4);
            grpOrderDetails.Size = new Size(528, 254);
            grpOrderDetails.TabIndex = 0;
            grpOrderDetails.TabStop = false;
            grpOrderDetails.Text = "Order Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SlateGray;
            btnClose.Location = new Point(326, 206);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // lblStaticDescription
            // 
            lblStaticDescription.AutoSize = true;
            lblStaticDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticDescription.Location = new Point(18, 152);
            lblStaticDescription.Name = "lblStaticDescription";
            lblStaticDescription.Size = new Size(77, 15);
            lblStaticDescription.TabIndex = 17;
            lblStaticDescription.Text = "Description: ";
            // 
            // lblStaticPrice
            // 
            lblStaticPrice.AutoSize = true;
            lblStaticPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticPrice.Location = new Point(262, 124);
            lblStaticPrice.Name = "lblStaticPrice";
            lblStaticPrice.Size = new Size(41, 15);
            lblStaticPrice.TabIndex = 16;
            lblStaticPrice.Text = "Price: ";
            lblStaticPrice.Click += lblStaticPrice_Click;
            // 
            // lblStaticYear
            // 
            lblStaticYear.AutoSize = true;
            lblStaticYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticYear.Location = new Point(18, 124);
            lblStaticYear.Name = "lblStaticYear";
            lblStaticYear.Size = new Size(37, 15);
            lblStaticYear.TabIndex = 15;
            lblStaticYear.Text = "Year: ";
            // 
            // lblStaticManufact
            // 
            lblStaticManufact.AutoSize = true;
            lblStaticManufact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticManufact.Location = new Point(262, 96);
            lblStaticManufact.Name = "lblStaticManufact";
            lblStaticManufact.Size = new Size(90, 15);
            lblStaticManufact.TabIndex = 14;
            lblStaticManufact.Text = "Manufacturer: ";
            // 
            // lblStaticModel
            // 
            lblStaticModel.AutoSize = true;
            lblStaticModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticModel.Location = new Point(18, 96);
            lblStaticModel.Name = "lblStaticModel";
            lblStaticModel.Size = new Size(48, 15);
            lblStaticModel.TabIndex = 13;
            lblStaticModel.Text = "Model: ";
            // 
            // lblStaticCarID
            // 
            lblStaticCarID.AutoSize = true;
            lblStaticCarID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticCarID.Location = new Point(262, 68);
            lblStaticCarID.Name = "lblStaticCarID";
            lblStaticCarID.Size = new Size(47, 15);
            lblStaticCarID.TabIndex = 12;
            lblStaticCarID.Text = "Car ID: ";
            // 
            // lblStaticAmount
            // 
            lblStaticAmount.AutoSize = true;
            lblStaticAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticAmount.Location = new Point(18, 68);
            lblStaticAmount.Name = "lblStaticAmount";
            lblStaticAmount.Size = new Size(88, 15);
            lblStaticAmount.TabIndex = 11;
            lblStaticAmount.Text = "Total Amount: ";
            // 
            // lblStaticOrderDate
            // 
            lblStaticOrderDate.AutoSize = true;
            lblStaticOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticOrderDate.Location = new Point(262, 42);
            lblStaticOrderDate.Name = "lblStaticOrderDate";
            lblStaticOrderDate.Size = new Size(76, 15);
            lblStaticOrderDate.TabIndex = 10;
            lblStaticOrderDate.Text = "Order Date: ";
            // 
            // lblStaticOrderID
            // 
            lblStaticOrderID.AutoSize = true;
            lblStaticOrderID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticOrderID.Location = new Point(18, 42);
            lblStaticOrderID.Name = "lblStaticOrderID";
            lblStaticOrderID.Size = new Size(62, 15);
            lblStaticOrderID.TabIndex = 9;
            lblStaticOrderID.Text = "Order ID: ";
            lblStaticOrderID.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(116, 155);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 15);
            lblDescription.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(355, 125);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(116, 126);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(0, 15);
            lblYear.TabIndex = 6;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(354, 98);
            lblManufacturer.Margin = new Padding(4, 0, 4, 0);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(0, 15);
            lblManufacturer.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(116, 98);
            lblModel.Margin = new Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(0, 15);
            lblModel.TabIndex = 4;
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(353, 70);
            lblCarID.Margin = new Padding(4, 0, 4, 0);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(0, 15);
            lblCarID.TabIndex = 3;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(116, 72);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 15);
            lblTotalAmount.TabIndex = 2;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(353, 44);
            lblOrderDate.Margin = new Padding(4, 0, 4, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(0, 15);
            lblOrderDate.TabIndex = 1;
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(116, 42);
            lblOrderID.Margin = new Padding(4, 0, 4, 0);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(0, 15);
            lblOrderID.TabIndex = 0;
            // 
            // OrderCarDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_7741478;
            ClientSize = new Size(587, 286);
            Controls.Add(grpOrderDetails);
            Margin = new Padding(4);
            Name = "OrderCarDetail";
            Text = "Order Details";
            grpOrderDetails.ResumeLayout(false);
            grpOrderDetails.PerformLayout();
            ResumeLayout(false);
        }



        #endregion


    }
}