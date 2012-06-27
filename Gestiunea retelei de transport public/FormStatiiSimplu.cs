﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiunea_retelei_de_transport_public
{
    public partial class FormStatiiSimplu : Form
    {
        public FormStatiiSimplu()
        {
            InitializeComponent();
        }

        private void statiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetStatiiSimplu);

        }

        private void FormStatiiSimplu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetStatiiSimplu.statii' table. You can move, or remove it, as needed.
            this.statiiTableAdapter.Fill(this.dataSetStatiiSimplu.statii);

        }
    }
}
