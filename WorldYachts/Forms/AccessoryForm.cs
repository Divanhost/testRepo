using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldYachts.DAO;

namespace WorldYachts.Forms
{
    public partial class AccessoryForm : BaseForm
    {
        public AccessoryForm()
        {
            InitializeComponent();
        }

        private void accessoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldYachtsDataSet);

        }

        private void AccessoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.worldYachtsDataSet.Accessory);

        }

        private void ChangePricesGo_Click(object sender, EventArgs e)
        {
            BaseDAO.StoredProcedureCall(13);
            this.accessoryTableAdapter.Fill(this.worldYachtsDataSet.Accessory);
        }
    }
}
