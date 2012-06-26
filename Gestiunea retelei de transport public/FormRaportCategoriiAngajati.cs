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
    public partial class FormRaportCategoriiAngajati : Form
    {
        public FormRaportCategoriiAngajati()
        {
            InitializeComponent();
        }

        private void FormRaportCategoriiAngajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCategoriiAngajati.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSetCategoriiAngajati.DataTable3);

            this.reportViewer1.RefreshReport();
        }
    }
}
