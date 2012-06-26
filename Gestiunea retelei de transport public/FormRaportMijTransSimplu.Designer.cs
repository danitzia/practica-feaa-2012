namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportMijTransSimplu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1b4 = new Gestiunea_retelei_de_transport_public.DataSet1b4();
            this.DataTable1b4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1b4TableAdapter = new Gestiunea_retelei_de_transport_public.DataSet1b4TableAdapters.DataTable1b4TableAdapter();
            this.cmbRaportMijTrans = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1b4";
            reportDataSource3.Value = this.DataTable1b4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.Reportb4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 269);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1b4
            // 
            this.DataSet1b4.DataSetName = "DataSet1b4";
            this.DataSet1b4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1b4BindingSource
            // 
            this.DataTable1b4BindingSource.DataMember = "DataTable1b4";
            this.DataTable1b4BindingSource.DataSource = this.DataSet1b4;
            // 
            // DataTable1b4TableAdapter
            // 
            this.DataTable1b4TableAdapter.ClearBeforeFill = true;
            // 
            // cmbRaportMijTrans
            // 
            this.cmbRaportMijTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaportMijTrans.FormattingEnabled = true;
            this.cmbRaportMijTrans.Items.AddRange(new object[] {
            "VEH01",
            "VEH02",
            "VEH03"});
            this.cmbRaportMijTrans.Location = new System.Drawing.Point(87, 4);
            this.cmbRaportMijTrans.Name = "cmbRaportMijTrans";
            this.cmbRaportMijTrans.Size = new System.Drawing.Size(121, 21);
            this.cmbRaportMijTrans.TabIndex = 1;
            this.cmbRaportMijTrans.SelectedIndexChanged += new System.EventHandler(this.cmbRaportMijTrans_SelectedIndexChanged);
            // 
            // FormRaportMijTransSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 300);
            this.Controls.Add(this.cmbRaportMijTrans);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportMijTransSimplu";
            this.Text = "FormRaportMijTransSimplu";
            this.Load += new System.EventHandler(this.FormRaportMijTransSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1b4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1b4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1b4BindingSource;
        private DataSet1b4 DataSet1b4;
        private DataSet1b4TableAdapters.DataTable1b4TableAdapter DataTable1b4TableAdapter;
        private System.Windows.Forms.ComboBox cmbRaportMijTrans;
    }
}