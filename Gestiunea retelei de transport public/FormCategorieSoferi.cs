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
    public partial class FormCategorieSoferi : Form
    {
        public FormCategorieSoferi()
        {
            InitializeComponent();
        }

        private void FormCategorieSoferi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormCategorii.permisedeconducere' table. You can move, or remove it, as needed.
            this.permisedeconducereTableAdapter.Fill(this.dataSetFormCategorii.permisedeconducere);
            // TODO: This line of code loads data into the 'dataSetFormCategorii.permisedeconduceresoferi' table. You can move, or remove it, as needed.
            this.permisedeconduceresoferiTableAdapter.Fill(this.dataSetFormCategorii.permisedeconduceresoferi);
            // TODO: This line of code loads data into the 'dataSetFormCategorii.soferivatmani' table. You can move, or remove it, as needed.
            this.soferivatmaniTableAdapter.Fill(this.dataSetFormCategorii.soferivatmani);
            // TODO: This line of code loads data into the 'dataSetFormCategorii.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.dataSetFormCategorii.angajati);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idangajatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void angajatiBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
