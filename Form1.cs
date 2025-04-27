using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using System.Drawing;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;


namespace farma
{
    public partial class eBase : Form
    {


        public eBase()
        {
            InitializeComponent();

        }
        /// <summary>
        /// ////////////////
        /// </summary>
        /// 




        public void LoadDataToDataGridView()
        {

            Dbase db = new Dbase();

            try
            {
                db.openconnection();

                string query = "SELECT * FROM `tablentki`";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
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
                db.closeconnection();
            }
            dataGridView1.Refresh();
        }
        /// <summary>
        /// //
        /// </summary>
        /// <param 
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            userLabel.Text = $"Співробітникк: {currentUser}";
            GenerateBarcode(currentUser);
        }

        private void mainstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (addFORM addForm = new addFORM())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    string newMedicationName = addForm.MedicationName;
                    MessageBox.Show($" препарат додано : {newMedicationName}");
                }

            }

        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть препарат для редагування!", "Попередження",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Назва"].Value.ToString();
            string producer = dataGridView1.CurrentRow.Cells["Виробник"].Value.ToString();
            string type = dataGridView1.CurrentRow.Cells["Тип препарату"].Value.ToString();
            int quantity = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Кількість"].Value);
            DateTime expiryDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Придатний до"].Value);
            bool requiresPrescription = dataGridView1.CurrentRow.Cells["Рецепт"].Value.ToString() == "Так";


            using (EditForm editForm = new EditForm(id, name, producer, type, quantity, expiryDate, requiresPrescription))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataToDataGridView();
                }
            }

        }
        private void moreBUT_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть препарат!");
                return;
            }

            // Получаем все необходимые данные
            string name = dataGridView1.CurrentRow.Cells["Назва"].Value?.ToString();



            using (SHform detailForm = new SHform(name))
            {
                detailForm.ShowDialog();
            }

        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть препарат!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Назва"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Ви впевнені, що хочете видалити препарат '{name}'?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            Dbase db = new Dbase();
            try
            {
                db.openconnection();
                string query = "DELETE FROM `tablentki` WHERE `id` = @id";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
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
                db.closeconnection();
            }
        }
        private void tabletkiL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTabl_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTabl.Text.Trim();


            if (string.IsNullOrEmpty(searchText))
            {
                LoadDataToDataGridView();
                return;
            }

            Dbase db = new Dbase();
            try
            {
                db.openconnection();

                string query = @"SELECT * FROM `tablentki` 
                WHERE `Назва` LIKE @searchText 
                OR `Виробник` LIKE @searchText
                OR `Тип препарату` LIKE @searchText";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.AddWithValue("@searchText", $"%{searchText}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
            finally
            {
                db.closeconnection();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadDataToDataGridView();
            Cursor = Cursors.Default;
        }

        private void дляАдміністратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            adminForm.ShowDialog();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private string currentUser;
        public eBase(string userLogin)
        {
            InitializeComponent();
            currentUser = userLogin;

        }


        private void GenerateBarcode(string data)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 10
                }
            };

            Bitmap barcodeBitmap = writer.Write(data);
            pictureBox1.Image = barcodeBitmap;
        }
        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = "Данні.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Dbase db = new Dbase();
                        db.openconnection();
                        string query = "SELECT * FROM `tablentki`";
                        MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        using (var book = new XLWorkbook())
                        {
                            var worksheet = book.Worksheets.Add("Ліки");
                            worksheet.Cell(1, 1).InsertTable(dt);
                            worksheet.Columns().AdjustToContents();
                            book.SaveAs(sfd.FileName);
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true
                            });

                        }
                        db.closeconnection();
                        MessageBox.Show("Експорт пройшов успішно !!");



                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Помилка");

            }


        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Close();
        }

        private void программаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ця програма по обліку ліків створена студентом 2-го курсу 4-ї групи Земляним Павлом в 2025 році. "  +
                "Про хід створення, особливості та ресурси можно подивитися в 'звіті про роботу.' "
                + "Приемного користування та гарного настрою !");
        }
    }
}

