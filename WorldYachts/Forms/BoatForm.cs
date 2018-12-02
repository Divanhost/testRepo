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
    public partial class BoatForm : BaseForm
    {
        public BoatForm()
        {
            InitializeComponent();
        }

        private void boatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.boatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldYachtsDataSet);

        }

        private void BoatForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.worldYachtsDataSet.Boat);

        }

       
    }
}
