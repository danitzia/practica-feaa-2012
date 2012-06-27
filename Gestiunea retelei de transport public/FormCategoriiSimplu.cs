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
    public partial class FormCategoriiSimplu : Form
    {
        public FormCategoriiSimplu()
        {
            InitializeComponent();
        }

        private void categoriiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormCategoriiSimplu);

        }

        private void FormCategoriiSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormCategoriiSimplu.categorii' table. You can move, or remove it, as needed.
            this.categoriiTableAdapter.Fill(this.dataSetFormCategoriiSimplu.categorii);

        }
    }
}
