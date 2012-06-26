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
    public partial class FormRaportOrarTraseu : Form
    {
        public FormRaportOrarTraseu()
        {
            InitializeComponent();
        }

        private void FormRaportOrarTraseu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetOrarTrasee.DataTableA1' table. You can move, or remove it, as needed.
            this.DataTableA1TableAdapter.Fill(this.DataSetOrarTrasee.DataTableA1);

            this.reportViewer1.RefreshReport();
        }
    }
}
