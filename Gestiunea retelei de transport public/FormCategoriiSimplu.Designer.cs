﻿namespace Gestiunea_retelei_de_transport_public
{
    partial class FormCategoriiSimplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriiSimplu));
            this.dataSetFormCategoriiSimplu = new Gestiunea_retelei_de_transport_public.DataSetFormCategoriiSimplu();
            this.categoriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriiTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormCategoriiSimpluTableAdapters.categoriiTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetFormCategoriiSimpluTableAdapters.TableAdapterManager();
            this.categoriiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.categoriiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoriiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormCategoriiSimplu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingNavigator)).BeginInit();
            this.categoriiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetFormCategoriiSimplu
            // 
            this.dataSetFormCategoriiSimplu.DataSetName = "DataSetFormCategoriiSimplu";
            this.dataSetFormCategoriiSimplu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriiBindingSource
            // 
            this.categoriiBindingSource.DataMember = "categorii";
            this.categoriiBindingSource.DataSource = this.dataSetFormCategoriiSimplu;
            // 
            // categoriiTableAdapter
            // 
            this.categoriiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriiTableAdapter = this.categoriiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetFormCategoriiSimpluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriiBindingNavigator
            // 
            this.categoriiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriiBindingNavigator.BindingSource = this.categoriiBindingSource;
            this.categoriiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoriiBindingNavigatorSaveItem});
            this.categoriiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriiBindingNavigator.Name = "categoriiBindingNavigator";
            this.categoriiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriiBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.categoriiBindingNavigator.TabIndex = 0;
            this.categoriiBindingNavigator.Text = "bindingNavigator1";
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
            // categoriiBindingNavigatorSaveItem
            // 
            this.categoriiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriiBindingNavigatorSaveItem.Image")));
            this.categoriiBindingNavigatorSaveItem.Name = "categoriiBindingNavigatorSaveItem";
            this.categoriiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.categoriiBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriiBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriiBindingNavigatorSaveItem_Click);
            // 
            // categoriiDataGridView
            // 
            this.categoriiDataGridView.AutoGenerateColumns = false;
            this.categoriiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriiDataGridView.DataSource = this.categoriiBindingSource;
            this.categoriiDataGridView.Location = new System.Drawing.Point(0, 38);
            this.categoriiDataGridView.Name = "categoriiDataGridView";
            this.categoriiDataGridView.Size = new System.Drawing.Size(300, 220);
            this.categoriiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "categorie";
            this.dataGridViewTextBoxColumn1.HeaderText = "categorie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "restrictii";
            this.dataGridViewTextBoxColumn2.HeaderText = "restrictii";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FormCategoriiSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 317);
            this.Controls.Add(this.categoriiDataGridView);
            this.Controls.Add(this.categoriiBindingNavigator);
            this.Name = "FormCategoriiSimplu";
            this.Text = "FormCategoriiSimplu";
            this.Load += new System.EventHandler(this.FormCategoriiSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormCategoriiSimplu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiBindingNavigator)).EndInit();
            this.categoriiBindingNavigator.ResumeLayout(false);
            this.categoriiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetFormCategoriiSimplu dataSetFormCategoriiSimplu;
        private System.Windows.Forms.BindingSource categoriiBindingSource;
        private DataSetFormCategoriiSimpluTableAdapters.categoriiTableAdapter categoriiTableAdapter;
        private DataSetFormCategoriiSimpluTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoriiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoriiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}