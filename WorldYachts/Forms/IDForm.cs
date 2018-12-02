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
using WorldYachts.Forms;

namespace WorldYachts
{
    public partial class IDForm : BaseForm
    {
        public IDForm()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string l = login.Text;
            string p = password.Text;

            if (BaseDAO.FunctionCall(l, p))
            {
                MessageBox.Show("Hello");
            }
            /*if (user != null)
            {
                DataBus.GetInstance().currentUser = user;
                MainMenuForm form = new MainMenuForm();
                ShowNextForm(form);
            }
            else
            {
                labelMessage.Text = "Access Denied";
            }*/
        }
    }
}
