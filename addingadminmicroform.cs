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
    public partial class addingadminmicroform : Form
    {
        public addingadminmicroform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox1.Text;

            string passUSer = passwordBox2.Text;
            string passUSeragin = passagain.Text;
            if (passUSer == passUSeragin)
            {
                adminBase adminBase = new adminBase();

                MySqlCommand command = new MySqlCommand("INSERT INTO `adminlogins`(`login`,`password`) VALUES (@aL, @aP);", adminBase.getConnectionadmin());
                command.Parameters.Add("@aL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@aP", MySqlDbType.VarChar).Value = passUSer;

                adminBase.openconnectionadmin();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Нового адміністратора додано !");
                    Close();


                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Паролі на співпадають, спробуйте ще раз !");
            }
        }

        private void passagain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
