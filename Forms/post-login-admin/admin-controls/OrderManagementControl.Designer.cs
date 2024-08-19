namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class OrderManagementControl
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
            grpCarPartOrders = new GroupBox();
            dgvCarPartOrders = new DataGridView();
            grpCarOrders = new GroupBox();
            dgvCarOrders = new DataGridView();
            grpCarPartOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarPartOrders).BeginInit();
            grpCarOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarOrders).BeginInit();
            SuspendLayout();
            // 
            // grpCarPartOrders
            // 
            grpCarPartOrders.Controls.Add(dgvCarPartOrders);
            grpCarPartOrders.Location = new Point(46, 291);
            grpCarPartOrders.Margin = new Padding(4);
            grpCarPartOrders.Name = "grpCarPartOrders";
            grpCarPartOrders.Padding = new Padding(4);
            grpCarPartOrders.Size = new Size(804, 292);
            grpCarPartOrders.TabIndex = 3;
            grpCarPartOrders.TabStop = false;
            grpCarPartOrders.Text = "Car Parts Orders";
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
            dgvCarPartOrders.Size = new Size(789, 262);
            dgvCarPartOrders.TabIndex = 0;
            dgvCarPartOrders.CellContentClick += DgvCarPartOrders_CellContentClick;
            // 
            // grpCarOrders
            // 
            grpCarOrders.Controls.Add(dgvCarOrders);
            grpCarOrders.Location = new Point(46, 16);
            grpCarOrders.Margin = new Padding(4);
            grpCarOrders.Name = "grpCarOrders";
            grpCarOrders.Padding = new Padding(4);
            grpCarOrders.Size = new Size(804, 254);
            grpCarOrders.TabIndex = 2;
            grpCarOrders.TabStop = false;
            grpCarOrders.Text = "Car Orders";
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
            dgvCarOrders.Size = new Size(789, 224);
            dgvCarOrders.TabIndex = 0;
            dgvCarOrders.CellContentClick += DgvCarOrders_CellContentClick;
            // 
            // OrderManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            Controls.Add(grpCarPartOrders);
            Controls.Add(grpCarOrders);
            Name = "OrderManagementControl";
            Size = new Size(869, 605);
            grpCarPartOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarPartOrders).EndInit();
            grpCarOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion


    }
}
