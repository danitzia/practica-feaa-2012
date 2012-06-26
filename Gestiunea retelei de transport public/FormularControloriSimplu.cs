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
    public partial class FormularControloriSimplu : Form
    {
        public FormularControloriSimplu()
        {
            InitializeComponent();
        }

        private void controloriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controloriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetControloriSimplu);

        }

        private void FormularControloriSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetControloriSimplu.controlori' table. You can move, or remove it, as needed.
            this.controloriTableAdapter.Fill(this.dataSetControloriSimplu.controlori);

        }
    }
}
