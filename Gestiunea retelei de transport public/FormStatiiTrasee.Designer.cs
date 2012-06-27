namespace Gestiunea_retelei_de_transport_public
{
    partial class FormStatiiTrasee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatiiTrasee));
            System.Windows.Forms.Label idstatieLabel;
            System.Windows.Forms.Label denstatieLabel;
            this.dataSetFormStatiiTrasee = new Gestiunea_retelei_de_transport_public.DataSetFormStatiiTrasee();
            this.statiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statiiTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormStatiiTraseeTableAdapters.statiiTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetFormStatiiTraseeTableAdapters.TableAdapterManager();
            this.statiiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.statiiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idstatieTextBox = new System.Windows.Forms.TextBox();
            this.denstatieTextBox = new System.Windows.Forms.TextBox();
            this.statiiletraseuluiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statiiletraseuluiTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormStatiiTraseeTableAdapters.statiiletraseuluiTableAdapter();
            this.statiiletraseuluiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idstatieLabel = new System.Windows.Forms.Label();
            denstatieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormStatiiTrasee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiBindingNavigator)).BeginInit();
            this.statiiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statiiletraseuluiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiletraseuluiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetFormStatiiTrasee
            // 
            this.dataSetFormStatiiTrasee.DataSetName = "DataSetFormStatiiTrasee";
            this.dataSetFormStatiiTrasee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statiiBindingSource
            // 
            this.statiiBindingSource.DataMember = "statii";
            this.statiiBindingSource.DataSource = this.dataSetFormStatiiTrasee;
            // 
            // statiiTableAdapter
            // 
            this.statiiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.statiiletraseuluiTableAdapter = this.statiiletraseuluiTableAdapter;
            this.tableAdapterManager.statiiTableAdapter = this.statiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetFormStatiiTraseeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statiiBindingNavigator
            // 
            this.statiiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statiiBindingNavigator.BindingSource = this.statiiBindingSource;
            this.statiiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statiiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statiiBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.statiiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statiiBindingNavigatorSaveItem});
            this.statiiBindingNavigator.Location = new System.Drawing.Point(24, 67);
            this.statiiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statiiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statiiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statiiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statiiBindingNavigator.Name = "statiiBindingNavigator";
            this.statiiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statiiBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.statiiBindingNavigator.TabIndex = 0;
            this.statiiBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // statiiBindingNavigatorSaveItem
            // 
            this.statiiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statiiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statiiBindingNavigatorSaveItem.Image")));
            this.statiiBindingNavigatorSaveItem.Name = "statiiBindingNavigatorSaveItem";
            this.statiiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.statiiBindingNavigatorSaveItem.Text = "Save Data";
            this.statiiBindingNavigatorSaveItem.Click += new System.EventHandler(this.statiiBindingNavigatorSaveItem_Click_2);
            // 
            // idstatieLabel
            // 
            idstatieLabel.AutoSize = true;
            idstatieLabel.Location = new System.Drawing.Point(128, 21);
            idstatieLabel.Name = "idstatieLabel";
            idstatieLabel.Size = new System.Drawing.Size(43, 13);
            idstatieLabel.TabIndex = 1;
            idstatieLabel.Text = "idstatie:";
            // 
            // idstatieTextBox
            // 
            this.idstatieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statiiBindingSource, "idstatie", true));
            this.idstatieTextBox.Location = new System.Drawing.Point(187, 18);
            this.idstatieTextBox.Name = "idstatieTextBox";
            this.idstatieTextBox.Size = new System.Drawing.Size(100, 20);
            this.idstatieTextBox.TabIndex = 2;
            // 
            // denstatieLabel
            // 
            denstatieLabel.AutoSize = true;
            denstatieLabel.Location = new System.Drawing.Point(128, 47);
            denstatieLabel.Name = "denstatieLabel";
            denstatieLabel.Size = new System.Drawing.Size(53, 13);
            denstatieLabel.TabIndex = 3;
            denstatieLabel.Text = "denstatie:";
            // 
            // denstatieTextBox
            // 
            this.denstatieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statiiBindingSource, "denstatie", true));
            this.denstatieTextBox.Location = new System.Drawing.Point(187, 44);
            this.denstatieTextBox.Name = "denstatieTextBox";
            this.denstatieTextBox.Size = new System.Drawing.Size(100, 20);
            this.denstatieTextBox.TabIndex = 4;
            // 
            // statiiletraseuluiBindingSource
            // 
            this.statiiletraseuluiBindingSource.DataMember = "statii_statiiletraseului";
            this.statiiletraseuluiBindingSource.DataSource = this.statiiBindingSource;
            // 
            // statiiletraseuluiTableAdapter
            // 
            this.statiiletraseuluiTableAdapter.ClearBeforeFill = true;
            // 
            // statiiletraseuluiDataGridView
            // 
            this.statiiletraseuluiDataGridView.AutoGenerateColumns = false;
            this.statiiletraseuluiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statiiletraseuluiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.statiiletraseuluiDataGridView.DataSource = this.statiiletraseuluiBindingSource;
            this.statiiletraseuluiDataGridView.Location = new System.Drawing.Point(320, 12);
            this.statiiletraseuluiDataGridView.Name = "statiiletraseuluiDataGridView";
            this.statiiletraseuluiDataGridView.Size = new System.Drawing.Size(301, 220);
            this.statiiletraseuluiDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idstatie";
            this.dataGridViewTextBoxColumn1.HeaderText = "idstatie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idtraseu";
            this.dataGridViewTextBoxColumn2.HeaderText = "idtraseu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nrstatie";
            this.dataGridViewTextBoxColumn3.HeaderText = "nrstatie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormStatiiTrasee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 285);
            this.Controls.Add(this.statiiletraseuluiDataGridView);
            this.Controls.Add(idstatieLabel);
            this.Controls.Add(this.idstatieTextBox);
            this.Controls.Add(denstatieLabel);
            this.Controls.Add(this.denstatieTextBox);
            this.Controls.Add(this.statiiBindingNavigator);
            this.Name = "FormStatiiTrasee";
            this.Text = "FormStatiiTrasee";
            this.Load += new System.EventHandler(this.FormStatiiTrasee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormStatiiTrasee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiBindingNavigator)).EndInit();
            this.statiiBindingNavigator.ResumeLayout(false);
            this.statiiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statiiletraseuluiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statiiletraseuluiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetFormStatiiTrasee dataSetFormStatiiTrasee;
        private System.Windows.Forms.BindingSource statiiBindingSource;
        private DataSetFormStatiiTraseeTableAdapters.statiiTableAdapter statiiTableAdapter;
        private DataSetFormStatiiTraseeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statiiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statiiBindingNavigatorSaveItem;
        private DataSetFormStatiiTraseeTableAdapters.statiiletraseuluiTableAdapter statiiletraseuluiTableAdapter;
        private System.Windows.Forms.TextBox idstatieTextBox;
        private System.Windows.Forms.TextBox denstatieTextBox;
        private System.Windows.Forms.BindingSource statiiletraseuluiBindingSource;
        private System.Windows.Forms.DataGridView statiiletraseuluiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;


    }
}