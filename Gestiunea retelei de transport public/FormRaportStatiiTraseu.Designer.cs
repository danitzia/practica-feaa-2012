namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportStatiiTraseu
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
            this.DatasetStatiiTraseu = new Gestiunea_retelei_de_transport_public.DatasetStatiiTraseu();
            this.DataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable4TableAdapter = new Gestiunea_retelei_de_transport_public.DatasetStatiiTraseuTableAdapters.DataTable4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatasetStatiiTraseu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.MachetaStatiiTraseu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatasetStatiiTraseu
            // 
            this.DatasetStatiiTraseu.DataSetName = "DatasetStatiiTraseu";
            this.DatasetStatiiTraseu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable4BindingSource
            // 
            this.DataTable4BindingSource.DataMember = "DataTable4";
            this.DataTable4BindingSource.DataSource = this.DatasetStatiiTraseu;
            // 
            // DataTable4TableAdapter
            // 
            this.DataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportStatiiTraseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportStatiiTraseu";
            this.Text = "FormRaportStatiiTraseu";
            this.Load += new System.EventHandler(this.FormRaportStatiiTraseu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasetStatiiTraseu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable4BindingSource;
        private DatasetStatiiTraseu DatasetStatiiTraseu;
        private DatasetStatiiTraseuTableAdapters.DataTable4TableAdapter DataTable4TableAdapter;
    }
}