using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldYachts.DAO;

namespace WorldYachts.Forms
{
    public partial class OrderForm : BaseForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldYachtsDataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.worldYachtsDataSet.Boat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.worldYachtsDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.SalesPreson". При необходимости она может быть перемещена или удалена.
            this.salesPresonTableAdapter.Fill(this.worldYachtsDataSet.SalesPreson);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.worldYachtsDataSet.Order);

        }

        private void BoatChooseGo_Click(object sender, EventArgs e)
        {
            BoatForm bf = new BoatForm();
            bf.visible = true;
            ShowNextForm(bf, false);
            if(BoatForm.id != -1)
            {
                BoatIDTextBox.Text = BoatForm.id.ToString();
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = BaseDAO.GetConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("dbo.SetOrder", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.AddWithValue("@date",dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@salesPersonID",Int32.Parse(salesPersonIDComboBox.Text));
                    command.Parameters.AddWithValue("@customerID", Int32.Parse(customerIDComboBox.Text));
                    command.Parameters.AddWithValue("@boatID", Int32.Parse(BoatIDTextBox.Text));
                    command.Parameters.AddWithValue("@deliveryAdress",adressTextBox.Text);
                    command.Parameters.AddWithValue("@city",cityTextBox.Text);
                    command.ExecuteNonQuery();
                }



            }
            this.orderTableAdapter.Fill(this.worldYachtsDataSet.Order);
        }
    }
}
