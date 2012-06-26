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
    public partial class FormRaportAngajatiSimplu : Form
    {
        public FormRaportAngajatiSimplu()
        {
            InitializeComponent();
        }

        private void FormRaportAngajati_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void cmbRaportAngajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataSetAngajati.DataTable1, cmbRaportAngajati.SelectedItem.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
