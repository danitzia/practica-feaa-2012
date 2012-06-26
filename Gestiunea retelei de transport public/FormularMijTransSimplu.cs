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
    public partial class FormularMijTransSimplu : Form
    {
        public FormularMijTransSimplu()
        {
            InitializeComponent();
        }

        private void mijtransBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mijtransBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormMijTransSimplu);

        }

        private void FormularMijTransSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormMijTransSimplu.mijtrans' table. You can move, or remove it, as needed.
            this.mijtransTableAdapter.Fill(this.dataSetFormMijTransSimplu.mijtrans);

        }
    }
}
