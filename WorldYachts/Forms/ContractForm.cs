using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldYachts.Forms
{
    public partial class ContractForm : BaseForm
    {
        public ContractForm()
        {
            InitializeComponent();
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldYachtsDataSet);

        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.worldYachtsDataSet.Contract);

        }
    }
}
