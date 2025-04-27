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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void mainadminForm_Load(object sender, EventArgs e)
        {

        }

        private void addnewadmin_Click(object sender, EventArgs e)
        {
            addingadminmicroform admin228 = new addingadminmicroform();
            admin228.ShowDialog();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDataToDataGridView()
        {


            accBase accs = new accBase();

            try
            {
                accs.openconnection2();

                string query = "SELECT * FROM `accounts`";

                MySqlCommand command = new MySqlCommand(query, accs.getConnection2());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пимилка завантаження данних: " + ex.Message);
            }
            finally
            {
                accs.closeconnection2();
            }
            dataGridView1.Refresh();



        }

        private void add_us_Click(object sender, EventArgs e)
        {
            addingNEWuser defoltuser = new addingNEWuser();
            defoltuser.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadDataToDataGridView();
            Cursor = Cursors.Default;
        }







        private void del_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть аккаунт!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
          //  string name = dataGridView1.CurrentRow.Cells["name"].Value.ToString();



            accBase accs = new accBase();
            try
            {
                accs.openconnection2();

                string query = "DELETE FROM `accounts` WHERE `ID` = @id";

                MySqlCommand command = new MySqlCommand(query, accs.getConnection2());

                command.Parameters.AddWithValue("@id", id);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Видалено!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Помилка видалення!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
                accs.closeconnection2();
            }
        }
    }
}
