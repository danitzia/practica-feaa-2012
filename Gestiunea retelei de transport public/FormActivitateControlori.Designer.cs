namespace Gestiunea_retelei_de_transport_public
{
    partial class FormActivitateControlori
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
            System.Windows.Forms.Label idangajatLabel1;
            System.Windows.Forms.Label idcontrolorLabel;
            System.Windows.Forms.Label dataangajareLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivitateControlori));
            this.postgresDataSet = new Gestiunea_retelei_de_transport_public.postgresDataSet();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new Gestiunea_retelei_de_transport_public.postgresDataSetTableAdapters.angajatiTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.postgresDataSetTableAdapters.TableAdapterManager();
            this.activitatecontroloriTableAdapter = new Gestiunea_retelei_de_transport_public.postgresDataSetTableAdapters.activitatecontroloriTableAdapter();
            this.controloriTableAdapter = new Gestiunea_retelei_de_transport_public.postgresDataSetTableAdapters.controloriTableAdapter();
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
            this.controloriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idangajatTextBox1 = new System.Windows.Forms.TextBox();
            this.idcontrolorTextBox = new System.Windows.Forms.TextBox();
            this.dataangajareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activitatecontroloriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitatecontroloriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingActivitateControlori = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            idangajatLabel = new System.Windows.Forms.Label();
            cnpLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            idangajatLabel1 = new System.Windows.Forms.Label();
            idcontrolorLabel = new System.Windows.Forms.Label();
            dataangajareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).BeginInit();
            this.angajatiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatecontroloriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatecontroloriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingActivitateControlori)).BeginInit();
            this.bindingActivitateControlori.SuspendLayout();
            this.SuspendLayout();
            // 
            // idangajatLabel
            // 
            idangajatLabel.AutoSize = true;
            idangajatLabel.Location = new System.Drawing.Point(36, 61);
            idangajatLabel.Name = "idangajatLabel";
            idangajatLabel.Size = new System.Drawing.Size(53, 13);
            idangajatLabel.TabIndex = 1;
            idangajatLabel.Text = "idangajat:";
            // 
            // cnpLabel
            // 
            cnpLabel.AutoSize = true;
            cnpLabel.Location = new System.Drawing.Point(36, 87);
            cnpLabel.Name = "cnpLabel";
            cnpLabel.Size = new System.Drawing.Size(28, 13);
            cnpLabel.TabIndex = 3;
            cnpLabel.Text = "cnp:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(36, 113);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(36, 13);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Location = new System.Drawing.Point(36, 139);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(51, 13);
            prenumeLabel.TabIndex = 7;
            prenumeLabel.Text = "prenume:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(36, 165);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(26, 13);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "sex:";
            // 
            // idangajatLabel1
            // 
            idangajatLabel1.AutoSize = true;
            idangajatLabel1.Location = new System.Drawing.Point(327, 58);
            idangajatLabel1.Name = "idangajatLabel1";
            idangajatLabel1.Size = new System.Drawing.Size(53, 13);
            idangajatLabel1.TabIndex = 11;
            idangajatLabel1.Text = "idangajat:";
            // 
            // idcontrolorLabel
            // 
            idcontrolorLabel.AutoSize = true;
            idcontrolorLabel.Location = new System.Drawing.Point(327, 84);
            idcontrolorLabel.Name = "idcontrolorLabel";
            idcontrolorLabel.Size = new System.Drawing.Size(59, 13);
            idcontrolorLabel.TabIndex = 13;
            idcontrolorLabel.Text = "idcontrolor:";
            // 
            // dataangajareLabel
            // 
            dataangajareLabel.AutoSize = true;
            dataangajareLabel.Location = new System.Drawing.Point(327, 111);
            dataangajareLabel.Name = "dataangajareLabel";
            dataangajareLabel.Size = new System.Drawing.Size(72, 13);
            dataangajareLabel.TabIndex = 15;
            dataangajareLabel.Text = "dataangajare:";
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "angajati";
            this.angajatiBindingSource.DataSource = this.postgresDataSet;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activitatecontroloriTableAdapter = this.activitatecontroloriTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controloriTableAdapter = this.controloriTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // activitatecontroloriTableAdapter
            // 
            this.activitatecontroloriTableAdapter.ClearBeforeFill = true;
            // 
            // controloriTableAdapter
            // 
            this.controloriTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiBindingNavigator
            // 
            this.angajatiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.angajatiBindingNavigator.BindingSource = this.angajatiBindingSource;
            this.angajatiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.angajatiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.angajatiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.angajatiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.angajatiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.angajatiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.angajatiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.angajatiBindingNavigator.Name = "angajatiBindingNavigator";
            this.angajatiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.angajatiBindingNavigator.Size = new System.Drawing.Size(765, 25);
            this.angajatiBindingNavigator.TabIndex = 0;
            this.angajatiBindingNavigator.Text = "bindingNavigator1";
            this.angajatiBindingNavigator.RefreshItems += new System.EventHandler(this.angajatiBindingNavigator_RefreshItems);
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
            this.angajatiBindingNavigatorSaveItem.Click += new System.EventHandler(this.angajatiBindingNavigatorSaveItem_Click);
            // 
            // idangajatTextBox
            // 
            this.idangajatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "idangajat", true));
            this.idangajatTextBox.Location = new System.Drawing.Point(95, 58);
            this.idangajatTextBox.Name = "idangajatTextBox";
            this.idangajatTextBox.Size = new System.Drawing.Size(100, 20);
            this.idangajatTextBox.TabIndex = 2;
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "cnp", true));
            this.cnpTextBox.Location = new System.Drawing.Point(95, 84);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(95, 110);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 6;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(95, 136);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 8;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(95, 162);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexTextBox.TabIndex = 10;
            // 
            // controloriBindingSource
            // 
            this.controloriBindingSource.DataMember = "angajati_controlori";
            this.controloriBindingSource.DataSource = this.angajatiBindingSource;
            // 
            // idangajatTextBox1
            // 
            this.idangajatTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controloriBindingSource, "idangajat", true));
            this.idangajatTextBox1.Location = new System.Drawing.Point(405, 55);
            this.idangajatTextBox1.Name = "idangajatTextBox1";
            this.idangajatTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idangajatTextBox1.TabIndex = 12;
            // 
            // idcontrolorTextBox
            // 
            this.idcontrolorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controloriBindingSource, "idcontrolor", true));
            this.idcontrolorTextBox.Location = new System.Drawing.Point(405, 81);
            this.idcontrolorTextBox.Name = "idcontrolorTextBox";
            this.idcontrolorTextBox.Size = new System.Drawing.Size(200, 20);
            this.idcontrolorTextBox.TabIndex = 14;
            // 
            // dataangajareDateTimePicker
            // 
            this.dataangajareDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controloriBindingSource, "dataangajare", true));
            this.dataangajareDateTimePicker.Location = new System.Drawing.Point(405, 107);
            this.dataangajareDateTimePicker.Name = "dataangajareDateTimePicker";
            this.dataangajareDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataangajareDateTimePicker.TabIndex = 16;
            // 
            // activitatecontroloriBindingSource
            // 
            this.activitatecontroloriBindingSource.DataMember = "controlori_activitatecontrolori";
            this.activitatecontroloriBindingSource.DataSource = this.controloriBindingSource;
            // 
            // activitatecontroloriDataGridView
            // 
            this.activitatecontroloriDataGridView.AutoGenerateColumns = false;
            this.activitatecontroloriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitatecontroloriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.activitatecontroloriDataGridView.DataSource = this.activitatecontroloriBindingSource;
            this.activitatecontroloriDataGridView.Location = new System.Drawing.Point(330, 196);
            this.activitatecontroloriDataGridView.Name = "activitatecontroloriDataGridView";
            this.activitatecontroloriDataGridView.Size = new System.Drawing.Size(340, 220);
            this.activitatecontroloriDataGridView.TabIndex = 17;
            this.activitatecontroloriDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.activitatecontroloriDataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcontrolor";
            this.dataGridViewTextBoxColumn1.HeaderText = "idcontrolor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataactiv";
            this.dataGridViewTextBoxColumn2.HeaderText = "dataactiv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amenda";
            this.dataGridViewTextBoxColumn3.HeaderText = "amenda";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bindingActivitateControlori
            // 
            this.bindingActivitateControlori.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingActivitateControlori.BindingSource = this.activitatecontroloriBindingSource;
            this.bindingActivitateControlori.CountItem = this.bindingNavigatorCountItem1;
            this.bindingActivitateControlori.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingActivitateControlori.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingActivitateControlori.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingActivitateControlori.Location = new System.Drawing.Point(348, 419);
            this.bindingActivitateControlori.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingActivitateControlori.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingActivitateControlori.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingActivitateControlori.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingActivitateControlori.Name = "bindingActivitateControlori";
            this.bindingActivitateControlori.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingActivitateControlori.Size = new System.Drawing.Size(255, 25);
            this.bindingActivitateControlori.TabIndex = 18;
            this.bindingActivitateControlori.Text = "bindingActivitateControlori";
            this.bindingActivitateControlori.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // FormActivitateControlori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 508);
            this.Controls.Add(this.bindingActivitateControlori);
            this.Controls.Add(this.activitatecontroloriDataGridView);
            this.Controls.Add(idangajatLabel1);
            this.Controls.Add(this.idangajatTextBox1);
            this.Controls.Add(idcontrolorLabel);
            this.Controls.Add(this.idcontrolorTextBox);
            this.Controls.Add(dataangajareLabel);
            this.Controls.Add(this.dataangajareDateTimePicker);
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
            this.Controls.Add(this.angajatiBindingNavigator);
            this.Name = "FormActivitateControlori";
            this.Text = "FormActivitateControlori";
            this.Load += new System.EventHandler(this.FormActivitateControlori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingNavigator)).EndInit();
            this.angajatiBindingNavigator.ResumeLayout(false);
            this.angajatiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatecontroloriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitatecontroloriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingActivitateControlori)).EndInit();
            this.bindingActivitateControlori.ResumeLayout(false);
            this.bindingActivitateControlori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private postgresDataSetTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private postgresDataSetTableAdapters.controloriTableAdapter controloriTableAdapter;
        private System.Windows.Forms.TextBox idangajatTextBox;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.BindingSource controloriBindingSource;
        private postgresDataSetTableAdapters.activitatecontroloriTableAdapter activitatecontroloriTableAdapter;
        private System.Windows.Forms.TextBox idangajatTextBox1;
        private System.Windows.Forms.TextBox idcontrolorTextBox;
        private System.Windows.Forms.DateTimePicker dataangajareDateTimePicker;
        private System.Windows.Forms.BindingSource activitatecontroloriBindingSource;
        private System.Windows.Forms.DataGridView activitatecontroloriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator bindingActivitateControlori;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;


    }
}