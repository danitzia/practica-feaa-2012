namespace Gestiunea_retelei_de_transport_public
{
    partial class FormularControloriSimplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularControloriSimplu));
            System.Windows.Forms.Label idangajatLabel;
            System.Windows.Forms.Label idcontrolorLabel;
            System.Windows.Forms.Label dataangajareLabel;
            this.dataSetControloriSimplu = new Gestiunea_retelei_de_transport_public.DataSetControloriSimplu();
            this.controloriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controloriTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetControloriSimpluTableAdapters.controloriTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetControloriSimpluTableAdapters.TableAdapterManager();
            this.controloriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.controloriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idangajatTextBox = new System.Windows.Forms.TextBox();
            this.idcontrolorTextBox = new System.Windows.Forms.TextBox();
            this.dataangajareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.controloriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idangajatLabel = new System.Windows.Forms.Label();
            idcontrolorLabel = new System.Windows.Forms.Label();
            dataangajareLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetControloriSimplu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingNavigator)).BeginInit();
            this.controloriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controloriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetControloriSimplu
            // 
            this.dataSetControloriSimplu.DataSetName = "DataSetControloriSimplu";
            this.dataSetControloriSimplu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controloriBindingSource
            // 
            this.controloriBindingSource.DataMember = "controlori";
            this.controloriBindingSource.DataSource = this.dataSetControloriSimplu;
            // 
            // controloriTableAdapter
            // 
            this.controloriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controloriTableAdapter = this.controloriTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetControloriSimpluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // controloriBindingNavigator
            // 
            this.controloriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.controloriBindingNavigator.BindingSource = this.controloriBindingSource;
            this.controloriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.controloriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.controloriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.controloriBindingNavigatorSaveItem});
            this.controloriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.controloriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.controloriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.controloriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.controloriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.controloriBindingNavigator.Name = "controloriBindingNavigator";
            this.controloriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.controloriBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.controloriBindingNavigator.TabIndex = 0;
            this.controloriBindingNavigator.Text = "bindingNavigator1";
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
            // controloriBindingNavigatorSaveItem
            // 
            this.controloriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.controloriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("controloriBindingNavigatorSaveItem.Image")));
            this.controloriBindingNavigatorSaveItem.Name = "controloriBindingNavigatorSaveItem";
            this.controloriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.controloriBindingNavigatorSaveItem.Text = "Save Data";
            this.controloriBindingNavigatorSaveItem.Click += new System.EventHandler(this.controloriBindingNavigatorSaveItem_Click);
            // 
            // idangajatLabel
            // 
            idangajatLabel.AutoSize = true;
            idangajatLabel.Location = new System.Drawing.Point(99, 52);
            idangajatLabel.Name = "idangajatLabel";
            idangajatLabel.Size = new System.Drawing.Size(53, 13);
            idangajatLabel.TabIndex = 1;
            idangajatLabel.Text = "idangajat:";
            // 
            // idangajatTextBox
            // 
            this.idangajatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controloriBindingSource, "idangajat", true));
            this.idangajatTextBox.Location = new System.Drawing.Point(177, 49);
            this.idangajatTextBox.Name = "idangajatTextBox";
            this.idangajatTextBox.Size = new System.Drawing.Size(200, 20);
            this.idangajatTextBox.TabIndex = 2;
            // 
            // idcontrolorLabel
            // 
            idcontrolorLabel.AutoSize = true;
            idcontrolorLabel.Location = new System.Drawing.Point(99, 78);
            idcontrolorLabel.Name = "idcontrolorLabel";
            idcontrolorLabel.Size = new System.Drawing.Size(59, 13);
            idcontrolorLabel.TabIndex = 3;
            idcontrolorLabel.Text = "idcontrolor:";
            // 
            // idcontrolorTextBox
            // 
            this.idcontrolorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controloriBindingSource, "idcontrolor", true));
            this.idcontrolorTextBox.Location = new System.Drawing.Point(177, 75);
            this.idcontrolorTextBox.Name = "idcontrolorTextBox";
            this.idcontrolorTextBox.Size = new System.Drawing.Size(200, 20);
            this.idcontrolorTextBox.TabIndex = 4;
            // 
            // dataangajareLabel
            // 
            dataangajareLabel.AutoSize = true;
            dataangajareLabel.Location = new System.Drawing.Point(99, 105);
            dataangajareLabel.Name = "dataangajareLabel";
            dataangajareLabel.Size = new System.Drawing.Size(72, 13);
            dataangajareLabel.TabIndex = 5;
            dataangajareLabel.Text = "dataangajare:";
            // 
            // dataangajareDateTimePicker
            // 
            this.dataangajareDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controloriBindingSource, "dataangajare", true));
            this.dataangajareDateTimePicker.Location = new System.Drawing.Point(177, 101);
            this.dataangajareDateTimePicker.Name = "dataangajareDateTimePicker";
            this.dataangajareDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataangajareDateTimePicker.TabIndex = 6;
            // 
            // controloriDataGridView
            // 
            this.controloriDataGridView.AutoGenerateColumns = false;
            this.controloriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controloriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.controloriDataGridView.DataSource = this.controloriBindingSource;
            this.controloriDataGridView.Location = new System.Drawing.Point(67, 156);
            this.controloriDataGridView.Name = "controloriDataGridView";
            this.controloriDataGridView.Size = new System.Drawing.Size(356, 220);
            this.controloriDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idangajat";
            this.dataGridViewTextBoxColumn1.HeaderText = "idangajat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idcontrolor";
            this.dataGridViewTextBoxColumn2.HeaderText = "idcontrolor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataangajare";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataangajare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormularControloriSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 422);
            this.Controls.Add(this.controloriDataGridView);
            this.Controls.Add(idangajatLabel);
            this.Controls.Add(this.idangajatTextBox);
            this.Controls.Add(idcontrolorLabel);
            this.Controls.Add(this.idcontrolorTextBox);
            this.Controls.Add(dataangajareLabel);
            this.Controls.Add(this.dataangajareDateTimePicker);
            this.Controls.Add(this.controloriBindingNavigator);
            this.Name = "FormularControloriSimplu";
            this.Text = "FormularControloriSimplu";
            this.Load += new System.EventHandler(this.FormularControloriSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetControloriSimplu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controloriBindingNavigator)).EndInit();
            this.controloriBindingNavigator.ResumeLayout(false);
            this.controloriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controloriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetControloriSimplu dataSetControloriSimplu;
        private System.Windows.Forms.BindingSource controloriBindingSource;
        private DataSetControloriSimpluTableAdapters.controloriTableAdapter controloriTableAdapter;
        private DataSetControloriSimpluTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator controloriBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton controloriBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idangajatTextBox;
        private System.Windows.Forms.TextBox idcontrolorTextBox;
        private System.Windows.Forms.DateTimePicker dataangajareDateTimePicker;
        private System.Windows.Forms.DataGridView controloriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}