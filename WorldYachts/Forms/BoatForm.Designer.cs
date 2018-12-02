namespace WorldYachts.Forms
{
    partial class BoatForm
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
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label boatTypeLabel;
            System.Windows.Forms.Label numberOfRowersLabel;
            System.Windows.Forms.Label mastLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label woodLabel;
            System.Windows.Forms.Label basePriceLabel;
            System.Windows.Forms.Label vATLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoatForm));
            this.worldYachtsDataSet = new WorldYachts.WorldYachtsDataSet();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatTableAdapter = new WorldYachts.WorldYachtsDataSetTableAdapters.BoatTableAdapter();
            this.tableAdapterManager = new WorldYachts.WorldYachtsDataSetTableAdapters.TableAdapterManager();
            this.boatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.boatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.boatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.boatTypeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRowersTextBox = new System.Windows.Forms.TextBox();
            this.mastCheckBox = new System.Windows.Forms.CheckBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.woodTextBox = new System.Windows.Forms.TextBox();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.vATTextBox = new System.Windows.Forms.TextBox();
            this.Sortbox = new System.Windows.Forms.ComboBox();
            this.boatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SortGo = new System.Windows.Forms.Button();
            this.SortDescGo = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filterbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChooseGo = new System.Windows.Forms.Button();
            modelLabel = new System.Windows.Forms.Label();
            boatTypeLabel = new System.Windows.Forms.Label();
            numberOfRowersLabel = new System.Windows.Forms.Label();
            mastLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            woodLabel = new System.Windows.Forms.Label();
            basePriceLabel = new System.Windows.Forms.Label();
            vATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingNavigator)).BeginInit();
            this.boatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(12, 300);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(50, 17);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Model:";
            // 
            // boatTypeLabel
            // 
            boatTypeLabel.AutoSize = true;
            boatTypeLabel.Location = new System.Drawing.Point(12, 328);
            boatTypeLabel.Name = "boatTypeLabel";
            boatTypeLabel.Size = new System.Drawing.Size(77, 17);
            boatTypeLabel.TabIndex = 6;
            boatTypeLabel.Text = "Boat Type:";
            // 
            // numberOfRowersLabel
            // 
            numberOfRowersLabel.AutoSize = true;
            numberOfRowersLabel.Location = new System.Drawing.Point(12, 356);
            numberOfRowersLabel.Name = "numberOfRowersLabel";
            numberOfRowersLabel.Size = new System.Drawing.Size(132, 17);
            numberOfRowersLabel.TabIndex = 8;
            numberOfRowersLabel.Text = "Number Of Rowers:";
            // 
            // mastLabel
            // 
            mastLabel.AutoSize = true;
            mastLabel.Location = new System.Drawing.Point(12, 386);
            mastLabel.Name = "mastLabel";
            mastLabel.Size = new System.Drawing.Size(42, 17);
            mastLabel.TabIndex = 10;
            mastLabel.Text = "Mast:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(12, 414);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(53, 17);
            colourLabel.TabIndex = 12;
            colourLabel.Text = "Colour:";
            // 
            // woodLabel
            // 
            woodLabel.AutoSize = true;
            woodLabel.Location = new System.Drawing.Point(12, 442);
            woodLabel.Name = "woodLabel";
            woodLabel.Size = new System.Drawing.Size(49, 17);
            woodLabel.TabIndex = 14;
            woodLabel.Text = "Wood:";
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new System.Drawing.Point(12, 470);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new System.Drawing.Size(80, 17);
            basePriceLabel.TabIndex = 16;
            basePriceLabel.Text = "Base Price:";
            // 
            // vATLabel
            // 
            vATLabel.AutoSize = true;
            vATLabel.Location = new System.Drawing.Point(12, 498);
            vATLabel.Name = "vATLabel";
            vATLabel.Size = new System.Drawing.Size(39, 17);
            vATLabel.TabIndex = 18;
            vATLabel.Text = "VAT:";
            // 
            // worldYachtsDataSet
            // 
            this.worldYachtsDataSet.DataSetName = "WorldYachtsDataSet";
            this.worldYachtsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataMember = "Boat";
            this.boatBindingSource.DataSource = this.worldYachtsDataSet;
            // 
            // boatTableAdapter
            // 
            this.boatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesToBoatTableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = this.boatTableAdapter;
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
            // boatBindingNavigator
            // 
            this.boatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.boatBindingNavigator.BindingSource = this.boatBindingSource;
            this.boatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.boatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.boatBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.boatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.boatBindingNavigatorSaveItem});
            this.boatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.boatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.boatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.boatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.boatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.boatBindingNavigator.Name = "boatBindingNavigator";
            this.boatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.boatBindingNavigator.Size = new System.Drawing.Size(1023, 27);
            this.boatBindingNavigator.TabIndex = 0;
            this.boatBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // boatBindingNavigatorSaveItem
            // 
            this.boatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("boatBindingNavigatorSaveItem.Image")));
            this.boatBindingNavigatorSaveItem.Name = "boatBindingNavigatorSaveItem";
            this.boatBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.boatBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.boatBindingNavigatorSaveItem.Click += new System.EventHandler(this.boatBindingNavigatorSaveItem_Click);
            // 
            // boatDataGridView
            // 
            this.boatDataGridView.AutoGenerateColumns = false;
            this.boatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.boatDataGridView.DataSource = this.boatBindingSource;
            this.boatDataGridView.Location = new System.Drawing.Point(12, 32);
            this.boatDataGridView.Name = "boatDataGridView";
            this.boatDataGridView.ReadOnly = true;
            this.boatDataGridView.RowTemplate.Height = 24;
            this.boatDataGridView.Size = new System.Drawing.Size(959, 228);
            this.boatDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BoatID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BoatID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BoatType";
            this.dataGridViewTextBoxColumn3.HeaderText = "BoatType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Mast";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Mast";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Wood";
            this.dataGridViewTextBoxColumn6.HeaderText = "Wood";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BasePrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "BasePrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn8.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(150, 297);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(104, 22);
            this.modelTextBox.TabIndex = 5;
            // 
            // boatTypeTextBox
            // 
            this.boatTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BoatType", true));
            this.boatTypeTextBox.Location = new System.Drawing.Point(150, 325);
            this.boatTypeTextBox.Name = "boatTypeTextBox";
            this.boatTypeTextBox.Size = new System.Drawing.Size(104, 22);
            this.boatTypeTextBox.TabIndex = 7;
            // 
            // numberOfRowersTextBox
            // 
            this.numberOfRowersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "NumberOfRowers", true));
            this.numberOfRowersTextBox.Location = new System.Drawing.Point(150, 353);
            this.numberOfRowersTextBox.Name = "numberOfRowersTextBox";
            this.numberOfRowersTextBox.Size = new System.Drawing.Size(104, 22);
            this.numberOfRowersTextBox.TabIndex = 9;
            // 
            // mastCheckBox
            // 
            this.mastCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.boatBindingSource, "Mast", true));
            this.mastCheckBox.Location = new System.Drawing.Point(150, 381);
            this.mastCheckBox.Name = "mastCheckBox";
            this.mastCheckBox.Size = new System.Drawing.Size(104, 24);
            this.mastCheckBox.TabIndex = 11;
            this.mastCheckBox.Text = "Мачта";
            this.mastCheckBox.UseVisualStyleBackColor = true;
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Colour", true));
            this.colourTextBox.Location = new System.Drawing.Point(150, 411);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(104, 22);
            this.colourTextBox.TabIndex = 13;
            // 
            // woodTextBox
            // 
            this.woodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Wood", true));
            this.woodTextBox.Location = new System.Drawing.Point(150, 439);
            this.woodTextBox.Name = "woodTextBox";
            this.woodTextBox.Size = new System.Drawing.Size(104, 22);
            this.woodTextBox.TabIndex = 15;
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BasePrice", true));
            this.basePriceTextBox.Location = new System.Drawing.Point(150, 467);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(104, 22);
            this.basePriceTextBox.TabIndex = 17;
            // 
            // vATTextBox
            // 
            this.vATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "VAT", true));
            this.vATTextBox.Location = new System.Drawing.Point(150, 495);
            this.vATTextBox.Name = "vATTextBox";
            this.vATTextBox.Size = new System.Drawing.Size(104, 22);
            this.vATTextBox.TabIndex = 19;
            // 
            // Sortbox
            // 
            this.Sortbox.FormattingEnabled = true;
            this.Sortbox.Location = new System.Drawing.Point(691, 293);
            this.Sortbox.Name = "Sortbox";
            this.Sortbox.Size = new System.Drawing.Size(280, 24);
            this.Sortbox.TabIndex = 20;
            // 
            // boatBindingSource1
            // 
            this.boatBindingSource1.DataMember = "Boat";
            this.boatBindingSource1.DataSource = this.worldYachtsDataSet;
            // 
            // SortGo
            // 
            this.SortGo.Location = new System.Drawing.Point(691, 323);
            this.SortGo.Name = "SortGo";
            this.SortGo.Size = new System.Drawing.Size(137, 38);
            this.SortGo.TabIndex = 21;
            this.SortGo.Text = "По возрастанию";
            this.SortGo.UseVisualStyleBackColor = true;
            this.SortGo.Click += new System.EventHandler(this.SortGo_Click);
            // 
            // SortDescGo
            // 
            this.SortDescGo.Location = new System.Drawing.Point(834, 323);
            this.SortDescGo.Name = "SortDescGo";
            this.SortDescGo.Size = new System.Drawing.Size(137, 38);
            this.SortDescGo.TabIndex = 22;
            this.SortDescGo.Text = "По убыванию";
            this.SortDescGo.UseVisualStyleBackColor = true;
            this.SortDescGo.Click += new System.EventHandler(this.SortDescGo_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(691, 414);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(280, 22);
            this.FilterTextBox.TabIndex = 23;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Сортировка";
            // 
            // Filterbox
            // 
            this.Filterbox.FormattingEnabled = true;
            this.Filterbox.Location = new System.Drawing.Point(820, 386);
            this.Filterbox.Name = "Filterbox";
            this.Filterbox.Size = new System.Drawing.Size(151, 24);
            this.Filterbox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Поле";
            // 
            // ChooseGo
            // 
            this.ChooseGo.Location = new System.Drawing.Point(360, 306);
            this.ChooseGo.Name = "ChooseGo";
            this.ChooseGo.Size = new System.Drawing.Size(260, 164);
            this.ChooseGo.TabIndex = 28;
            this.ChooseGo.Text = "Хочу выбранную лодку";
            this.ChooseGo.UseVisualStyleBackColor = true;
            this.ChooseGo.Visible = false;
            this.ChooseGo.Click += new System.EventHandler(this.ChooseGo_Click);
            // 
            // BoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.ChooseGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filterbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortDescGo);
            this.Controls.Add(this.SortGo);
            this.Controls.Add(this.Sortbox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(boatTypeLabel);
            this.Controls.Add(this.boatTypeTextBox);
            this.Controls.Add(numberOfRowersLabel);
            this.Controls.Add(this.numberOfRowersTextBox);
            this.Controls.Add(mastLabel);
            this.Controls.Add(this.mastCheckBox);
            this.Controls.Add(colourLabel);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(woodLabel);
            this.Controls.Add(this.woodTextBox);
            this.Controls.Add(basePriceLabel);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(vATLabel);
            this.Controls.Add(this.vATTextBox);
            this.Controls.Add(this.boatDataGridView);
            this.Controls.Add(this.boatBindingNavigator);
            this.Name = "BoatForm";
            this.Text = "BoatForm";
            this.Load += new System.EventHandler(this.BoatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingNavigator)).EndInit();
            this.boatBindingNavigator.ResumeLayout(false);
            this.boatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldYachtsDataSet worldYachtsDataSet;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private WorldYachtsDataSetTableAdapters.BoatTableAdapter boatTableAdapter;
        private WorldYachtsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator boatBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton boatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView boatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox boatTypeTextBox;
        private System.Windows.Forms.TextBox numberOfRowersTextBox;
        private System.Windows.Forms.CheckBox mastCheckBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.TextBox woodTextBox;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox vATTextBox;
        private System.Windows.Forms.ComboBox Sortbox;
        private System.Windows.Forms.BindingSource boatBindingSource1;
        private System.Windows.Forms.Button SortGo;
        private System.Windows.Forms.Button SortDescGo;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Filterbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChooseGo;
    }
}