namespace Gestiunea_retelei_de_transport_public
{
    partial class FormularSoferiVatmaniSimplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularSoferiVatmaniSimplu));
            System.Windows.Forms.Label idangajatLabel;
            System.Windows.Forms.Label idsoferLabel;
            System.Windows.Forms.Label dataangajareLabel;
            this.dataSetSoferiVatmani = new Gestiunea_retelei_de_transport_public.DataSetSoferiVatmani();
            this.soferivatmaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soferivatmaniTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetSoferiVatmaniTableAdapters.soferivatmaniTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetSoferiVatmaniTableAdapters.TableAdapterManager();
            this.soferivatmaniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.soferivatmaniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idangajatTextBox = new System.Windows.Forms.TextBox();
            this.idsoferTextBox = new System.Windows.Forms.TextBox();
            this.dataangajareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soferivatmaniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idangajatLabel = new System.Windows.Forms.Label();
            idsoferLabel = new System.Windows.Forms.Label();
            dataangajareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSoferiVatmani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingNavigator)).BeginInit();
            this.soferivatmaniBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetSoferiVatmani
            // 
            this.dataSetSoferiVatmani.DataSetName = "DataSetSoferiVatmani";
            this.dataSetSoferiVatmani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soferivatmaniBindingSource
            // 
            this.soferivatmaniBindingSource.DataMember = "soferivatmani";
            this.soferivatmaniBindingSource.DataSource = this.dataSetSoferiVatmani;
            // 
            // soferivatmaniTableAdapter
            // 
            this.soferivatmaniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.soferivatmaniTableAdapter = this.soferivatmaniTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetSoferiVatmaniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // soferivatmaniBindingNavigator
            // 
            this.soferivatmaniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.soferivatmaniBindingNavigator.BindingSource = this.soferivatmaniBindingSource;
            this.soferivatmaniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.soferivatmaniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.soferivatmaniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.soferivatmaniBindingNavigatorSaveItem});
            this.soferivatmaniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.soferivatmaniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.soferivatmaniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.soferivatmaniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.soferivatmaniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.soferivatmaniBindingNavigator.Name = "soferivatmaniBindingNavigator";
            this.soferivatmaniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.soferivatmaniBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.soferivatmaniBindingNavigator.TabIndex = 0;
            this.soferivatmaniBindingNavigator.Text = "bindingNavigator1";
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
            // soferivatmaniBindingNavigatorSaveItem
            // 
            this.soferivatmaniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.soferivatmaniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("soferivatmaniBindingNavigatorSaveItem.Image")));
            this.soferivatmaniBindingNavigatorSaveItem.Name = "soferivatmaniBindingNavigatorSaveItem";
            this.soferivatmaniBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.soferivatmaniBindingNavigatorSaveItem.Text = "Save Data";
            this.soferivatmaniBindingNavigatorSaveItem.Click += new System.EventHandler(this.soferivatmaniBindingNavigatorSaveItem_Click);
            // 
            // idangajatLabel
            // 
            idangajatLabel.AutoSize = true;
            idangajatLabel.Location = new System.Drawing.Point(77, 49);
            idangajatLabel.Name = "idangajatLabel";
            idangajatLabel.Size = new System.Drawing.Size(53, 13);
            idangajatLabel.TabIndex = 1;
            idangajatLabel.Text = "idangajat:";
            // 
            // idangajatTextBox
            // 
            this.idangajatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soferivatmaniBindingSource, "idangajat", true));
            this.idangajatTextBox.Location = new System.Drawing.Point(155, 46);
            this.idangajatTextBox.Name = "idangajatTextBox";
            this.idangajatTextBox.Size = new System.Drawing.Size(200, 20);
            this.idangajatTextBox.TabIndex = 2;
            // 
            // idsoferLabel
            // 
            idsoferLabel.AutoSize = true;
            idsoferLabel.Location = new System.Drawing.Point(77, 75);
            idsoferLabel.Name = "idsoferLabel";
            idsoferLabel.Size = new System.Drawing.Size(41, 13);
            idsoferLabel.TabIndex = 3;
            idsoferLabel.Text = "idsofer:";
            // 
            // idsoferTextBox
            // 
            this.idsoferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.soferivatmaniBindingSource, "idsofer", true));
            this.idsoferTextBox.Location = new System.Drawing.Point(155, 72);
            this.idsoferTextBox.Name = "idsoferTextBox";
            this.idsoferTextBox.Size = new System.Drawing.Size(200, 20);
            this.idsoferTextBox.TabIndex = 4;
            // 
            // dataangajareLabel
            // 
            dataangajareLabel.AutoSize = true;
            dataangajareLabel.Location = new System.Drawing.Point(77, 102);
            dataangajareLabel.Name = "dataangajareLabel";
            dataangajareLabel.Size = new System.Drawing.Size(72, 13);
            dataangajareLabel.TabIndex = 5;
            dataangajareLabel.Text = "dataangajare:";
            // 
            // dataangajareDateTimePicker
            // 
            this.dataangajareDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.soferivatmaniBindingSource, "dataangajare", true));
            this.dataangajareDateTimePicker.Location = new System.Drawing.Point(155, 98);
            this.dataangajareDateTimePicker.Name = "dataangajareDateTimePicker";
            this.dataangajareDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataangajareDateTimePicker.TabIndex = 6;
            // 
            // soferivatmaniDataGridView
            // 
            this.soferivatmaniDataGridView.AutoGenerateColumns = false;
            this.soferivatmaniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soferivatmaniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.soferivatmaniDataGridView.DataSource = this.soferivatmaniBindingSource;
            this.soferivatmaniDataGridView.Location = new System.Drawing.Point(58, 144);
            this.soferivatmaniDataGridView.Name = "soferivatmaniDataGridView";
            this.soferivatmaniDataGridView.Size = new System.Drawing.Size(362, 225);
            this.soferivatmaniDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idangajat";
            this.dataGridViewTextBoxColumn1.HeaderText = "idangajat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idsofer";
            this.dataGridViewTextBoxColumn2.HeaderText = "idsofer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataangajare";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataangajare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormularSoferiVatmaniSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 431);
            this.Controls.Add(this.soferivatmaniDataGridView);
            this.Controls.Add(idangajatLabel);
            this.Controls.Add(this.idangajatTextBox);
            this.Controls.Add(idsoferLabel);
            this.Controls.Add(this.idsoferTextBox);
            this.Controls.Add(dataangajareLabel);
            this.Controls.Add(this.dataangajareDateTimePicker);
            this.Controls.Add(this.soferivatmaniBindingNavigator);
            this.Name = "FormularSoferiVatmaniSimplu";
            this.Text = "FormularSoferiVatmaniSimplu";
            this.Load += new System.EventHandler(this.FormularSoferiVatmaniSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSoferiVatmani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniBindingNavigator)).EndInit();
            this.soferivatmaniBindingNavigator.ResumeLayout(false);
            this.soferivatmaniBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soferivatmaniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetSoferiVatmani dataSetSoferiVatmani;
        private System.Windows.Forms.BindingSource soferivatmaniBindingSource;
        private DataSetSoferiVatmaniTableAdapters.soferivatmaniTableAdapter soferivatmaniTableAdapter;
        private DataSetSoferiVatmaniTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator soferivatmaniBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton soferivatmaniBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idangajatTextBox;
        private System.Windows.Forms.TextBox idsoferTextBox;
        private System.Windows.Forms.DateTimePicker dataangajareDateTimePicker;
        private System.Windows.Forms.DataGridView soferivatmaniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}