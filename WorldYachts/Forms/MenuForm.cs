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
    public partial class MenuForm : BaseForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void boatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.boatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldYachtsDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.worldYachtsDataSet.Boat);

        }

        private void BoatGo_Click(object sender, EventArgs e)
        {
            BoatForm bf = new BoatForm();
            ShowNextForm(bf, false);
        }

        private void AccessoriesGo_Click(object sender, EventArgs e)
        {
            AccessoryForm ac = new AccessoryForm();
            ShowNextForm(ac, false);
        }

        private void ContractGo_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            ShowNextForm(of, false);
        }
    }
}
