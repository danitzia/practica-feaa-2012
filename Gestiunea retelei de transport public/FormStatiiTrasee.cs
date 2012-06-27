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
    public partial class FormStatiiTrasee : Form
    {
        public FormStatiiTrasee()
        {
            InitializeComponent();
        }

        private void statiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormStatiiTrasee);

        }

        private void FormStatiiTrasee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statiiletraseului' table. You can move, or remove it, as needed.
            this.statiiletraseuluiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statiiletraseului);
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statii' table. You can move, or remove it, as needed.
            this.statiiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statii);
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statiiletraseului' table. You can move, or remove it, as needed.
            this.statiiletraseuluiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statiiletraseului);
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statii' table. You can move, or remove it, as needed.
            this.statiiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statii);
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statiiletraseului' table. You can move, or remove it, as needed.
            this.statiiletraseuluiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statiiletraseului);
            // TODO: This line of code loads data into the 'dataSetFormStatiiTrasee.statii' table. You can move, or remove it, as needed.
            this.statiiTableAdapter.Fill(this.dataSetFormStatiiTrasee.statii);

        }

        private void statiiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.statiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormStatiiTrasee);

        }

        private void statiiBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.statiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetFormStatiiTrasee);

        }
    }
}
