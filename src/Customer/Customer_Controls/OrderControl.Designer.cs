namespace CarStoreApp.Forms.post_login_customer.customer_controls
{
    partial class OrderControl
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
            grpCarOrders = new GroupBox();
            dgvCarOrders = new DataGridView();
            grpCarPartOrders = new GroupBox();
            dgvCarPartOrders = new DataGridView();
            grpCarOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarOrders).BeginInit();
            grpCarPartOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarPartOrders).BeginInit();
            SuspendLayout();
            // 
            // grpCarOrders
            // 
            grpCarOrders.Controls.Add(dgvCarOrders);
            grpCarOrders.Location = new Point(92, 14);
            grpCarOrders.Margin = new Padding(4);
            grpCarOrders.Name = "grpCarOrders";
            grpCarOrders.Padding = new Padding(4);
            grpCarOrders.Size = new Size(654, 199);
            grpCarOrders.TabIndex = 0;
            grpCarOrders.TabStop = false;
            grpCarOrders.Text = "My Car Orders";
            // 
            // dgvCarOrders
            // 
            dgvCarOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarOrders.BackgroundColor = Color.Azure;
            dgvCarOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarOrders.Location = new Point(7, 22);
            dgvCarOrders.Margin = new Padding(4);
            dgvCarOrders.Name = "dgvCarOrders";
            dgvCarOrders.RowHeadersWidth = 51;
            dgvCarOrders.Size = new Size(640, 167);
            dgvCarOrders.TabIndex = 0;
            dgvCarOrders.CellContentClick += DgvCarOrders_CellContentClick;
            // 
            // grpCarPartOrders
            // 
            grpCarPartOrders.Controls.Add(dgvCarPartOrders);
            grpCarPartOrders.Location = new Point(92, 221);
            grpCarPartOrders.Margin = new Padding(4);
            grpCarPartOrders.Name = "grpCarPartOrders";
            grpCarPartOrders.Padding = new Padding(4);
            grpCarPartOrders.Size = new Size(654, 231);
            grpCarPartOrders.TabIndex = 1;
            grpCarPartOrders.TabStop = false;
            grpCarPartOrders.Text = "My Car Parts Orders";
            // 
            // dgvCarPartOrders
            // 
            dgvCarPartOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarPartOrders.BackgroundColor = Color.Azure;
            dgvCarPartOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarPartOrders.Location = new Point(7, 22);
            dgvCarPartOrders.Margin = new Padding(4);
            dgvCarPartOrders.Name = "dgvCarPartOrders";
            dgvCarPartOrders.RowHeadersWidth = 51;
            dgvCarPartOrders.Size = new Size(640, 202);
            dgvCarPartOrders.TabIndex = 0;
            dgvCarPartOrders.CellContentClick += DgvCarPartOrders_CellContentClick;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_7741472;
            Controls.Add(grpCarPartOrders);
            Controls.Add(grpCarOrders);
            Margin = new Padding(4);
            Name = "OrderControl";
            Size = new Size(836, 578);
            grpCarOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarOrders).EndInit();
            grpCarPartOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarPartOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
    }
}
