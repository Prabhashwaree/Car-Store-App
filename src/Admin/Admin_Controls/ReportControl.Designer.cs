using System.Windows.Forms;

namespace CarStoreApp.Forms.post_login_admin.admin_controls
{
    partial class ReportControl
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
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            btnGenerateReport = new Button();
            dgvReportData = new DataGridView();
            btnExportToPDF = new Button();
            groupBoxFilter = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportData).BeginInit();
            groupBoxFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFromDate.Location = new Point(16, 24);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(69, 15);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(88, 21);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(209, 23);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblToDate.Location = new Point(311, 24);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(53, 15);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "To Date:";
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(366, 21);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(209, 23);
            dtpToDate.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.DeepSkyBlue;
            btnGenerateReport.Location = new Point(596, 15);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(105, 38);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += BtnGenerateReport_Click;
            // 
            // dgvReportData
            // 
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.BackgroundColor = Color.Azure;
            dgvReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportData.Location = new Point(38, 100);
            dgvReportData.Name = "dgvReportData";
            dgvReportData.RowHeadersWidth = 51;
            dgvReportData.Size = new Size(834, 372);
            dgvReportData.TabIndex = 5;
            // 
            // btnExportToPDF
            // 
            btnExportToPDF.BackColor = Color.CadetBlue;
            btnExportToPDF.Location = new Point(706, 15);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(112, 38);
            btnExportToPDF.TabIndex = 6;
            btnExportToPDF.Text = "Export to PDF";
            btnExportToPDF.UseVisualStyleBackColor = false;
            btnExportToPDF.Click += BtnExportToPDF_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.BackColor = Color.Azure;
            groupBoxFilter.Controls.Add(dtpFromDate);
            groupBoxFilter.Controls.Add(btnGenerateReport);
            groupBoxFilter.Controls.Add(btnExportToPDF);
            groupBoxFilter.Controls.Add(lblToDate);
            groupBoxFilter.Controls.Add(lblFromDate);
            groupBoxFilter.Controls.Add(dtpToDate);
            groupBoxFilter.Location = new Point(38, 14);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(834, 67);
            groupBoxFilter.TabIndex = 7;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Filter";
            // 
            // ReportControl
            // 
            BackgroundImage = CarStoreApp1.Properties.Resources.pngtree_grunge_wall_texture_scratched_off_white_background_image_77414710;
            Controls.Add(groupBoxFilter);
            Controls.Add(dgvReportData);
            Name = "ReportControl";
            Size = new Size(980, 500);
            ((System.ComponentModel.ISupportInitialize)dgvReportData).EndInit();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
    }
}
