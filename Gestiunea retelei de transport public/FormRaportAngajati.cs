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
    public partial class FormRaportAngajati : Form
    {
        public FormRaportAngajati()
        {
            InitializeComponent();
        }

        private void FormRaportAngajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAngajati.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetAngajati.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
