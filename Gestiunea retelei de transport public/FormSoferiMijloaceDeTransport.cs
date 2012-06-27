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
    public partial class FormSoferiMijloaceDeTransport : Form
    {
        public FormSoferiMijloaceDeTransport()
        {
            InitializeComponent();
        }

        private void FormSoferiMijloaceDeTransport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetFormSoferiMijloaceDeTransport.soferimijdetransport' table. You can move, or remove it, as needed.
            this.soferimijdetransportTableAdapter.Fill(this.dataSetFormSoferiMijloaceDeTransport.soferimijdetransport);
            // TODO: This line of code loads data into the 'dataSetFormSoferiMijloaceDeTransport.soferivatmani' table. You can move, or remove it, as needed.
            this.soferivatmaniTableAdapter.Fill(this.dataSetFormSoferiMijloaceDeTransport.soferivatmani);
            // TODO: This line of code loads data into the 'dataSetFormSoferiMijloaceDeTransport.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.dataSetFormSoferiMijloaceDeTransport.angajati);

        }

       
    }
}
