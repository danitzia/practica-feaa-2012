namespace Gestiunea_retelei_de_transport_public
{
    partial class FormRaportAngajati
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAngajati = new Gestiunea_retelei_de_transport_public.DataSetAngajati();
            this.DataTable1TableAdapter = new Gestiunea_retelei_de_transport_public.DataSetAngajatiTableAdapters.DataTable1TableAdapter();
            this.cmbRaportAngajati = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestiunea_retelei_de_transport_public.ReportAngajati.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(652, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetAngajati;
            // 
            // DataSetAngajati
            // 
            this.DataSetAngajati.DataSetName = "DataSetAngajati";
            this.DataSetAngajati.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // cmbRaportAngajati
            // 
            this.cmbRaportAngajati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaportAngajati.FormattingEnabled = true;
            this.cmbRaportAngajati.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbRaportAngajati.Location = new System.Drawing.Point(254, 12);
            this.cmbRaportAngajati.Name = "cmbRaportAngajati";
            this.cmbRaportAngajati.Size = new System.Drawing.Size(121, 21);
            this.cmbRaportAngajati.TabIndex = 2;
            this.cmbRaportAngajati.Tag = "";
            this.cmbRaportAngajati.SelectedIndexChanged += new System.EventHandler(this.cmbRaportAngajati_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectati >";
            // 
            // FormRaportAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRaportAngajati);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportAngajati";
            this.Text = "FormRaportAngajati";
            this.Load += new System.EventHandler(this.FormRaportAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetAngajati DataSetAngajati;
        private DataSetAngajatiTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.ComboBox cmbRaportAngajati;
        private System.Windows.Forms.Label label1;
    }
}