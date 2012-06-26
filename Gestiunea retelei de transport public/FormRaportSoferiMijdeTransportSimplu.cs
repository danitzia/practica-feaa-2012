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
    public partial class FormRaportSoferiMijdeTransportSimplu : Form
    {
        public FormRaportSoferiMijdeTransportSimplu()
        {
            InitializeComponent();
        }

        private void FormSoferiMijdeTransportSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1b3.DataTable1b3' table. You can move, or remove it, as needed.
            
        }

        private void cmbSoferiMijdeTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataTable1b3TableAdapter.Fill(this.DataSet1b3.DataTable1b3, this.cmbSoferiMijdeTransport.SelectedItem.ToString());

            this.reportViewer1.RefreshReport();

        }
    }
}
