namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportCategoriiAngajati
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
            this.DataSetCategoriiAngajati = new Gestiunea_retelei_de_transport_public.DataSetCategoriiAngajati();
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable3TableAdapter = new Gestiunea_retelei_de_transport_public.DataSetCategoriiAngajatiTableAdapters.DataTable3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCategoriiAngajati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.MachetaCategoriiAngajati.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(877, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCategoriiAngajati
            // 
            this.DataSetCategoriiAngajati.DataSetName = "DataSetCategoriiAngajati";
            this.DataSetCategoriiAngajati.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.DataSetCategoriiAngajati;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportCategoriiAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportCategoriiAngajati";
            this.Text = "FormRaportCategoriiAngajati";
            this.Load += new System.EventHandler(this.FormRaportCategoriiAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCategoriiAngajati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private DataSetCategoriiAngajati DataSetCategoriiAngajati;
        private DataSetCategoriiAngajatiTableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
    }
}