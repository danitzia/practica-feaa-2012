using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Gestiunea_retelei_de_transport_public
{
    public partial class FormAddDelSimplu : Form
    {
        private OdbcConnection conexiune;

        public  FormAddDelSimplu()
        {
            InitializeComponent();

            conexiune = new OdbcConnection();
            //stabilesc stringul de conectare
            conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=postgres;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=9iunie";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void frmAngajati_Load(object sender, EventArgs e)
        {
            conexiune.Open();
            
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.CommandText = "SELECT * FROM angajati";
            comanda.Connection = conexiune;

            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();

            DataSet dsDate;
            dsDate = new DataSet();

            DataTable tblAngajati;
            tblAngajati = new DataTable("Angajati");
            tblAngajati.Load(cititor);

            dsDate.Tables.Add(tblAngajati);

            //asignez coloanele din tabel catre combobox
            this.grdAngajati.DataSource = dsDate.Tables["Angajati"];
          

            conexiune.Close();
        }

        private void BtnStergere_Click(object sender, EventArgs e)
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.CommandText = "delete from angajati where idangajat=?";
            comanda.Connection = conexiune;
            comanda.Parameters.AddWithValue("idangajat", this.txtIdAngDel.Text);
            conexiune.Open();
            comanda.ExecuteNonQuery();

            DataTable dt = (DataTable)grdAngajati.DataSource;
            foreach (DataRow r in dt.Rows)
            {
                
                if (r.ItemArray[0].ToString().Contains(this.txtIdAngDel.Text))
                {
                    r.Delete();
                    r.AcceptChanges();
                    break;
                }
            }
            this.grdAngajati.Refresh();
            
            conexiune.Close();
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.CommandText = "insert into angajati values(?, ?, ?, ?, ?)";
            comanda.Connection = conexiune;
            comanda.Parameters.AddWithValue("idangajat", this.txtIdang.Text);
            comanda.Parameters.AddWithValue("cnp", this.txtCnp.Text);
            comanda.Parameters.AddWithValue("nume", this.txtNume.Text);
            comanda.Parameters.AddWithValue("prenume", this.txtPrenume.Text);
            comanda.Parameters.AddWithValue("sex", this.txtSex.Text);
            conexiune.Open();
            comanda.ExecuteNonQuery();

            DataTable table = (DataTable)this.grdAngajati.DataSource;
            DataRow row = table.NewRow();
            row.ItemArray = new object[] { this.txtIdang.Text, this.txtCnp.Text, this.txtNume.Text, this.txtPrenume.Text, this.txtSex.Text };
            //this.grdAngajati.Rows.Add(row);
            table.Rows.Add(row);
            table.AcceptChanges();
            conexiune.Close();
        }

       
    } }
    

