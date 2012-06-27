namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportTipuriVehicule
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
            this.DataSetTipuriMijloaceDeTransport = new Gestiunea_retelei_de_transport_public.DataSetTipuriMijloaceDeTransport();
            this.DataTableA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableA1TableAdapter = new Gestiunea_retelei_de_transport_public.DataSetTipuriMijloaceDeTransportTableAdapters.DataTableA1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTipuriMijloaceDeTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableA1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableA1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.MachetaTipuriVehicule.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(501, 284);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTipuriMijloaceDeTransport
            // 
            this.DataSetTipuriMijloaceDeTransport.DataSetName = "DataSetTipuriMijloaceDeTransport";
            this.DataSetTipuriMijloaceDeTransport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableA1BindingSource
            // 
            this.DataTableA1BindingSource.DataMember = "DataTableA1";
            this.DataTableA1BindingSource.DataSource = this.DataSetTipuriMijloaceDeTransport;
            // 
            // DataTableA1TableAdapter
            // 
            this.DataTableA1TableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportTipuriVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 284);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportTipuriVehicule";
            this.Text = "FormRaportTipuriVehicule";
            this.Load += new System.EventHandler(this.FormRaportTipuriVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTipuriMijloaceDeTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableA1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableA1BindingSource;
        private DataSetTipuriMijloaceDeTransport DataSetTipuriMijloaceDeTransport;
        private DataSetTipuriMijloaceDeTransportTableAdapters.DataTableA1TableAdapter DataTableA1TableAdapter;
    }
}