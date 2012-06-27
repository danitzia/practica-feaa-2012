namespace Gestiunea_retelei_de_transport_public
{
    partial class FormOrarTrasee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrarTrasee));
            System.Windows.Forms.Label idtraseuLabel;
            System.Windows.Forms.Label distantaLabel;
            System.Windows.Forms.Label duratamedtraseuLabel;
            this.dataSetFormOrarTrasee = new Gestiunea_retelei_de_transport_public.DataSetFormOrarTrasee();
            this.traseeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traseeTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormOrarTraseeTableAdapters.traseeTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetFormOrarTraseeTableAdapters.TableAdapterManager();
            this.traseeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.traseeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idtraseuTextBox = new System.Windows.Forms.TextBox();
            this.distantaTextBox = new System.Windows.Forms.TextBox();
            this.duratamedtraseuTextBox = new System.Windows.Forms.TextBox();
            this.oraretraseuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oraretraseuTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetFormOrarTraseeTableAdapters.oraretraseuTableAdapter();
            this.oraretraseuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            idtraseuLabel = new System.Windows.Forms.Label();
            distantaLabel = new System.Windows.Forms.Label();
            duratamedtraseuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormOrarTrasee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingNavigator)).BeginInit();
            this.traseeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oraretraseuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraretraseuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetFormOrarTrasee
            // 
            this.dataSetFormOrarTrasee.DataSetName = "DataSetFormOrarTrasee";
            this.dataSetFormOrarTrasee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traseeBindingSource
            // 
            this.traseeBindingSource.DataMember = "trasee";
            this.traseeBindingSource.DataSource = this.dataSetFormOrarTrasee;
            // 
            // traseeTableAdapter
            // 
            this.traseeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.oraretraseuTableAdapter = this.oraretraseuTableAdapter;
            this.tableAdapterManager.traseeTableAdapter = this.traseeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetFormOrarTraseeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // traseeBindingNavigator
            // 
            this.traseeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.traseeBindingNavigator.BindingSource = this.traseeBindingSource;
            this.traseeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.traseeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.traseeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.traseeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.traseeBindingNavigatorSaveItem});
            this.traseeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.traseeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.traseeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.traseeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.traseeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.traseeBindingNavigator.Name = "traseeBindingNavigator";
            this.traseeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.traseeBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.traseeBindingNavigator.TabIndex = 0;
            this.traseeBindingNavigator.Text = "bindingNavigator1";
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
            // traseeBindingNavigatorSaveItem
            // 
            this.traseeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.traseeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("traseeBindingNavigatorSaveItem.Image")));
            this.traseeBindingNavigatorSaveItem.Name = "traseeBindingNavigatorSaveItem";
            this.traseeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.traseeBindingNavigatorSaveItem.Text = "Save Data";
            this.traseeBindingNavigatorSaveItem.Click += new System.EventHandler(this.traseeBindingNavigatorSaveItem_Click);
            // 
            // idtraseuLabel
            // 
            idtraseuLabel.AutoSize = true;
            idtraseuLabel.Location = new System.Drawing.Point(52, 34);
            idtraseuLabel.Name = "idtraseuLabel";
            idtraseuLabel.Size = new System.Drawing.Size(47, 13);
            idtraseuLabel.TabIndex = 1;
            idtraseuLabel.Text = "idtraseu:";
            // 
            // idtraseuTextBox
            // 
            this.idtraseuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "idtraseu", true));
            this.idtraseuTextBox.Location = new System.Drawing.Point(147, 31);
            this.idtraseuTextBox.Name = "idtraseuTextBox";
            this.idtraseuTextBox.Size = new System.Drawing.Size(100, 20);
            this.idtraseuTextBox.TabIndex = 2;
            // 
            // distantaLabel
            // 
            distantaLabel.AutoSize = true;
            distantaLabel.Location = new System.Drawing.Point(52, 60);
            distantaLabel.Name = "distantaLabel";
            distantaLabel.Size = new System.Drawing.Size(47, 13);
            distantaLabel.TabIndex = 3;
            distantaLabel.Text = "distanta:";
            // 
            // distantaTextBox
            // 
            this.distantaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "distanta", true));
            this.distantaTextBox.Location = new System.Drawing.Point(147, 57);
            this.distantaTextBox.Name = "distantaTextBox";
            this.distantaTextBox.Size = new System.Drawing.Size(100, 20);
            this.distantaTextBox.TabIndex = 4;
            // 
            // duratamedtraseuLabel
            // 
            duratamedtraseuLabel.AutoSize = true;
            duratamedtraseuLabel.Location = new System.Drawing.Point(52, 86);
            duratamedtraseuLabel.Name = "duratamedtraseuLabel";
            duratamedtraseuLabel.Size = new System.Drawing.Size(89, 13);
            duratamedtraseuLabel.TabIndex = 5;
            duratamedtraseuLabel.Text = "duratamedtraseu:";
            // 
            // duratamedtraseuTextBox
            // 
            this.duratamedtraseuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "duratamedtraseu", true));
            this.duratamedtraseuTextBox.Location = new System.Drawing.Point(147, 83);
            this.duratamedtraseuTextBox.Name = "duratamedtraseuTextBox";
            this.duratamedtraseuTextBox.Size = new System.Drawing.Size(100, 20);
            this.duratamedtraseuTextBox.TabIndex = 6;
            // 
            // oraretraseuBindingSource
            // 
            this.oraretraseuBindingSource.DataMember = "trasee_oraretraseu";
            this.oraretraseuBindingSource.DataSource = this.traseeBindingSource;
            // 
            // oraretraseuTableAdapter
            // 
            this.oraretraseuTableAdapter.ClearBeforeFill = true;
            // 
            // oraretraseuDataGridView
            // 
            this.oraretraseuDataGridView.AutoGenerateColumns = false;
            this.oraretraseuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oraretraseuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.oraretraseuDataGridView.DataSource = this.oraretraseuBindingSource;
            this.oraretraseuDataGridView.Location = new System.Drawing.Point(23, 119);
            this.oraretraseuDataGridView.Name = "oraretraseuDataGridView";
            this.oraretraseuDataGridView.Size = new System.Drawing.Size(444, 220);
            this.oraretraseuDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idorartraseu";
            this.dataGridViewTextBoxColumn1.HeaderText = "idorartraseu";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idstatieplecare";
            this.dataGridViewTextBoxColumn3.HeaderText = "idstatieplecare";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "oraplecare";
            this.dataGridViewTextBoxColumn4.HeaderText = "oraplecare";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.oraretraseuBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(378, 342);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigator1.TabIndex = 8;
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
            this.label1.Location = new System.Drawing.Point(257, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add/Del Orar->";
            // 
            // FormOrarTrasee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.oraretraseuDataGridView);
            this.Controls.Add(idtraseuLabel);
            this.Controls.Add(this.idtraseuTextBox);
            this.Controls.Add(distantaLabel);
            this.Controls.Add(this.distantaTextBox);
            this.Controls.Add(duratamedtraseuLabel);
            this.Controls.Add(this.duratamedtraseuTextBox);
            this.Controls.Add(this.traseeBindingNavigator);
            this.Name = "FormOrarTrasee";
            this.Text = "FormOrarTrasee";
            this.Load += new System.EventHandler(this.FormOrarTrasee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFormOrarTrasee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingNavigator)).EndInit();
            this.traseeBindingNavigator.ResumeLayout(false);
            this.traseeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oraretraseuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oraretraseuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetFormOrarTrasee dataSetFormOrarTrasee;
        private System.Windows.Forms.BindingSource traseeBindingSource;
        private DataSetFormOrarTraseeTableAdapters.traseeTableAdapter traseeTableAdapter;
        private DataSetFormOrarTraseeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator traseeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton traseeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idtraseuTextBox;
        private System.Windows.Forms.TextBox distantaTextBox;
        private System.Windows.Forms.TextBox duratamedtraseuTextBox;
        private DataSetFormOrarTraseeTableAdapters.oraretraseuTableAdapter oraretraseuTableAdapter;
        private System.Windows.Forms.BindingSource oraretraseuBindingSource;
        private System.Windows.Forms.DataGridView oraretraseuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.Label label1;
    }
}