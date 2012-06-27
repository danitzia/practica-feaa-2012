namespace Gestiunea_retelei_de_transport_public
{
    partial class FormSoferiMijloaceDeTransport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idangajatLabel;
            System.Windows.Forms.Label cnpLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label idsoferLabel;
            System.Windows.Forms.Label dataangajareLabel;
            System.Windows.Forms.Label idangajatLabel1;
            System.Windows.Forms.Label idsoferLabel1;
            System.Windows.Forms.Label dataangajareLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoferiMijloaceDeTransport));
            this.dataSetFormSoferiMijloaceDeTransport = new Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransport();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransportTableAdapters.angajatiTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransportTableAdapters.TableAdapterManager();
            this.soferimijdetransportTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransportTableAdapters.soferimijdetransportTableAdapter();
            this.soferivatmaniTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransportTableAdapters.soferivatmaniTableAdapter();
            this.angajatiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.angajatiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idangajatTextBox = new System.Windows.Forms.TextBox();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.idsoferTextBox = new System.Windows.Forms.TextBox();
            this.dataangajareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soferivatmaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idangajatTextBox1 = new System.Windows.Forms.TextBox();
            this.idsoferTextBox1 = new System.Windows.Forms.TextBox();
            this.dataangajareDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.soferimijdetransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soferimijdetransportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            idangajatLabel = new System.Windows.Forms.Label();
            cnpLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            idsoferLabel = new System.Windows.Forms.Label();
            dataangajareLabel = new System.Windows.Forms.Label();
            idangajatLabel1 = new System.Windows.Forms.Label();
            idsoferLabel1 = new System.Windows.Forms.Label();
            dataangajareLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormSoferiMijloaceDeTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).BeginInit();
            this.angajatiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferimijdetransportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferimijdetransportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idangajatLabel
            // 
            idangajatLabel.AutoSize = true;
            idangajatLabel.Location = new System.Drawing.Point(62, 32);
            idangajatLabel.Name = "idangajatLabel";
            idangajatLabel.Size = new System.Drawing.Size(55, 13);
            idangajatLabel.TabIndex = 1;
            idangajatLabel.Text = "IdAngajat:";
            // 
            // cnpLabel
            // 
            cnpLabel.AutoSize = true;
            cnpLabel.Location = new System.Drawing.Point(62, 58);
            cnpLabel.Name = "cnpLabel";
            cnpLabel.Size = new System.Drawing.Size(32, 13);
            cnpLabel.TabIndex = 3;
            cnpLabel.Text = "CNP:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(62, 84);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(62, 110);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(52, 13);
            prenumeLabel.TabIndex = 7;
            prenumeLabel.Text = "Prenume:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(62, 136);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Sex:";
            // 
            // idsoferLabel
            // 
            idsoferLabel.AutoSize = true;
            idsoferLabel.Location = new System.Drawing.Point(62, 162);
            idsoferLabel.Name = "idsoferLabel";
            idsoferLabel.Size = new System.Drawing.Size(44, 13);
            idsoferLabel.TabIndex = 11;
            idsoferLabel.Text = "IdSofer:";
            // 
            // dataangajareLabel
            // 
            dataangajareLabel.AutoSize = true;
            dataangajareLabel.Location = new System.Drawing.Point(62, 189);
            dataangajareLabel.Name = "dataangajareLabel";
            dataangajareLabel.Size = new System.Drawing.Size(75, 13);
            dataangajareLabel.TabIndex = 13;
            dataangajareLabel.Text = "DataAngajare:";
            // 
            // idangajatLabel1
            // 
            idangajatLabel1.AutoSize = true;
            idangajatLabel1.Location = new System.Drawing.Point(374, 32);
            idangajatLabel1.Name = "idangajatLabel1";
            idangajatLabel1.Size = new System.Drawing.Size(55, 13);
            idangajatLabel1.TabIndex = 15;
            idangajatLabel1.Text = "IdAngajat:";
            // 
            // idsoferLabel1
            // 
            idsoferLabel1.AutoSize = true;
            idsoferLabel1.Location = new System.Drawing.Point(374, 58);
            idsoferLabel1.Name = "idsoferLabel1";
            idsoferLabel1.Size = new System.Drawing.Size(44, 13);
            idsoferLabel1.TabIndex = 17;
            idsoferLabel1.Text = "IdSofer:";
            // 
            // dataangajareLabel1
            // 
            dataangajareLabel1.AutoSize = true;
            dataangajareLabel1.Location = new System.Drawing.Point(374, 85);
            dataangajareLabel1.Name = "dataangajareLabel1";
            dataangajareLabel1.Size = new System.Drawing.Size(75, 13);
            dataangajareLabel1.TabIndex = 19;
            dataangajareLabel1.Text = "DataAngajare:";
            // 
            // dataSetFormSoferiMijloaceDeTransport
            // 
            this.dataSetFormSoferiMijloaceDeTransport.DataSetName = "DataSetFormSoferiMijloaceDeTransport";
            this.dataSetFormSoferiMijloaceDeTransport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "angajati";
            this.angajatiBindingSource.DataSource = this.dataSetFormSoferiMijloaceDeTransport;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.soferimijdetransportTableAdapter = this.soferimijdetransportTableAdapter;
            this.tableAdapterManager.soferivatmaniTableAdapter = this.soferivatmaniTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetFormSoferiMijloaceDeTransportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // soferimijdetransportTableAdapter
            // 
            this.soferimijdetransportTableAdapter.ClearBeforeFill = true;
            // 
            // soferivatmaniTableAdapter
            // 
            this.soferivatmaniTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiBindingNavigator
            // 
            this.angajatiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.angajatiBindingNavigator.BindingSource = this.angajatiBindingSource;
            this.angajatiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.angajatiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.angajatiBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.angajatiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.angajatiBindingNavigatorSaveItem});
            this.angajatiBindingNavigator.Location = new System.Drawing.Point(65, 1);
            this.angajatiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.angajatiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.angajatiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.angajatiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.angajatiBindingNavigator.Name = "angajatiBindingNavigator";
            this.angajatiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.angajatiBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.angajatiBindingNavigator.TabIndex = 0;
            this.angajatiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // angajatiBindingNavigatorSaveItem
            // 
            this.angajatiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.angajatiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("angajatiBindingNavigatorSaveItem.Image")));
            this.angajatiBindingNavigatorSaveItem.Name = "angajatiBindingNavigatorSaveItem";
            this.angajatiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.angajatiBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // idangajatTextBox
            // 
            this.idangajatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "idangajat", true));
            this.idangajatTextBox.Location = new System.Drawing.Point(140, 29);
            this.idangajatTextBox.Name = "idangajatTextBox";
            this.idangajatTextBox.Size = new System.Drawing.Size(200, 20);
            this.idangajatTextBox.TabIndex = 2;
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "cnp", true));
            this.cnpTextBox.Location = new System.Drawing.Point(140, 55);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(200, 20);
            this.cnpTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(140, 81);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(140, 107);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenumeTextBox.TabIndex = 8;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(140, 133);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexTextBox.TabIndex = 10;
            // 
            // idsoferTextBox
            // 
            this.idsoferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "idsofer", true));
            this.idsoferTextBox.Location = new System.Drawing.Point(140, 159);
            this.idsoferTextBox.Name = "idsoferTextBox";
            this.idsoferTextBox.Size = new System.Drawing.Size(200, 20);
            this.idsoferTextBox.TabIndex = 12;
            // 
            // dataangajareDateTimePicker
            // 
            this.dataangajareDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.angajatiBindingSource, "dataangajare", true));
            this.dataangajareDateTimePicker.Location = new System.Drawing.Point(140, 185);
            this.dataangajareDateTimePicker.Name = "dataangajareDateTimePicker";
            this.dataangajareDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataangajareDateTimePicker.TabIndex = 14;
            // 
            // soferivatmaniBindingSource
            // 
            this.soferivatmaniBindingSource.DataMember = "angajati_soferivatmani";
            this.soferivatmaniBindingSource.DataSource = this.angajatiBindingSource;
            // 
            // idangajatTextBox1
            // 
            this.idangajatTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soferivatmaniBindingSource, "idangajat", true));
            this.idangajatTextBox1.Location = new System.Drawing.Point(452, 29);
            this.idangajatTextBox1.Name = "idangajatTextBox1";
            this.idangajatTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idangajatTextBox1.TabIndex = 16;
            // 
            // idsoferTextBox1
            // 
            this.idsoferTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soferivatmaniBindingSource, "idsofer", true));
            this.idsoferTextBox1.Location = new System.Drawing.Point(452, 55);
            this.idsoferTextBox1.Name = "idsoferTextBox1";
            this.idsoferTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idsoferTextBox1.TabIndex = 18;
            // 
            // dataangajareDateTimePicker1
            // 
            this.dataangajareDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.soferivatmaniBindingSource, "dataangajare", true));
            this.dataangajareDateTimePicker1.Location = new System.Drawing.Point(452, 81);
            this.dataangajareDateTimePicker1.Name = "dataangajareDateTimePicker1";
            this.dataangajareDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dataangajareDateTimePicker1.TabIndex = 20;
            // 
            // soferimijdetransportBindingSource
            // 
            this.soferimijdetransportBindingSource.DataMember = "soferivatmani_soferimijdetransport";
            this.soferimijdetransportBindingSource.DataSource = this.soferivatmaniBindingSource;
            // 
            // soferimijdetransportDataGridView
            // 
            this.soferimijdetransportDataGridView.AutoGenerateColumns = false;
            this.soferimijdetransportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soferimijdetransportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.soferimijdetransportDataGridView.DataSource = this.soferimijdetransportBindingSource;
            this.soferimijdetransportDataGridView.Location = new System.Drawing.Point(377, 159);
            this.soferimijdetransportDataGridView.Name = "soferimijdetransportDataGridView";
            this.soferimijdetransportDataGridView.Size = new System.Drawing.Size(336, 220);
            this.soferimijdetransportDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idsofer";
            this.dataGridViewTextBoxColumn1.HeaderText = "idsofer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nrinmat";
            this.dataGridViewTextBoxColumn2.HeaderText = "nrinmat";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datapreluaremij";
            this.dataGridViewTextBoxColumn3.HeaderText = "datapreluaremij";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.soferimijdetransportBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(624, 382);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add/Del Preluare Vehicul->";
            // 
            // FormSoferiMijloaceDeTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.soferimijdetransportDataGridView);
            this.Controls.Add(idangajatLabel1);
            this.Controls.Add(this.idangajatTextBox1);
            this.Controls.Add(idsoferLabel1);
            this.Controls.Add(this.idsoferTextBox1);
            this.Controls.Add(dataangajareLabel1);
            this.Controls.Add(this.dataangajareDateTimePicker1);
            this.Controls.Add(idangajatLabel);
            this.Controls.Add(this.idangajatTextBox);
            this.Controls.Add(cnpLabel);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(idsoferLabel);
            this.Controls.Add(this.idsoferTextBox);
            this.Controls.Add(dataangajareLabel);
            this.Controls.Add(this.dataangajareDateTimePicker);
            this.Controls.Add(this.angajatiBindingNavigator);
            this.Name = "FormSoferiMijloaceDeTransport";
            this.Text = "FormSoferiMijloaceDeTransport";
            this.Load += new System.EventHandler(this.FormSoferiMijloaceDeTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormSoferiMijloaceDeTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).EndInit();
            this.angajatiBindingNavigator.ResumeLayout(false);
            this.angajatiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferimijdetransportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferimijdetransportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetFormSoferiMijloaceDeTransport dataSetFormSoferiMijloaceDeTransport;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private DataSetFormSoferiMijloaceDeTransportTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private DataSetFormSoferiMijloaceDeTransportTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator angajatiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton angajatiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idangajatTextBox;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox idsoferTextBox;
        private System.Windows.Forms.DateTimePicker dataangajareDateTimePicker;
        private DataSetFormSoferiMijloaceDeTransportTableAdapters.soferivatmaniTableAdapter soferivatmaniTableAdapter;
        private System.Windows.Forms.BindingSource soferivatmaniBindingSource;
        private DataSetFormSoferiMijloaceDeTransportTableAdapters.soferimijdetransportTableAdapter soferimijdetransportTableAdapter;
        private System.Windows.Forms.TextBox idangajatTextBox1;
        private System.Windows.Forms.TextBox idsoferTextBox1;
        private System.Windows.Forms.DateTimePicker dataangajareDateTimePicker1;
        private System.Windows.Forms.BindingSource soferimijdetransportBindingSource;
        private System.Windows.Forms.DataGridView soferimijdetransportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.Label label1;
    }
}