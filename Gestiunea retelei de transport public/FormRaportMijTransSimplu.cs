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
    public partial class FormRaportMijTransSimplu : Form
    {
        public FormRaportMijTransSimplu()
        {
            InitializeComponent();
        }

        private void FormRaportMijTransSimplu_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbRaportMijTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1b4.DataTable1b4' table. You can move, or remove it, as needed.
            this.DataTable1b4TableAdapter.Fill(this.DataSet1b4.DataTable1b4,cmbRaportMijTrans.SelectedItem.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
