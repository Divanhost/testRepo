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
    public partial class BoatForm : BaseForm
    {
        private object query;
        BindingSource bs = new BindingSource();
        public BoatForm()
        {
            InitializeComponent();
            using (SqlConnection conn = BaseDAO.GetConnection()) {
                conn.Open();
                string query = @"select * from dbo.Boat";
                SqlCommand cmdReader = new SqlCommand(query, conn);
                SqlDataReader reader = cmdReader.ExecuteReader();

                for (int index = 0; index < reader.FieldCount; index++)
                {
                    Sortbox.Items.Add(reader.GetName(index));
                    if(reader.GetName(index) != "Mast")
                    Filterbox.Items.Add(reader.GetName(index));
                }
            }
            foreach(DataGridViewColumn dc in boatDataGridView.Columns)
            {
                dc.Name = dc.HeaderText;
            }
            
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

        private void SortGo_Click(object sender, EventArgs e)
        {
            string dc = boatDataGridView.Columns[0].Name;
            DataGridViewCellMouseEventArgs en = e as DataGridViewCellMouseEventArgs;
             boatDataGridView.Sort(boatDataGridView.Columns[Sortbox.Text], ListSortDirection.Ascending);
        }

        private void SortDescGo_Click(object sender, EventArgs e)
        {
            DataGridViewColumn dc = boatDataGridView.Columns[Sortbox.Text];
            DataGridViewCellMouseEventArgs en = e as DataGridViewCellMouseEventArgs;
            boatDataGridView.Sort(dc, ListSortDirection.Descending);
        }

    

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            boatBindingSource.Filter = string.Format("{0} LIKE '%{1}%'",Filterbox.Text, FilterTextBox.Text);
        }
    }
}
