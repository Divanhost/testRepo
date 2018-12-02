namespace WorldYachts.Forms
{
    partial class MenuForm
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
            this.worldYachtsDataSet = new WorldYachts.WorldYachtsDataSet();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatTableAdapter = new WorldYachts.WorldYachtsDataSetTableAdapters.BoatTableAdapter();
            this.tableAdapterManager = new WorldYachts.WorldYachtsDataSetTableAdapters.TableAdapterManager();
            this.BoatGo = new System.Windows.Forms.Button();
            this.AccessoriesGo = new System.Windows.Forms.Button();
            this.PartnersGo = new System.Windows.Forms.Button();
            this.ContractGo = new System.Windows.Forms.Button();
            this.InvoiceGo = new System.Windows.Forms.Button();
            this.CustomerGo = new System.Windows.Forms.Button();
            this.SalesPersonGo = new System.Windows.Forms.Button();
            this.OrdersGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // BoatGo
            // 
            this.BoatGo.Location = new System.Drawing.Point(12, 12);
            this.BoatGo.Name = "BoatGo";
            this.BoatGo.Size = new System.Drawing.Size(231, 73);
            this.BoatGo.TabIndex = 0;
            this.BoatGo.Text = "Списк лодок";
            this.BoatGo.UseVisualStyleBackColor = true;
            this.BoatGo.Click += new System.EventHandler(this.BoatGo_Click);
            // 
            // AccessoriesGo
            // 
            this.AccessoriesGo.Location = new System.Drawing.Point(249, 170);
            this.AccessoriesGo.Name = "AccessoriesGo";
            this.AccessoriesGo.Size = new System.Drawing.Size(231, 73);
            this.AccessoriesGo.TabIndex = 1;
            this.AccessoriesGo.Text = "Аксессуары";
            this.AccessoriesGo.UseVisualStyleBackColor = true;
            // 
            // PartnersGo
            // 
            this.PartnersGo.Location = new System.Drawing.Point(12, 91);
            this.PartnersGo.Name = "PartnersGo";
            this.PartnersGo.Size = new System.Drawing.Size(231, 73);
            this.PartnersGo.TabIndex = 2;
            this.PartnersGo.Text = "Партнеры";
            this.PartnersGo.UseVisualStyleBackColor = true;
            // 
            // ContractGo
            // 
            this.ContractGo.Location = new System.Drawing.Point(249, 91);
            this.ContractGo.Name = "ContractGo";
            this.ContractGo.Size = new System.Drawing.Size(231, 73);
            this.ContractGo.TabIndex = 3;
            this.ContractGo.Text = "Заказы";
            this.ContractGo.UseVisualStyleBackColor = true;
            // 
            // InvoiceGo
            // 
            this.InvoiceGo.Location = new System.Drawing.Point(12, 170);
            this.InvoiceGo.Name = "InvoiceGo";
            this.InvoiceGo.Size = new System.Drawing.Size(231, 73);
            this.InvoiceGo.TabIndex = 4;
            this.InvoiceGo.Text = "Счета";
            this.InvoiceGo.UseVisualStyleBackColor = true;
            // 
            // CustomerGo
            // 
            this.CustomerGo.Location = new System.Drawing.Point(249, 12);
            this.CustomerGo.Name = "CustomerGo";
            this.CustomerGo.Size = new System.Drawing.Size(231, 73);
            this.CustomerGo.TabIndex = 5;
            this.CustomerGo.Text = "Список покупателей";
            this.CustomerGo.UseVisualStyleBackColor = true;
            // 
            // SalesPersonGo
            // 
            this.SalesPersonGo.Location = new System.Drawing.Point(12, 249);
            this.SalesPersonGo.Name = "SalesPersonGo";
            this.SalesPersonGo.Size = new System.Drawing.Size(231, 73);
            this.SalesPersonGo.TabIndex = 6;
            this.SalesPersonGo.Text = "Менеджеры";
            this.SalesPersonGo.UseVisualStyleBackColor = true;
            // 
            // OrdersGo
            // 
            this.OrdersGo.Location = new System.Drawing.Point(249, 249);
            this.OrdersGo.Name = "OrdersGo";
            this.OrdersGo.Size = new System.Drawing.Size(231, 73);
            this.OrdersGo.TabIndex = 7;
            this.OrdersGo.Text = "Доставка";
            this.OrdersGo.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 343);
            this.Controls.Add(this.OrdersGo);
            this.Controls.Add(this.SalesPersonGo);
            this.Controls.Add(this.CustomerGo);
            this.Controls.Add(this.InvoiceGo);
            this.Controls.Add(this.ContractGo);
            this.Controls.Add(this.PartnersGo);
            this.Controls.Add(this.AccessoriesGo);
            this.Controls.Add(this.BoatGo);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldYachtsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WorldYachtsDataSet worldYachtsDataSet;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private WorldYachtsDataSetTableAdapters.BoatTableAdapter boatTableAdapter;
        private WorldYachtsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BoatGo;
        private System.Windows.Forms.Button AccessoriesGo;
        private System.Windows.Forms.Button PartnersGo;
        private System.Windows.Forms.Button ContractGo;
        private System.Windows.Forms.Button InvoiceGo;
        private System.Windows.Forms.Button CustomerGo;
        private System.Windows.Forms.Button SalesPersonGo;
        private System.Windows.Forms.Button OrdersGo;
    }
}