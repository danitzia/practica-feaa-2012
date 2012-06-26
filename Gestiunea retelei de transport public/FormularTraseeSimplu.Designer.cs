namespace Gestiunea_retelei_de_transport_public
{
    partial class FormularTraseeSimplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularTraseeSimplu));
            System.Windows.Forms.Label idtraseuLabel;
            System.Windows.Forms.Label distantaLabel;
            System.Windows.Forms.Label duratamedtraseuLabel;
            this.dataSetTraseeSimplu = new Gestiunea_retelei_de_transport_public.DataSetTraseeSimplu();
            this.traseeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traseeTableAdapter = new Gestiunea_retelei_de_transport_public.DataSetTraseeSimpluTableAdapters.traseeTableAdapter();
            this.tableAdapterManager = new Gestiunea_retelei_de_transport_public.DataSetTraseeSimpluTableAdapters.TableAdapterManager();
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
            this.traseeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idtraseuLabel = new System.Windows.Forms.Label();
            distantaLabel = new System.Windows.Forms.Label();
            duratamedtraseuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraseeSimplu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingNavigator)).BeginInit();
            this.traseeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traseeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetTraseeSimplu
            // 
            this.dataSetTraseeSimplu.DataSetName = "DataSetTraseeSimplu";
            this.dataSetTraseeSimplu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traseeBindingSource
            // 
            this.traseeBindingSource.DataMember = "trasee";
            this.traseeBindingSource.DataSource = this.dataSetTraseeSimplu;
            // 
            // traseeTableAdapter
            // 
            this.traseeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.traseeTableAdapter = this.traseeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gestiunea_retelei_de_transport_public.DataSetTraseeSimpluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // traseeBindingNavigator
            // 
            this.traseeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.traseeBindingNavigator.BindingSource = this.traseeBindingSource;
            this.traseeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.traseeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.traseeBindingNavigator.Size = new System.Drawing.Size(504, 25);
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
            idtraseuLabel.Location = new System.Drawing.Point(153, 57);
            idtraseuLabel.Name = "idtraseuLabel";
            idtraseuLabel.Size = new System.Drawing.Size(47, 13);
            idtraseuLabel.TabIndex = 1;
            idtraseuLabel.Text = "idtraseu:";
            // 
            // idtraseuTextBox
            // 
            this.idtraseuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "idtraseu", true));
            this.idtraseuTextBox.Location = new System.Drawing.Point(248, 54);
            this.idtraseuTextBox.Name = "idtraseuTextBox";
            this.idtraseuTextBox.Size = new System.Drawing.Size(100, 20);
            this.idtraseuTextBox.TabIndex = 2;
            // 
            // distantaLabel
            // 
            distantaLabel.AutoSize = true;
            distantaLabel.Location = new System.Drawing.Point(153, 83);
            distantaLabel.Name = "distantaLabel";
            distantaLabel.Size = new System.Drawing.Size(47, 13);
            distantaLabel.TabIndex = 3;
            distantaLabel.Text = "distanta:";
            // 
            // distantaTextBox
            // 
            this.distantaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "distanta", true));
            this.distantaTextBox.Location = new System.Drawing.Point(248, 80);
            this.distantaTextBox.Name = "distantaTextBox";
            this.distantaTextBox.Size = new System.Drawing.Size(100, 20);
            this.distantaTextBox.TabIndex = 4;
            // 
            // duratamedtraseuLabel
            // 
            duratamedtraseuLabel.AutoSize = true;
            duratamedtraseuLabel.Location = new System.Drawing.Point(153, 109);
            duratamedtraseuLabel.Name = "duratamedtraseuLabel";
            duratamedtraseuLabel.Size = new System.Drawing.Size(89, 13);
            duratamedtraseuLabel.TabIndex = 5;
            duratamedtraseuLabel.Text = "duratamedtraseu:";
            // 
            // duratamedtraseuTextBox
            // 
            this.duratamedtraseuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traseeBindingSource, "duratamedtraseu", true));
            this.duratamedtraseuTextBox.Location = new System.Drawing.Point(248, 106);
            this.duratamedtraseuTextBox.Name = "duratamedtraseuTextBox";
            this.duratamedtraseuTextBox.Size = new System.Drawing.Size(100, 20);
            this.duratamedtraseuTextBox.TabIndex = 6;
            // 
            // traseeDataGridView
            // 
            this.traseeDataGridView.AutoGenerateColumns = false;
            this.traseeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traseeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.traseeDataGridView.DataSource = this.traseeBindingSource;
            this.traseeDataGridView.Location = new System.Drawing.Point(81, 163);
            this.traseeDataGridView.Name = "traseeDataGridView";
            this.traseeDataGridView.Size = new System.Drawing.Size(343, 221);
            this.traseeDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idtraseu";
            this.dataGridViewTextBoxColumn1.HeaderText = "idtraseu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "distanta";
            this.dataGridViewTextBoxColumn2.HeaderText = "distanta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "duratamedtraseu";
            this.dataGridViewTextBoxColumn3.HeaderText = "duratamedtraseu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormularTraseeSimplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 420);
            this.Controls.Add(this.traseeDataGridView);
            this.Controls.Add(idtraseuLabel);
            this.Controls.Add(this.idtraseuTextBox);
            this.Controls.Add(distantaLabel);
            this.Controls.Add(this.distantaTextBox);
            this.Controls.Add(duratamedtraseuLabel);
            this.Controls.Add(this.duratamedtraseuTextBox);
            this.Controls.Add(this.traseeBindingNavigator);
            this.Name = "FormularTraseeSimplu";
            this.Text = "FormularTraseeSimplu";
            this.Load += new System.EventHandler(this.FormularTraseeSimplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTraseeSimplu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traseeBindingNavigator)).EndInit();
            this.traseeBindingNavigator.ResumeLayout(false);
            this.traseeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traseeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetTraseeSimplu dataSetTraseeSimplu;
        private System.Windows.Forms.BindingSource traseeBindingSource;
        private DataSetTraseeSimpluTableAdapters.traseeTableAdapter traseeTableAdapter;
        private DataSetTraseeSimpluTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView traseeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}