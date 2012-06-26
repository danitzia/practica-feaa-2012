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
    public partial class FormRaportOrareTraseuSimplu : Form
    {
        public FormRaportOrareTraseuSimplu()
        {
            InitializeComponent();
        }

        private void FormRaportOrareTraseu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1b2.DataTable1b2' table. You can move, or remove it, as needed.
            this.DataTable1b2TableAdapter.Fill(this.DataSet1b2.DataTable1b2);

            this.reportViewer1.RefreshReport();
        }
    }
}
