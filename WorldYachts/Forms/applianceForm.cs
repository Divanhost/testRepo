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
    public partial class applianceForm : BaseForm
    {
        public int orderID = -1;
        public applianceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = BaseDAO.GetConnection())
            {
                {
                    using (SqlCommand command = new SqlCommand("CreateContract", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@orderID", orderID);
                        command.Parameters.AddWithValue("@depositPayed", Double.Parse(textBox1.Text));
                        command.ExecuteNonQuery();
                    }
                }
            }
            ContractForm cf = new ContractForm();
            ShowNextForm(cf, true);
        }
    }
}
