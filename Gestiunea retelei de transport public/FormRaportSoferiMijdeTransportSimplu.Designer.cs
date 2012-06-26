namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportSoferiMijdeTransportSimplu
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
            this.cmbSoferiMijdeTransport = new System.Windows.Forms.ComboBox();
            this.DataTable1b3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1b3 = new Gestiunea_retelei_de_transport_public.DataSet1b3();
            this.DataTable1b3TableAdapter = new Gestiunea_retelei_de_transport_public.DataSet1b3TableAdapters.DataTable1b3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1b3";
            reportDataSource1.Value = this.DataTable1b3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.Reportb3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(828, 459);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbSoferiMijdeTransport
            // 
            this.cmbSoferiMijdeTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoferiMijdeTransport.FormattingEnabled = true;
            this.cmbSoferiMijdeTransport.Items.AddRange(new object[] {
            "SOF01",
            "SOF02",
            "SOF03",
            "SOF04",
            "SOF05"});
            this.cmbSoferiMijdeTransport.Location = new System.Drawing.Point(87, 8);
            this.cmbSoferiMijdeTransport.Name = "cmbSoferiMijdeTransport";
            this.cmbSoferiMijdeTransport.Size = new System.Drawing.Size(121, 21);
            this.cmbSoferiMijdeTransport.TabIndex = 1;
            this.cmbSoferiMijdeTransport.SelectedIndexChanged += new System.EventHandler(this.cmbSoferiMijdeTransport_SelectedIndexChanged);
            // 
            // DataTable1b3BindingSource
            // 
            this.DataTable1b3BindingSource.DataMember = "DataTable1b3";
            this.DataTable1b3BindingSource.DataSource = this.DataSet1b3;
            // 
            // DataSet1b3
            // 
            this.DataSet1b3.DataSetName = "DataSet1b3";
            this.DataSet1b3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1b3TableAdapter
            // 
            this.DataTable1b3TableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportSoferiMijdeTransportSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 496);
            this.Controls.Add(this.cmbSoferiMijdeTransport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportSoferiMijdeTransportSimplu";
            this.Text = "FormSoferiMijdeTransportSimplu";
            this.Load += new System.EventHandler(this.FormSoferiMijdeTransportSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1b3BindingSource;
        private DataSet1b3 DataSet1b3;
        private DataSet1b3TableAdapters.DataTable1b3TableAdapter DataTable1b3TableAdapter;
        private System.Windows.Forms.ComboBox cmbSoferiMijdeTransport;
    }
}