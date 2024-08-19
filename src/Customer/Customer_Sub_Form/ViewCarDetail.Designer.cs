namespace CarStoreApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarDetail
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
            btnOrder = new Button();
            btnCancel = new Button();
            groupBoxCarDetails = new GroupBox();
            lblDescriptionValue = new Label();
            lblPriceValue = new Label();
            lblYearValue = new Label();
            lblManufacturerValue = new Label();
            lblModelValue = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            lblManufacturer = new Label();
            lblModel = new Label();
            groupBoxCarDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.DeepSkyBlue;
            btnOrder.Location = new Point(397, 152);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(105, 33);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += BtnOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SlateGray;
            btnCancel.Location = new Point(286, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 33);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // groupBoxCarDetails
            // 
            groupBoxCarDetails.BackColor = Color.Azure;
            groupBoxCarDetails.Controls.Add(lblDescriptionValue);
            groupBoxCarDetails.Controls.Add(btnCancel);
            groupBoxCarDetails.Controls.Add(lblPriceValue);
            groupBoxCarDetails.Controls.Add(btnOrder);
            groupBoxCarDetails.Controls.Add(lblYearValue);
            groupBoxCarDetails.Controls.Add(lblManufacturerValue);
            groupBoxCarDetails.Controls.Add(lblModelValue);
            groupBoxCarDetails.Controls.Add(lblDescription);
            groupBoxCarDetails.Controls.Add(lblPrice);
            groupBoxCarDetails.Controls.Add(lblYear);
            groupBoxCarDetails.Controls.Add(lblManufacturer);
            groupBoxCarDetails.Controls.Add(lblModel);
            groupBoxCarDetails.Location = new Point(34, 23);
            groupBoxCarDetails.Name = "groupBoxCarDetails";
            groupBoxCarDetails.Size = new Size(524, 198);
            groupBoxCarDetails.TabIndex = 12;
            groupBoxCarDetails.TabStop = false;
            groupBoxCarDetails.Text = "Car Details";
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.AutoSize = true;
            lblDescriptionValue.Location = new Point(126, 104);
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new Size(43, 15);
            lblDescriptionValue.TabIndex = 19;
            lblDescriptionValue.Text = "[Value]";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Location = new Point(370, 70);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(43, 15);
            lblPriceValue.TabIndex = 18;
            lblPriceValue.Text = "[Value]";
            // 
            // lblYearValue
            // 
            lblYearValue.AutoSize = true;
            lblYearValue.Location = new Point(126, 70);
            lblYearValue.Name = "lblYearValue";
            lblYearValue.Size = new Size(43, 15);
            lblYearValue.TabIndex = 17;
            lblYearValue.Text = "[Value]";
            // 
            // lblManufacturerValue
            // 
            lblManufacturerValue.AutoSize = true;
            lblManufacturerValue.Location = new Point(370, 40);
            lblManufacturerValue.Name = "lblManufacturerValue";
            lblManufacturerValue.Size = new Size(43, 15);
            lblManufacturerValue.TabIndex = 16;
            lblManufacturerValue.Text = "[Value]";
            // 
            // lblModelValue
            // 
            lblModelValue.AutoSize = true;
            lblModelValue.Location = new Point(126, 40);
            lblModelValue.Name = "lblModelValue";
            lblModelValue.Size = new Size(43, 15);
            lblModelValue.TabIndex = 15;
            lblModelValue.Text = "[Value]";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(26, 104);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(270, 70);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(26, 70);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 12;
            lblYear.Text = "Year:";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(270, 40);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(82, 15);
            lblManufacturer.TabIndex = 11;
            lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(26, 40);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 10;
            lblModel.Text = "Model:";
            // 
            // ViewCarDetail
            // 
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            ClientSize = new Size(587, 240);
            Controls.Add(groupBoxCarDetails);
            Name = "ViewCarDetail";
            Text = "Car Detail";
            groupBoxCarDetails.ResumeLayout(false);
            groupBoxCarDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


    }
}