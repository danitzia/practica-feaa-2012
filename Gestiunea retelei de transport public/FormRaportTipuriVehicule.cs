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
    public partial class FormRaportTipuriVehicule : Form
    {
        public FormRaportTipuriVehicule()
        {
            InitializeComponent();
        }

        private void FormRaportTipuriVehicule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTipuriMijloaceDeTransport.DataTableA1' table. You can move, or remove it, as needed.
            this.DataTableA1TableAdapter.Fill(this.DataSetTipuriMijloaceDeTransport.DataTableA1);

            this.reportViewer1.RefreshReport();
        }
    }
}
