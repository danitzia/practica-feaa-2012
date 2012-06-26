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
    public partial class FormularSoferiVatmaniSimplu : Form
    {
        public FormularSoferiVatmaniSimplu()
        {
            InitializeComponent();
        }

        private void soferivatmaniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.soferivatmaniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetSoferiVatmani);

        }

        private void FormularSoferiVatmaniSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSoferiVatmani.soferivatmani' table. You can move, or remove it, as needed.
            this.soferivatmaniTableAdapter.Fill(this.dataSetSoferiVatmani.soferivatmani);

        }
    }
}
