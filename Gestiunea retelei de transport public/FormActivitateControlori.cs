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
    public partial class FormActivitateControlori : Form
    {
        public FormActivitateControlori()
        {
            InitializeComponent();
        }

        private void controloriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.controloriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
            this.activitatecontroloriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
            this.angajatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);
        }

        private void FormActivitateControlori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postgresDataSet.activitatecontrolori' table. You can move, or remove it, as needed.
            this.activitatecontroloriTableAdapter.Fill(this.postgresDataSet.activitatecontrolori);
            // TODO: This line of code loads data into the 'postgresDataSet.controlori' table. You can move, or remove it, as needed.
            this.controloriTableAdapter.Fill(this.postgresDataSet.controlori);
            // TODO: This line of code loads data into the 'postgresDataSet.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.postgresDataSet.angajati);
            // TODO: This line of code loads data into the 'postgresDataSet.controlori' table. You can move, or remove it, as needed.
            this.controloriTableAdapter.Fill(this.postgresDataSet.controlori);
            // TODO: This line of code loads data into the 'postgresDataSet.controlori' table. You can move, or remove it, as needed.
            this.controloriTableAdapter.Fill(this.postgresDataSet.controlori);

        }

        private void controloriBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.controloriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void angajatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.angajatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }


        void activitatecontroloriDataGridView_CellValidating(object sender, System.Windows.Forms.DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex < this.activitatecontroloriDataGridView.Rows.Count - 1)
            {
                try
                {
                    int.Parse(e.FormattedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    e.Cancel = true;
                    System.Windows.Forms.MessageBox.Show("Tipul de data trebuie sa fie numeric!");

                }
            }

            if (e.ColumnIndex == 1 && e.RowIndex < this.activitatecontroloriDataGridView.Rows.Count - 1)
            {
                try
                {
                    String input = e.FormattedValue.ToString();
                    int k = 0;
                    for (int i = 0; i < input.Length; i++)
                        if (input[i] == '/')
                            k++;

                    if (k != 2) throw new Exception("w/e");
                    else
                    {
                        String[] split = input.Split('/');
                        if (split.Length != 3) throw new Exception("w/e");

                        int zi = int.Parse(split[0]);
                        if (zi < 1 || zi > 31) throw new Exception("w/e");
                        int luna = int.Parse(split[1]);
                        if (luna < 1 || luna > 12) throw new Exception("w/e");
                        int an = int.Parse(split[2]);
                    }
                }
                catch (System.Exception ex)
                {
                    e.Cancel = true;
                    System.Windows.Forms.MessageBox.Show("Tipul de data trebuie sa fie de tip date!");
                }
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void angajatiBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}