namespace Gestiunea_retelei_de_transport_public
{
    partial class FormularMijTransSimplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularMijTransSimplu));
            System.Windows.Forms.Label nrinmatLabel;
            System.Windows.Forms.Label idtipvehLabel;
            System.Windows.Forms.Label anfabricatieLabel;
            this.dataSetFormMijTransSimplu = new Gestiunea_retelei_de_transport_public.dataSetFormMijTransSimplu();
            this.mijtransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mijtransTableAdapter = new Gestiunea_retelei_de_transport_public.dataSetFormMijTransSimpluTableAdapters.mijtransTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.dataSetFormMijTransSimpluTableAdapters.TableAdapterManager();
            this.mijtransBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mijtransBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nrinmatTextBox = new System.Windows.Forms.TextBox();
            this.idtipvehTextBox = new System.Windows.Forms.TextBox();
            this.anfabricatieTextBox = new System.Windows.Forms.TextBox();
            this.mijtransDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nrinmatLabel = new System.Windows.Forms.Label();
            idtipvehLabel = new System.Windows.Forms.Label();
            anfabricatieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormMijTransSimplu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransBindingNavigator)).BeginInit();
            this.mijtransBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetFormMijTransSimplu
            // 
            this.dataSetFormMijTransSimplu.DataSetName = "dataSetFormMijTransSimplu";
            this.dataSetFormMijTransSimplu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mijtransBindingSource
            // 
            this.mijtransBindingSource.DataMember = "mijtrans";
            this.mijtransBindingSource.DataSource = this.dataSetFormMijTransSimplu;
            // 
            // mijtransTableAdapter
            // 
            this.mijtransTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.mijtransTableAdapter = this.mijtransTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.dataSetFormMijTransSimpluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mijtransBindingNavigator
            // 
            this.mijtransBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mijtransBindingNavigator.BindingSource = this.mijtransBindingSource;
            this.mijtransBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mijtransBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mijtransBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mijtransBindingNavigatorSaveItem});
            this.mijtransBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mijtransBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mijtransBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mijtransBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mijtransBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mijtransBindingNavigator.Name = "mijtransBindingNavigator";
            this.mijtransBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mijtransBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.mijtransBindingNavigator.TabIndex = 0;
            this.mijtransBindingNavigator.Text = "bindingNavigator1";
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
            // mijtransBindingNavigatorSaveItem
            // 
            this.mijtransBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mijtransBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mijtransBindingNavigatorSaveItem.Image")));
            this.mijtransBindingNavigatorSaveItem.Name = "mijtransBindingNavigatorSaveItem";
            this.mijtransBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mijtransBindingNavigatorSaveItem.Text = "Save Data";
            this.mijtransBindingNavigatorSaveItem.Click += new System.EventHandler(this.mijtransBindingNavigatorSaveItem_Click);
            // 
            // nrinmatLabel
            // 
            nrinmatLabel.AutoSize = true;
            nrinmatLabel.Location = new System.Drawing.Point(36, 49);
            nrinmatLabel.Name = "nrinmatLabel";
            nrinmatLabel.Size = new System.Drawing.Size(44, 13);
            nrinmatLabel.TabIndex = 1;
            nrinmatLabel.Text = "nrinmat:";
            // 
            // nrinmatTextBox
            // 
            this.nrinmatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijtransBindingSource, "nrinmat", true));
            this.nrinmatTextBox.Location = new System.Drawing.Point(107, 46);
            this.nrinmatTextBox.Name = "nrinmatTextBox";
            this.nrinmatTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrinmatTextBox.TabIndex = 2;
            // 
            // idtipvehLabel
            // 
            idtipvehLabel.AutoSize = true;
            idtipvehLabel.Location = new System.Drawing.Point(36, 75);
            idtipvehLabel.Name = "idtipvehLabel";
            idtipvehLabel.Size = new System.Drawing.Size(47, 13);
            idtipvehLabel.TabIndex = 3;
            idtipvehLabel.Text = "idtipveh:";
            // 
            // idtipvehTextBox
            // 
            this.idtipvehTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijtransBindingSource, "idtipveh", true));
            this.idtipvehTextBox.Location = new System.Drawing.Point(107, 72);
            this.idtipvehTextBox.Name = "idtipvehTextBox";
            this.idtipvehTextBox.Size = new System.Drawing.Size(100, 20);
            this.idtipvehTextBox.TabIndex = 4;
            // 
            // anfabricatieLabel
            // 
            anfabricatieLabel.AutoSize = true;
            anfabricatieLabel.Location = new System.Drawing.Point(36, 101);
            anfabricatieLabel.Name = "anfabricatieLabel";
            anfabricatieLabel.Size = new System.Drawing.Size(65, 13);
            anfabricatieLabel.TabIndex = 5;
            anfabricatieLabel.Text = "anfabricatie:";
            // 
            // anfabricatieTextBox
            // 
            this.anfabricatieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijtransBindingSource, "anfabricatie", true));
            this.anfabricatieTextBox.Location = new System.Drawing.Point(107, 98);
            this.anfabricatieTextBox.Name = "anfabricatieTextBox";
            this.anfabricatieTextBox.Size = new System.Drawing.Size(100, 20);
            this.anfabricatieTextBox.TabIndex = 6;
            // 
            // mijtransDataGridView
            // 
            this.mijtransDataGridView.AutoGenerateColumns = false;
            this.mijtransDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mijtransDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mijtransDataGridView.DataSource = this.mijtransBindingSource;
            this.mijtransDataGridView.Location = new System.Drawing.Point(39, 146);
            this.mijtransDataGridView.Name = "mijtransDataGridView";
            this.mijtransDataGridView.Size = new System.Drawing.Size(360, 220);
            this.mijtransDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nrinmat";
            this.dataGridViewTextBoxColumn1.HeaderText = "nrinmat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idtipveh";
            this.dataGridViewTextBoxColumn2.HeaderText = "idtipveh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "anfabricatie";
            this.dataGridViewTextBoxColumn3.HeaderText = "anfabricatie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormularMijTransSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 412);
            this.Controls.Add(this.mijtransDataGridView);
            this.Controls.Add(nrinmatLabel);
            this.Controls.Add(this.nrinmatTextBox);
            this.Controls.Add(idtipvehLabel);
            this.Controls.Add(this.idtipvehTextBox);
            this.Controls.Add(anfabricatieLabel);
            this.Controls.Add(this.anfabricatieTextBox);
            this.Controls.Add(this.mijtransBindingNavigator);
            this.Name = "FormularMijTransSimplu";
            this.Text = "FormularMijTransSimplu";
            this.Load += new System.EventHandler(this.FormularMijTransSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormMijTransSimplu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransBindingNavigator)).EndInit();
            this.mijtransBindingNavigator.ResumeLayout(false);
            this.mijtransBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mijtransDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSetFormMijTransSimplu dataSetFormMijTransSimplu;
        private System.Windows.Forms.BindingSource mijtransBindingSource;
        private dataSetFormMijTransSimpluTableAdapters.mijtransTableAdapter mijtransTableAdapter;
        private dataSetFormMijTransSimpluTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mijtransBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mijtransBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nrinmatTextBox;
        private System.Windows.Forms.TextBox idtipvehTextBox;
        private System.Windows.Forms.TextBox anfabricatieTextBox;
        private System.Windows.Forms.DataGridView mijtransDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}