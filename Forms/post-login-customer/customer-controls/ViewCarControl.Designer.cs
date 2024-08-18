namespace CarStoreApp.Forms.post_login_customer.customer_controls
{
    partial class ViewCarControl
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
            carGridView = new DataGridView();
            groupBoxSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)carGridView).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(759, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // carGridView
            // 
            carGridView.BackgroundColor = Color.Azure;
            carGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGridView.Location = new Point(20, 90);
            carGridView.Name = "carGridView";
            carGridView.RowHeadersWidth = 51;
            carGridView.RowTemplate.Height = 24;
            carGridView.Size = new Size(800, 385);
            carGridView.TabIndex = 1;
            carGridView.CellClick += CarGridView_CellClick;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = SystemColors.ButtonFace;
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Location = new Point(20, 18);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(800, 62);
            groupBoxSearch.TabIndex = 21;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // ViewCarControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_7741471;
            Controls.Add(groupBoxSearch);
            Controls.Add(carGridView);
            Name = "ViewCarControl";
            Size = new Size(850, 500);
            ((System.ComponentModel.ISupportInitialize)carGridView).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

    }
}
