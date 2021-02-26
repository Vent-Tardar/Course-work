namespace Programm
{
    partial class ReportDish
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenDataSet = new Programm.canteenDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportTableAdapter = new Programm.canteenDataSetTableAdapters.ReportTableAdapter();
            this.Exit = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBindingSource
            // 
            this.ReportBindingSource.DataMember = "Report";
            this.ReportBindingSource.DataSource = this.canteenDataSet;
            // 
            // canteenDataSet
            // 
            this.canteenDataSet.DataSetName = "canteenDataSet";
            this.canteenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programm.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1004, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportTableAdapter
            // 
            this.ReportTableAdapter.ClearBeforeFill = true;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Lime;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1040, 75);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 74);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Lime;
            this.Nazad.FlatAppearance.BorderSize = 0;
            this.Nazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Nazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.Location = new System.Drawing.Point(1040, 232);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(107, 74);
            this.Nazad.TabIndex = 19;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // ReportDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1188, 416);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportDish";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о продуктах в конце месяца";
            this.Load += new System.EventHandler(this.ReportDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportBindingSource;
        private canteenDataSet canteenDataSet;
        private canteenDataSetTableAdapters.ReportTableAdapter ReportTableAdapter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Nazad;
    }
}