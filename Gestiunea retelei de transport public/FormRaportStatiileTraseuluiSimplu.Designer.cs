namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportStatiileTraseuluiSimplu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1b1 = new Gestiunea_retelei_de_transport_public.DataSet1b1();
            this.DataTable1b1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1b1TableAdapter = new Gestiunea_retelei_de_transport_public.DataSet1b1TableAdapters.DataTable1b1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataset1b1";
            reportDataSource1.Value = this.DataTable1b1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.Raportb1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1b1
            // 
            this.DataSet1b1.DataSetName = "DataSet1b1";
            this.DataSet1b1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1b1BindingSource
            // 
            this.DataTable1b1BindingSource.DataMember = "DataTable1b1";
            this.DataTable1b1BindingSource.DataSource = this.DataSet1b1;
            // 
            // DataTable1b1TableAdapter
            // 
            this.DataTable1b1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 361);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1b1BindingSource;
        private DataSet1b1 DataSet1b1;
        private DataSet1b1TableAdapters.DataTable1b1TableAdapter DataTable1b1TableAdapter;
    }
}