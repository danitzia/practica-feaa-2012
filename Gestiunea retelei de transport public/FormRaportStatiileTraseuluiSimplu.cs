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
    public partial class FormRaportStatiileTraseuluiSimplu : Form
    {
        public FormRaportStatiileTraseuluiSimplu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1b1.DataTable1b1' table. You can move, or remove it, as needed.
            this.DataTable1b1TableAdapter.Fill(this.DataSet1b1.DataTable1b1);

            this.reportViewer1.RefreshReport();
        }
    }
}
