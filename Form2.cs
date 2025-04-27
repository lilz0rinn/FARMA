using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace farma
{
    public partial class addFORM : Form
    {

        private TextBox nameTextBox;

        public addFORM()
        {
            InitializeComponent();
            this.Text = "Добавление препарата";
            this.Size = new Size(700, 800);
            this.StartPosition = FormStartPosition.CenterParent;




        }

        private void addFORM_Load(object sender, EventArgs e)
        {
        }
        Point lastPoint;

        private void typeBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = checkBox2.Checked ? SystemColors.ControlText : Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.ForeColor = checkBox2.Checked ? SystemColors.ControlText : Color.Red;
        }

        private void save_tabl_Click(object sender, EventArgs e)
        {
           
            //string nameTabl = NAME_textBox1.Text;
           // string proizvod = POST_textbox.Text;
           // string typeoftabl = much_Box1.Text;
           // string OD = OD_combo.Text;
           // int shtukki = shtuki.Width;
//MySqlDataAdapter adapter = new MySqlDataAdapter();
            
           // DataTable table = new DataTable();
            Dbase dbase = new Dbase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tablentki` (`Назва`, `Виробник`, `Тип препарату`,`Одиниця`, `Кількість`, `Придатний до`, `Рецепт`) VALUES (@name, @proizvod, @typeof,@odu, @kolich, @timeto, @recept);", dbase.getConnection() );

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NAME_textBox1.Text;
            command.Parameters.Add("@proizvod", MySqlDbType.VarChar).Value = POST_textbox.Text;
            command.Parameters.Add("@kolich", MySqlDbType.Int32).Value = (int)shtuki.Value;



            string selectedType = much_Box1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("Оберіть тип зі списку type!");
                return;
            }


            command.Parameters.Add("@typeof", MySqlDbType.VarChar).Value = selectedType;
            ////
            string selectedType1 = OD_combo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("Оберіть тип зі списку od!");
                return;
            }


            command.Parameters.Add("@odu", MySqlDbType.VarChar).Value = selectedType1;

            command.Parameters.Add("@timeto", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;

           string status = receptDA_checkBox3.Checked ? "Так" : "Ні";

            command.Parameters.Add("@recept", MySqlDbType.VarChar).Value = status;

            dbase.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Препарат додано до бази !");

                if (this.Owner is eBase mainForm)
                {
                    mainForm.LoadDataToDataGridView();
                    
                }
                Close();


            }
            else {
                MessageBox.Show("ERROR");
            }

            dbase.closeconnection();




        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void addFORM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void addFORM_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public string MedicationName => nameTextBox.Text;
    }
}