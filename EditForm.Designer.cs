namespace farma
{
    partial class EditForm
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
            txtName = new TextBox();
            txtProducer = new TextBox();
            cmbType = new ComboBox();
            numQuantity = new NumericUpDown();
            dtpExpiryDate = new DateTimePicker();
            chkPrescription = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(23, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 21);
            txtName.TabIndex = 0;
            // 
            // txtProducer
            // 
            txtProducer.Location = new Point(228, 34);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new Size(173, 21);
            txtProducer.TabIndex = 1;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Анальгетик", "", "Антибіотик", "", "Антисептик", "", "Антигістамінний (від алергії)", "", "Противірусний", "", "Протигрибковий", "", "Протизапальний", "", "Жарознижувальний", "", "Спазмолітик", "", "Седативний (заспокійливий)", "", "Снодійний", "", "Вітаміни та мінерали", "", "Гормональний препарат", "", "Імуномодулятор", "", "Серцево-судинний препарат", "", "Протикашльовий", "", "Муколітик (відхаркувальний)", "", "Антидепресант", "", "Протиепілептичний", "", "Протиблювотний", "", "Протидіарейний", "", "Засоби для шлунково-кишкового тракту", "", "Гастропротектор (при виразці/гастриті)", "", "Засіб від печії", "", "Сечогінний (діуретик)", "", "Препарат для зниження тиску", "", "Засіб для підвищення тиску", "", "Антикоагулянт (розріджувач крові)", "", "Антисудомний", "", "Засіб для зовнішнього застосування", "", "Препарат для інгаляцій", "", "Очні краплі", "", "Вушні краплі", "", "Назальні засоби (для носа)", "", "Місцевий анестетик", "", "Контрацептив", "", "Засіб для лікування цукрового діабету", "", "Антипаразитарний", "", "Вакцина", "", "БАД (біологічно активна добавка)", "", "Інше" });
            cmbType.Location = new Point(452, 32);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(188, 21);
            cmbType.TabIndex = 2;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(706, 33);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(145, 21);
            numQuantity.TabIndex = 3;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(912, 33);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(200, 21);
            dtpExpiryDate.TabIndex = 4;
            // 
            // chkPrescription
            // 
            chkPrescription.AutoSize = true;
            chkPrescription.Location = new Point(1156, 34);
            chkPrescription.Name = "chkPrescription";
            chkPrescription.Size = new Size(44, 17);
            chkPrescription.TabIndex = 5;
            chkPrescription.Text = "Так";
            chkPrescription.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(422, 106);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 32);
            btnSave.TabIndex = 6;
            btnSave.Text = "Змінити";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(605, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 32);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 150);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkPrescription);
            Controls.Add(dtpExpiryDate);
            Controls.Add(numQuantity);
            Controls.Add(cmbType);
            Controls.Add(txtProducer);
            Controls.Add(txtName);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtProducer;
        private ComboBox cmbType;
        private NumericUpDown numQuantity;
        private DateTimePicker dtpExpiryDate;
        private CheckBox chkPrescription;
        private Button btnSave;
        private Button btnCancel;
    }
}