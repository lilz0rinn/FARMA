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
    public partial class addingNEWuser : Form
    {
        public addingNEWuser()
        {
            InitializeComponent();
        }

        private void addingNEWuser_Load(object sender, EventArgs e)
        {

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
            string dolshnost = dolsh.Text;

            accBase accs = new accBase();
            if (passUSer == passUSeragin)
            {


                MySqlCommand command = new MySqlCommand("INSERT INTO `accounts`(`login`,`password`,`Должность`) VALUES (@aL, @aP,@DOL);", accs.getConnection2());
                command.Parameters.Add("@aL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@aP", MySqlDbType.VarChar).Value = passUSer;
                command.Parameters.Add("@DOL", MySqlDbType.VarChar).Value = dolshnost;

                accs.openconnection2();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(" додано !");
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

        private void dolsh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
