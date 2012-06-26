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
    public partial class FormularTraseeSimplu : Form
    {
        public FormularTraseeSimplu()
        {
            InitializeComponent();
        }

        private void traseeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traseeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTraseeSimplu);

        }

        private void FormularTraseeSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTraseeSimplu.trasee' table. You can move, or remove it, as needed.
            this.traseeTableAdapter.Fill(this.dataSetTraseeSimplu.trasee);

        }
    }
}
