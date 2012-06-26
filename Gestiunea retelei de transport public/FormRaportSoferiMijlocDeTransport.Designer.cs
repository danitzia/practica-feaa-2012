namespace Gestiunea_retelei_de_transport_public
{
    partial class FormSoferiMijlocDeTransport
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
            this.DataTableD1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSoferiMijlocDeTransport = new Gestiunea_retelei_de_transport_public.DataSetSoferiMijlocDeTransport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableD1TableAdapter = new Gestiunea_retelei_de_transport_public.DataSetSoferiMijlocDeTransportTableAdapters.DataTableD1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableD1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSoferiMijlocDeTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableD1BindingSource
            // 
            this.DataTableD1BindingSource.DataMember = "DataTableD1";
            this.DataTableD1BindingSource.DataSource = this.DataSetSoferiMijlocDeTransport;
            // 
            // DataSetSoferiMijlocDeTransport
            // 
            this.DataSetSoferiMijlocDeTransport.DataSetName = "DataSetSoferiMijlocDeTransport";
            this.DataSetSoferiMijlocDeTransport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableD1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.MachetaSoferiMijlocDeTransport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableD1TableAdapter
            // 
            this.DataTableD1TableAdapter.ClearBeforeFill = true;
            // 
            // FormSoferiMijlocDeTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 337);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormSoferiMijlocDeTransport";
            this.Text = "FormSoferiMijlocDeTransport";
            this.Load += new System.EventHandler(this.FormSoferiMijlocDeTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableD1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSoferiMijlocDeTransport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableD1BindingSource;
        private DataSetSoferiMijlocDeTransport DataSetSoferiMijlocDeTransport;
        private DataSetSoferiMijlocDeTransportTableAdapters.DataTableD1TableAdapter DataTableD1TableAdapter;
    }
}