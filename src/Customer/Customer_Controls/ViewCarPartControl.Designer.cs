using System.Windows.Forms;

namespace CarStoreApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarPartControl
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
            cmbPartName = new ComboBox();
            lblPartNumber = new Label();
            lblPrice = new Label();
            txtOrderQuantity = new TextBox();
            btnAddToCart = new Button();
            lbNo = new Label();
            lblStaticPrice = new Label();
            lblStaticDescription = new Label();
            lblStaticQty = new Label();
            groupBoxOrderDetails = new GroupBox();
            lbQTY = new Label();
            lblDescription = new Label();
            lblAvailableQuantity = new Label();
            lblTotalLabel = new Label();
            lblTotalValue = new Label();
            btnOrder = new Button();
            groupBoxCarParts = new GroupBox();
            cartGridView = new DataGridView();
            PartName = new DataGridViewTextBoxColumn();
            PartNumber = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            groupBoxOrderDetails.SuspendLayout();
            groupBoxCarParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGridView).BeginInit();
            SuspendLayout();
            // 
            // cmbPartName
            // 
            cmbPartName.FormattingEnabled = true;
            cmbPartName.Location = new Point(32, 21);
            cmbPartName.Name = "cmbPartName";
            cmbPartName.Size = new Size(200, 23);
            cmbPartName.TabIndex = 0;
            cmbPartName.SelectedIndexChanged += CmbPartName_SelectedIndexChanged;
            // 
            // lblPartNumber
            // 
            lblPartNumber.AutoSize = true;
            lblPartNumber.Location = new Point(105, 74);
            lblPartNumber.Name = "lblPartNumber";
            lblPartNumber.Size = new Size(0, 15);
            lblPartNumber.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(105, 110);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 15);
            lblPrice.TabIndex = 2;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new Point(296, 21);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.Size = new Size(100, 23);
            txtOrderQuantity.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.DeepSkyBlue;
            btnAddToCart.Location = new Point(501, 107);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(111, 36);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += BtnAddToCart_Click;
            // 
            // lbNo
            // 
            lbNo.AutoSize = true;
            lbNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNo.Location = new Point(33, 72);
            lbNo.Name = "lbNo";
            lbNo.Size = new Size(56, 15);
            lbNo.TabIndex = 11;
            lbNo.Text = "Number:";
            // 
            // lblStaticPrice
            // 
            lblStaticPrice.AutoSize = true;
            lblStaticPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticPrice.Location = new Point(34, 107);
            lblStaticPrice.Name = "lblStaticPrice";
            lblStaticPrice.Size = new Size(38, 15);
            lblStaticPrice.TabIndex = 12;
            lblStaticPrice.Text = "Price:";
            // 
            // lblStaticDescription
            // 
            lblStaticDescription.AutoSize = true;
            lblStaticDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticDescription.Location = new Point(258, 73);
            lblStaticDescription.Name = "lblStaticDescription";
            lblStaticDescription.Size = new Size(74, 15);
            lblStaticDescription.TabIndex = 13;
            lblStaticDescription.Text = "Description:";
            // 
            // lblStaticQty
            // 
            lblStaticQty.AutoSize = true;
            lblStaticQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaticQty.Location = new Point(259, 107);
            lblStaticQty.Name = "lblStaticQty";
            lblStaticQty.Size = new Size(111, 15);
            lblStaticQty.TabIndex = 14;
            lblStaticQty.Text = "Available Quantity:";
            // 
            // groupBoxOrderDetails
            // 
            groupBoxOrderDetails.BackColor = Color.Azure;
            groupBoxOrderDetails.Controls.Add(lbQTY);
            groupBoxOrderDetails.Controls.Add(lblDescription);
            groupBoxOrderDetails.Controls.Add(lblAvailableQuantity);
            groupBoxOrderDetails.Controls.Add(lblTotalLabel);
            groupBoxOrderDetails.Controls.Add(lblTotalValue);
            groupBoxOrderDetails.Controls.Add(cmbPartName);
            groupBoxOrderDetails.Controls.Add(lblStaticQty);
            groupBoxOrderDetails.Controls.Add(lblPartNumber);
            groupBoxOrderDetails.Controls.Add(btnOrder);
            groupBoxOrderDetails.Controls.Add(lblStaticDescription);
            groupBoxOrderDetails.Controls.Add(lblPrice);
            groupBoxOrderDetails.Controls.Add(lblStaticPrice);
            groupBoxOrderDetails.Controls.Add(lbNo);
            groupBoxOrderDetails.Controls.Add(txtOrderQuantity);
            groupBoxOrderDetails.Controls.Add(btnAddToCart);
            groupBoxOrderDetails.Location = new Point(26, 16);
            groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            groupBoxOrderDetails.Size = new Size(750, 153);
            groupBoxOrderDetails.TabIndex = 15;
            groupBoxOrderDetails.TabStop = false;
            groupBoxOrderDetails.Text = "Order Details";
            // 
            // lbQTY
            // 
            lbQTY.AutoSize = true;
            lbQTY.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbQTY.Location = new Point(256, 24);
            lbQTY.Name = "lbQTY";
            lbQTY.Size = new Size(36, 15);
            lbQTY.TabIndex = 17;
            lbQTY.Text = "QTY :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(367, 73);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 15);
            lblDescription.TabIndex = 15;
            // 
            // lblAvailableQuantity
            // 
            lblAvailableQuantity.AutoSize = true;
            lblAvailableQuantity.Location = new Point(367, 107);
            lblAvailableQuantity.Name = "lblAvailableQuantity";
            lblAvailableQuantity.Size = new Size(0, 15);
            lblAvailableQuantity.TabIndex = 16;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalLabel.Location = new Point(619, 30);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(37, 15);
            lblTotalLabel.TabIndex = 13;
            lblTotalLabel.Text = "Total:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(657, 30);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(13, 15);
            lblTotalValue.TabIndex = 14;
            lblTotalValue.Text = "0";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.YellowGreen;
            btnOrder.Location = new Point(618, 107);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 36);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "Place Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += BtnOrder_Click;
            // 
            // groupBoxCarParts
            // 
            groupBoxCarParts.Controls.Add(cartGridView);
            groupBoxCarParts.Location = new Point(26, 196);
            groupBoxCarParts.Name = "groupBoxCarParts";
            groupBoxCarParts.Size = new Size(750, 316);
            groupBoxCarParts.TabIndex = 15;
            groupBoxCarParts.TabStop = false;
            groupBoxCarParts.Text = "Car Parts";
            // 
            // cartGridView
            // 
            cartGridView.AllowUserToAddRows = false;
            cartGridView.AllowUserToDeleteRows = false;
            cartGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGridView.BackgroundColor = Color.Azure;
            cartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGridView.Columns.AddRange(new DataGridViewColumn[] { PartName, PartNumber, Quantity, Price, TotalColumn });
            cartGridView.Location = new Point(14, 26);
            cartGridView.Name = "cartGridView";
            cartGridView.ReadOnly = true;
            cartGridView.RowHeadersWidth = 51;
            cartGridView.Size = new Size(716, 242);
            cartGridView.TabIndex = 12;
            // 
            // PartName
            // 
            PartName.HeaderText = "Part Name";
            PartName.MinimumWidth = 6;
            PartName.Name = "PartName";
            PartName.ReadOnly = true;
            // 
            // PartNumber
            // 
            PartNumber.HeaderText = "Number";
            PartNumber.MinimumWidth = 6;
            PartNumber.Name = "PartNumber";
            PartNumber.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // TotalColumn
            // 
            TotalColumn.HeaderText = "Total";
            TotalColumn.MinimumWidth = 6;
            TotalColumn.Name = "TotalColumn";
            TotalColumn.ReadOnly = true;
            // 
            // ViewCarPartControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_7741477;
            Controls.Add(groupBoxCarParts);
            Controls.Add(groupBoxOrderDetails);
            Name = "ViewCarPartControl";
            Size = new Size(850, 500);
            groupBoxOrderDetails.ResumeLayout(false);
            groupBoxOrderDetails.PerformLayout();
            groupBoxCarParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cartGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalColumn;
        private Label lblDescription;
        private Label lblAvailableQuantity;
        private Label lbQTY;
    }
}
