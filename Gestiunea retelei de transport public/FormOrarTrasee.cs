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
    public partial class FormOrarTrasee : Form
    {
        public FormOrarTrasee()
        {
            InitializeComponent();
        }

        private void traseeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traseeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormOrarTrasee);

        }

        private void FormOrarTrasee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormOrarTrasee.oraretraseu' table. You can move, or remove it, as needed.
            this.oraretraseuTableAdapter.Fill(this.dataSetFormOrarTrasee.oraretraseu);
            // TODO: This line of code loads data into the 'dataSetFormOrarTrasee.trasee' table. You can move, or remove it, as needed.
            this.traseeTableAdapter.Fill(this.dataSetFormOrarTrasee.trasee);

        }
    }
}
