using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiunea_retelei_de_transport_public
{
    public partial class FormRaportTotalAmenzi : Form
    {
        public FormRaportTotalAmenzi()
        {
            InitializeComponent();
        }

        private void FormRaportTotalAmenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTotalAmenzi.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.DataSetTotalAmenzi.DataTable2);
            // TODO: This line of code loads data into the 'DataSetTotalAmenzi.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetTotalAmenzi.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
