namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportOrareTraseuSimplu
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
            this.DataSet1b2 = new Gestiunea_retelei_de_transport_public.DataSet1b2();
            this.DataTable1b2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1b2TableAdapter = new Gestiunea_retelei_de_transport_public.DataSet1b2TableAdapters.DataTable1b2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1b2";
            reportDataSource1.Value = this.DataTable1b2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.Reportb2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(599, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1b2
            // 
            this.DataSet1b2.DataSetName = "DataSet1b2";
            this.DataSet1b2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1b2BindingSource
            // 
            this.DataTable1b2BindingSource.DataMember = "DataTable1b2";
            this.DataTable1b2BindingSource.DataSource = this.DataSet1b2;
            // 
            // DataTable1b2TableAdapter
            // 
            this.DataTable1b2TableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportOrareTraseu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 330);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportOrareTraseu";
            this.Text = "FormRaportOrareTraseu";
            this.Load += new System.EventHandler(this.FormRaportOrareTraseu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1b2BindingSource;
        private DataSet1b2 DataSet1b2;
        private DataSet1b2TableAdapters.DataTable1b2TableAdapter DataTable1b2TableAdapter;
    }
}