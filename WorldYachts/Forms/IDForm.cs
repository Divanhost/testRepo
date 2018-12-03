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
        public int count = 3;
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
                MenuForm form = new MenuForm();
                ShowNextForm(form);
            }
            else
            {
                if(count <= 0)
                {
                    System.Threading.Thread.Sleep(1500);
                }
                string message= @"Heверно введен логин или пароль, попробуйте еще раз 
                                Осталось попыток - "+this.count--;
                MessageBox.Show(message);
                
            }

        }
    }
}

