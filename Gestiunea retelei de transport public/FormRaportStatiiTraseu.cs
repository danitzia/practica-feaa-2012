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
    public partial class FormRaportStatiiTraseu : Form
    {
        public FormRaportStatiiTraseu()
        {
            InitializeComponent();
        }

        private void FormRaportStatiiTraseu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DatasetStatiiTraseu.DataTable4' table. You can move, or remove it, as needed.
            this.DataTable4TableAdapter.Fill(this.DatasetStatiiTraseu.DataTable4);

            this.reportViewer1.RefreshReport();
        }
    }
}
