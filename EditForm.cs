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
    public partial class EditForm : Form
    {
        private readonly int _id;
        public EditForm(int id, string name, string producer, string type,
                       int quantity, DateTime expiryDate, bool requiresPrescription)
        {
            InitializeComponent();
            _id = id;

            txtName.Text = name;
            txtProducer.Text = producer;

            cmbType.Items.AddRange(new object[] { });
            cmbType.SelectedItem = type;

            numQuantity.Value = quantity;
            dtpExpiryDate.Value = expiryDate;
            chkPrescription.Checked = requiresPrescription;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            

            btnSave.Click += btnSave_Click;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву препарату!", "Попередження",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Виберіть тип препарату!", "Попередження",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dbase db = new Dbase();
            {
                try
                {
                    db.openconnection();

                    string query = @"UPDATE `tablentki` 
                                   SET `Назва` = @name,
                                       `Виробник` = @producer,
                                       `Тип препарату` = @type,
                                       `Кількість` = @quantity,
                                       `Придатний до` = @expiryDate,
                                       `Рецепт` = @prescription
                                   WHERE `id` = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@producer", txtProducer.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@quantity", (int)numQuantity.Value);
                        cmd.Parameters.AddWithValue("@expiryDate", dtpExpiryDate.Value.Date);
                        cmd.Parameters.AddWithValue("@prescription", chkPrescription.Checked ? "Так" : "Ні");
                        cmd.Parameters.AddWithValue("@id", _id);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Дані успішно оновлено!", "Успіх",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося оновити дані.", "Помилка",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        db.closeconnection();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Помилка бази даних: {ex.Message}", "Помилка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
