using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farma
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void loginBox1_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void passwordBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox1.Text;
            string passUSer = passwordBox2.Text;

            adminBase adminBase = new adminBase();
            adminBase.openconnectionadmin();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `adminlogins` WHERE `login` = @uL AND `password` = @uP", adminBase.getConnectionadmin());


            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUSer;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                admin mainadminForrm = new admin(); 
                mainadminForrm.Show();
                this.Hide();
                adminBase.closeconnectionadmin();
            }
            else
            {
                MessageBox.Show("Невірний пароль або логін !");
            }


        }
    }
}
