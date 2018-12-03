namespace WorldYachts.Forms
{
    partial class AccessoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoryForm));
            this.worldYachtsDataSet = new WorldYachts.WorldYachtsDataSet();
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessoryTableAdapter = new WorldYachts.WorldYachtsDataSetTableAdapters.AccessoryTableAdapter();
            this.tableAdapterManager = new WorldYachts.WorldYachtsDataSetTableAdapters.TableAdapterManager();
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
            this.accessoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accessoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.accessoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePricesGo = new System.Windows.Forms.Button();
            this.ChooseGo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nextfrmGO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingNavigator)).BeginInit();
            this.accessoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // worldYachtsDataSet
            // 
            this.worldYachtsDataSet.DataSetName = "WorldYachtsDataSet";
            this.worldYachtsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoryBindingSource
            // 
            this.accessoryBindingSource.DataSource = this.accessoryBindingSource1;
            // 
            // accessoryBindingSource1
            // 
            this.accessoryBindingSource1.DataMember = "Accessory";
            this.accessoryBindingSource1.DataSource = this.worldYachtsDataSet;
            // 
            // accessoryTableAdapter
            // 
            this.accessoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesToBoatTableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = this.accessoryTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.IndentificationTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.SalesPresonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldYachts.WorldYachtsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // accessoryBindingNavigatorSaveItem
            // 
            this.accessoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accessoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accessoryBindingNavigatorSaveItem.Image")));
            this.accessoryBindingNavigatorSaveItem.Name = "accessoryBindingNavigatorSaveItem";
            this.accessoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.accessoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.accessoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.accessoryBindingNavigatorSaveItem_Click);
            // 
            // accessoryBindingNavigator
            // 
            this.accessoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accessoryBindingNavigator.BindingSource = this.accessoryBindingSource;
            this.accessoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accessoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accessoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accessoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accessoryBindingNavigatorSaveItem});
            this.accessoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accessoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accessoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accessoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accessoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accessoryBindingNavigator.Name = "accessoryBindingNavigator";
            this.accessoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accessoryBindingNavigator.Size = new System.Drawing.Size(1004, 27);
            this.accessoryBindingNavigator.TabIndex = 0;
            this.accessoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // accessoryDataGridView
            // 
            this.accessoryDataGridView.AutoGenerateColumns = false;
            this.accessoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.accessoryDataGridView.DataSource = this.accessoryBindingSource;
            this.accessoryDataGridView.Location = new System.Drawing.Point(12, 32);
            this.accessoryDataGridView.Name = "accessoryDataGridView";
            this.accessoryDataGridView.RowTemplate.Height = 24;
            this.accessoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accessoryDataGridView.Size = new System.Drawing.Size(958, 313);
            this.accessoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccessoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccessoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccName";
            this.dataGridViewTextBoxColumn2.HeaderText = "AccName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescriptionOfAccessory";
            this.dataGridViewTextBoxColumn3.HeaderText = "DescriptionOfAccessory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn5.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Inventory";
            this.dataGridViewTextBoxColumn6.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "OrderLevel";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderBatch";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderBatch";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PartnerID";
            this.dataGridViewTextBoxColumn9.HeaderText = "PartnerID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ChangePricesGo
            // 
            this.ChangePricesGo.Location = new System.Drawing.Point(22, 366);
            this.ChangePricesGo.Name = "ChangePricesGo";
            this.ChangePricesGo.Size = new System.Drawing.Size(143, 40);
            this.ChangePricesGo.TabIndex = 2;
            this.ChangePricesGo.Text = "Увеличить цену";
            this.ChangePricesGo.UseVisualStyleBackColor = true;
            this.ChangePricesGo.Click += new System.EventHandler(this.ChangePricesGo_Click);
            // 
            // ChooseGo
            // 
            this.ChooseGo.Location = new System.Drawing.Point(860, 375);
            this.ChooseGo.Name = "ChooseGo";
            this.ChooseGo.Size = new System.Drawing.Size(110, 49);
            this.ChooseGo.TabIndex = 3;
            this.ChooseGo.Text = "выбрать";
            this.ChooseGo.UseVisualStyleBackColor = true;
            this.ChooseGo.Click += new System.EventHandler(this.ChooseGo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(722, 375);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 132);
            this.listBox1.TabIndex = 4;
            // 
            // nextfrmGO
            // 
            this.nextfrmGO.Location = new System.Drawing.Point(860, 464);
            this.nextfrmGO.Name = "nextfrmGO";
            this.nextfrmGO.Size = new System.Drawing.Size(111, 43);
            this.nextfrmGO.TabIndex = 5;
            this.nextfrmGO.Text = "Продолжить";
            this.nextfrmGO.UseVisualStyleBackColor = true;
            this.nextfrmGO.Click += new System.EventHandler(this.nextfrmGO_Click);
            // 
            // AccessoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 563);
            this.Controls.Add(this.nextfrmGO);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ChooseGo);
            this.Controls.Add(this.ChangePricesGo);
            this.Controls.Add(this.accessoryDataGridView);
            this.Controls.Add(this.accessoryBindingNavigator);
            this.Name = "AccessoryForm";
            this.Text = "AccessoryForm";
            this.Load += new System.EventHandler(this.AccessoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingNavigator)).EndInit();
            this.accessoryBindingNavigator.ResumeLayout(false);
            this.accessoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldYachtsDataSet worldYachtsDataSet;
        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private WorldYachtsDataSetTableAdapters.AccessoryTableAdapter accessoryTableAdapter;
        private WorldYachtsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton accessoryBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator accessoryBindingNavigator;
        private System.Windows.Forms.DataGridView accessoryDataGridView;
        private System.Windows.Forms.BindingSource accessoryBindingSource1;
        private System.Windows.Forms.Button ChangePricesGo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button ChooseGo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nextfrmGO;
    }
}