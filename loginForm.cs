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
using farma; 

namespace farma
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox1.Text;
            string passUSer = passwordBox2.Text;
            
            accBase accBase = new accBase();
            accBase.openconnection2();
            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `accounts` WHERE `Login` = @uL AND `Password` = @uP", accBase.getConnection2());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUSer;

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                eBase mainForm = new eBase(loginUser); 
                mainForm.Show();
                this.Hide();
                accBase.closeconnection2();
            }
            else
            {
                MessageBox.Show("Невірний пароль або логін !");
            }
        }
    }
}
