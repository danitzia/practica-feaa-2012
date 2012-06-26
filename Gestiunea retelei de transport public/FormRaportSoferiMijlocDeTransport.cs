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
    public partial class FormSoferiMijlocDeTransport : Form
    {
        public FormSoferiMijlocDeTransport()
        {
            InitializeComponent();
        }

        private void FormSoferiMijlocDeTransport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSoferiMijlocDeTransport.DataTableD1' table. You can move, or remove it, as needed.
            this.DataTableD1TableAdapter.Fill(this.DataSetSoferiMijlocDeTransport.DataTableD1);

            this.reportViewer1.RefreshReport();
        }
    }
}
