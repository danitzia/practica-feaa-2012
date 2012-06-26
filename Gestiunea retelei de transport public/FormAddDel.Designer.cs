namespace Gestiunea_retelei_de_transport_public
{
    partial class frmAngajati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAngajati));
            this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
            this.BtnStergere = new System.Windows.Forms.Button();
            this.BtnAdauga = new System.Windows.Forms.Button();
            this.txtIdAngDel = new System.Windows.Forms.TextBox();
            this.txtIdang = new System.Windows.Forms.TextBox();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblIdAng = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblIdAngDel = new System.Windows.Forms.Label();
            this.grdAngajati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // odbcSelectCommand1
            // 
            this.odbcSelectCommand1.CommandText = "select * from angajati";
            this.odbcSelectCommand1.Connection = this.odbcConnection1;
            // 
            // odbcConnection1
            // 
            this.odbcConnection1.ConnectionString = resources.GetString("odbcConnection1.ConnectionString");
            // 
            // odbcDataAdapter1
            // 
            this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
            this.odbcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idangajat", "idangajat"),
                        new System.Data.Common.DataColumnMapping("cnp", "cnp"),
                        new System.Data.Common.DataColumnMapping("nume", "nume"),
                        new System.Data.Common.DataColumnMapping("prenume", "prenume"),
                        new System.Data.Common.DataColumnMapping("sex", "sex")})});
            // 
            // BtnStergere
            // 
            this.BtnStergere.Location = new System.Drawing.Point(435, 275);
            this.BtnStergere.Name = "BtnStergere";
            this.BtnStergere.Size = new System.Drawing.Size(75, 23);
            this.BtnStergere.TabIndex = 0;
            this.BtnStergere.Text = "Sterge";
            this.BtnStergere.UseVisualStyleBackColor = true;
            this.BtnStergere.Click += new System.EventHandler(this.BtnStergere_Click);
            // 
            // BtnAdauga
            // 
            this.BtnAdauga.Location = new System.Drawing.Point(435, 378);
            this.BtnAdauga.Name = "BtnAdauga";
            this.BtnAdauga.Size = new System.Drawing.Size(75, 23);
            this.BtnAdauga.TabIndex = 1;
            this.BtnAdauga.Text = "Adauga";
            this.BtnAdauga.UseVisualStyleBackColor = true;
            this.BtnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // txtIdAngDel
            // 
            this.txtIdAngDel.Location = new System.Drawing.Point(167, 275);
            this.txtIdAngDel.Name = "txtIdAngDel";
            this.txtIdAngDel.Size = new System.Drawing.Size(247, 20);
            this.txtIdAngDel.TabIndex = 2;
            // 
            // txtIdang
            // 
            this.txtIdang.Location = new System.Drawing.Point(35, 378);
            this.txtIdang.Name = "txtIdang";
            this.txtIdang.Size = new System.Drawing.Size(71, 20);
            this.txtIdang.TabIndex = 3;
            // 
            // txtCnp
            // 
            this.txtCnp.Location = new System.Drawing.Point(112, 378);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.Size = new System.Drawing.Size(71, 20);
            this.txtCnp.TabIndex = 4;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(189, 378);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(71, 20);
            this.txtNume.TabIndex = 5;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(266, 378);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(71, 20);
            this.txtPrenume.TabIndex = 6;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(343, 378);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(71, 20);
            this.txtSex.TabIndex = 7;
            // 
            // lblIdAng
            // 
            this.lblIdAng.AutoSize = true;
            this.lblIdAng.Location = new System.Drawing.Point(41, 361);
            this.lblIdAng.Name = "lblIdAng";
            this.lblIdAng.Size = new System.Drawing.Size(52, 13);
            this.lblIdAng.TabIndex = 8;
            this.lblIdAng.Text = "IdAngajat";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(122, 361);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 9;
            this.lblCNP.Text = "CNP";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(198, 361);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 10;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(272, 362);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 11;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(360, 361);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sex";
            // 
            // lblIdAngDel
            // 
            this.lblIdAngDel.AutoSize = true;
            this.lblIdAngDel.Location = new System.Drawing.Point(41, 275);
            this.lblIdAngDel.Name = "lblIdAngDel";
            this.lblIdAngDel.Size = new System.Drawing.Size(52, 13);
            this.lblIdAngDel.TabIndex = 13;
            this.lblIdAngDel.Text = "IdAngajat";
            // 
            // grdAngajati
            // 
            this.grdAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAngajati.Location = new System.Drawing.Point(20, 23);
            this.grdAngajati.Name = "grdAngajati";
            this.grdAngajati.Size = new System.Drawing.Size(544, 225);
            this.grdAngajati.TabIndex = 14;
            this.grdAngajati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 426);
            this.Controls.Add(this.grdAngajati);
            this.Controls.Add(this.lblIdAngDel);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblIdAng);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCnp);
            this.Controls.Add(this.txtIdang);
            this.Controls.Add(this.txtIdAngDel);
            this.Controls.Add(this.BtnAdauga);
            this.Controls.Add(this.BtnStergere);
            this.Name = "frmAngajati";
            this.Text = "Add/DelAng";
            this.Load += new System.EventHandler(this.frmAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Windows.Forms.Button BtnStergere;
        private System.Windows.Forms.Button BtnAdauga;
        private System.Windows.Forms.TextBox txtIdAngDel;
        private System.Windows.Forms.TextBox txtIdang;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblIdAng;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblIdAngDel;
        private System.Windows.Forms.DataGridView grdAngajati;
    }
}

