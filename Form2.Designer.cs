namespace farma
{
    partial class addFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            much_Box1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            shtuki = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            OD_combo = new ComboBox();
            label6 = new Label();
            NAME_textBox1 = new TextBox();
            POST_textbox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            save_tabl = new Button();
            cancel_button2 = new Button();
            receptDA_checkBox3 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)shtuki).BeginInit();
            SuspendLayout();
            // 
            // much_Box1
            // 
            much_Box1.FormattingEnabled = true;
            much_Box1.Items.AddRange(new object[] { "Анальгетик", "", "Антибіотик", "", "Антисептик", "", "Антигістамінний (від алергії)", "", "Противірусний", "", "Протигрибковий", "", "Протизапальний", "", "Жарознижувальний", "", "Спазмолітик", "", "Седативний (заспокійливий)", "", "Снодійний", "", "Вітаміни та мінерали", "", "Гормональний препарат", "", "Імуномодулятор", "", "Серцево-судинний препарат", "", "Протикашльовий", "", "Муколітик (відхаркувальний)", "", "Антидепресант", "", "Протиепілептичний", "", "Протиблювотний", "", "Протидіарейний", "", "Засоби для шлунково-кишкового тракту", "", "Гастропротектор (при виразці/гастриті)", "", "Засіб від печії", "", "Сечогінний (діуретик)", "", "Препарат для зниження тиску", "", "Засіб для підвищення тиску", "", "Антикоагулянт (розріджувач крові)", "", "Антисудомний", "", "Засіб для зовнішнього застосування", "", "Препарат для інгаляцій", "", "Очні краплі", "", "Вушні краплі", "", "Назальні засоби (для носа)", "", "Місцевий анестетик", "", "Контрацептив", "", "Засіб для лікування цукрового діабету", "", "Антипаразитарний", "", "Вакцина", "", "БАД (біологічно активна добавка)", "", "Інше" });
            much_Box1.Location = new Point(72, 264);
            much_Box1.Name = "much_Box1";
            much_Box1.Size = new Size(242, 21);
            much_Box1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(72, 361);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 21);
            dateTimePicker1.TabIndex = 2;
            // 
            // shtuki
            // 
            shtuki.Location = new Point(379, 361);
            shtuki.Name = "shtuki";
            shtuki.Size = new Size(242, 21);
            shtuki.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 17);
            label1.TabIndex = 4;
            label1.Text = "Форма для додавання препаратів";
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 343);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Придатний до:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(379, 343);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Кількість:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(72, 248);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "Тип препарату:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(379, 248);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 8;
            label5.Text = "Продаж за рецептом:";
            // 
            // OD_combo
            // 
            OD_combo.FormattingEnabled = true;
            OD_combo.Items.AddRange(new object[] { "Пачка", "ШТ", "Ампула", "Банка" });
            OD_combo.Location = new Point(72, 435);
            OD_combo.Name = "OD_combo";
            OD_combo.Size = new Size(242, 21);
            OD_combo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(72, 419);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Одиниця:";
            // 
            // NAME_textBox1
            // 
            NAME_textBox1.BorderStyle = BorderStyle.FixedSingle;
            NAME_textBox1.Location = new Point(72, 173);
            NAME_textBox1.Name = "NAME_textBox1";
            NAME_textBox1.Size = new Size(242, 21);
            NAME_textBox1.TabIndex = 11;
            // 
            // POST_textbox
            // 
            POST_textbox.BorderStyle = BorderStyle.FixedSingle;
            POST_textbox.Location = new Point(379, 173);
            POST_textbox.Name = "POST_textbox";
            POST_textbox.Size = new Size(242, 21);
            POST_textbox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(72, 155);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 13;
            label7.Text = "Назва препарату:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(379, 155);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 14;
            label8.Text = "Постачальник:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(72, 597);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 23);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Прийняти АППВ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(72, 534);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(145, 23);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "Всі данні звірено ";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // save_tabl
            // 
            save_tabl.BackColor = Color.FromArgb(128, 255, 128);
            save_tabl.FlatAppearance.BorderSize = 0;
            save_tabl.FlatAppearance.MouseDownBackColor = Color.Lime;
            save_tabl.FlatStyle = FlatStyle.Flat;
            save_tabl.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            save_tabl.Location = new Point(72, 672);
            save_tabl.Name = "save_tabl";
            save_tabl.Size = new Size(141, 39);
            save_tabl.TabIndex = 17;
            save_tabl.Text = "Зберегети ";
            save_tabl.UseVisualStyleBackColor = false;
            save_tabl.Click += save_tabl_Click;
            // 
            // cancel_button2
            // 
            cancel_button2.BackColor = Color.FromArgb(255, 128, 128);
            cancel_button2.FlatAppearance.BorderColor = Color.Red;
            cancel_button2.FlatAppearance.BorderSize = 0;
            cancel_button2.FlatAppearance.MouseDownBackColor = Color.Red;
            cancel_button2.FlatStyle = FlatStyle.Flat;
            cancel_button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancel_button2.Location = new Point(379, 672);
            cancel_button2.Name = "cancel_button2";
            cancel_button2.Size = new Size(146, 39);
            cancel_button2.TabIndex = 18;
            cancel_button2.Text = "Вихід";
            cancel_button2.UseVisualStyleBackColor = false;
            cancel_button2.Click += cancel_button2_Click;
            // 
            // receptDA_checkBox3
            // 
            receptDA_checkBox3.AutoSize = true;
            receptDA_checkBox3.Location = new Point(379, 266);
            receptDA_checkBox3.Name = "receptDA_checkBox3";
            receptDA_checkBox3.Size = new Size(46, 17);
            receptDA_checkBox3.TabIndex = 19;
            receptDA_checkBox3.Text = "ТАК";
            receptDA_checkBox3.UseVisualStyleBackColor = true;
            // 
            // addFORM
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(684, 765);
            Controls.Add(receptDA_checkBox3);
            Controls.Add(cancel_button2);
            Controls.Add(save_tabl);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(POST_textbox);
            Controls.Add(NAME_textBox1);
            Controls.Add(label6);
            Controls.Add(OD_combo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shtuki);
            Controls.Add(dateTimePicker1);
            Controls.Add(much_Box1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addFORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += addFORM_Load;
            MouseDown += addFORM_MouseDown;
            MouseMove += addFORM_MouseMove;
            ((System.ComponentModel.ISupportInitialize)shtuki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox much_Box1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown shtuki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox OD_combo;
        private Label label6;
        private TextBox NAME_textBox1;
        private TextBox POST_textbox;
        private Label label7;
        private Label label8;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button save_tabl;
        private Button cancel_button2;
        private CheckBox receptDA_checkBox3;
    }
}