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
    public partial class AccessoryForm : BaseForm
    {
        public bool orderDirection = false;
        public int orderID = -1;
        public int boatID = -1;
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
            if (orderDirection)
            {
                using(SqlConnection conn = BaseDAO.GetConnection())
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from dbo.GetAccessoriesToBoat(@boatID)", conn);
                    command.Parameters.AddWithValue("@boatID", boatID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    accessoryDataGridView.DataSource = ds.Tables[0];
                    accessoryBindingNavigator.Visible = false;
                }
            }
            else
              // TODO: данная строка кода позволяет загрузить данные в таблицу "worldYachtsDataSet.Accessory". При необходимости она может быть перемещена или удалена.
                this.accessoryTableAdapter.Fill(this.worldYachtsDataSet.Accessory);
            
        }

        private void ChangePricesGo_Click(object sender, EventArgs e)
        {
            BaseDAO.StoredProcedureCall(13);
            this.accessoryTableAdapter.Fill(this.worldYachtsDataSet.Accessory);
        }

        private void ChooseGo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(accessoryDataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void nextfrmGO_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = BaseDAO.GetConnection())
            {
                conn.Open();
                string query = @"insert OrderDetails(AccessoryID, OrderID) values(@accessoryID,@OrderID)";
                SqlCommand command = new SqlCommand(query, conn);
                foreach (string id in listBox1.Items)
                {
                    command.Parameters.Add(new SqlParameter("@accessoryID", id));
                    command.Parameters.Add(new SqlParameter("@OrderID", orderID));
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }

            }
            applianceForm ap = new applianceForm();
            ap.orderID = orderID;
            ShowNextForm(ap, false);
        }
    }
}
