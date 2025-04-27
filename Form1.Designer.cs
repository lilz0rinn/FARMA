namespace farma
{
    partial class eBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eBase));
            mainstrip = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            довідникToolStripMenuItem = new ToolStripMenuItem();
            налаштуванняToolStripMenuItem = new ToolStripMenuItem();
            аккаунтToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            программаToolStripMenuItem = new ToolStripMenuItem();
            дляАдміністратораToolStripMenuItem = new ToolStripMenuItem();
            searchTabl = new TextBox();
            add_button = new Button();
            edit_but = new Button();
            del_button = new Button();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userLabel = new Label();
            pictureBox2 = new PictureBox();
            moreBUT = new Button();
            export_button = new Button();
            mainstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mainstrip
            // 
            mainstrip.BackColor = Color.Silver;
            mainstrip.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, налаштуванняToolStripMenuItem });
            mainstrip.Location = new Point(0, 0);
            mainstrip.Name = "mainstrip";
            mainstrip.Size = new Size(1788, 24);
            mainstrip.TabIndex = 0;
            mainstrip.Text = "mainstrip";
            mainstrip.ItemClicked += mainstrip_ItemClicked;
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { довідникToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(48, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // довідникToolStripMenuItem
            // 
            довідникToolStripMenuItem.Name = "довідникToolStripMenuItem";
            довідникToolStripMenuItem.Size = new Size(121, 22);
            довідникToolStripMenuItem.Text = "Довідник";
            // 
            // налаштуванняToolStripMenuItem
            // 
            налаштуванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { аккаунтToolStripMenuItem, программаToolStripMenuItem, дляАдміністратораToolStripMenuItem });
            налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            налаштуванняToolStripMenuItem.Size = new Size(94, 20);
            налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // аккаунтToolStripMenuItem
            // 
            аккаунтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            аккаунтToolStripMenuItem.Size = new Size(180, 22);
            аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "Вийти";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            программаToolStripMenuItem.Size = new Size(180, 22);
            программаToolStripMenuItem.Text = "Программа";
            программаToolStripMenuItem.Click += программаToolStripMenuItem_Click;
            // 
            // дляАдміністратораToolStripMenuItem
            // 
            дляАдміністратораToolStripMenuItem.Name = "дляАдміністратораToolStripMenuItem";
            дляАдміністратораToolStripMenuItem.Size = new Size(180, 22);
            дляАдміністратораToolStripMenuItem.Text = "Для адміністратора ";
            дляАдміністратораToolStripMenuItem.Click += дляАдміністратораToolStripMenuItem_Click;
            // 
            // searchTabl
            // 
            searchTabl.Location = new Point(1122, 79);
            searchTabl.Name = "searchTabl";
            searchTabl.Size = new Size(179, 21);
            searchTabl.TabIndex = 2;
            searchTabl.TextChanged += searchTabl_TextChanged;
            // 
            // add_button
            // 
            add_button.Location = new Point(1122, 122);
            add_button.Name = "add_button";
            add_button.Size = new Size(152, 23);
            add_button.TabIndex = 3;
            add_button.Text = "Додати препарат";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // edit_but
            // 
            edit_but.Location = new Point(1122, 175);
            edit_but.Name = "edit_but";
            edit_but.Size = new Size(152, 23);
            edit_but.TabIndex = 4;
            edit_but.Text = "Редагувати інформацію";
            edit_but.UseVisualStyleBackColor = true;
            edit_but.Click += edit_but_Click;
            // 
            // del_button
            // 
            del_button.Location = new Point(1122, 234);
            del_button.Name = "del_button";
            del_button.Size = new Size(152, 23);
            del_button.TabIndex = 5;
            del_button.Text = "Видалити препарат";
            del_button.UseVisualStyleBackColor = true;
            del_button.Click += del_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 961);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 255, 192);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(855, 950);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 39);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Оновити ";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(1122, 48);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 8;
            label1.Text = "Пошук препарату ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1476, 766);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userLabel.Location = new Point(1588, 954);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(59, 19);
            userLabel.TabIndex = 10;
            userLabel.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.kent;
            pictureBox2.Location = new Point(1476, 935);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // moreBUT
            // 
            moreBUT.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moreBUT.Location = new Point(1122, 297);
            moreBUT.Name = "moreBUT";
            moreBUT.Size = new Size(152, 23);
            moreBUT.TabIndex = 12;
            moreBUT.Text = "Властивості";
            moreBUT.UseVisualStyleBackColor = true;
            moreBUT.Click += moreBUT_Click;
            // 
            // export_button
            // 
            export_button.BackColor = Color.PaleGreen;
            export_button.FlatAppearance.BorderSize = 0;
            export_button.FlatStyle = FlatStyle.Flat;
            export_button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            export_button.Location = new Point(1122, 614);
            export_button.Name = "export_button";
            export_button.Size = new Size(152, 50);
            export_button.TabIndex = 13;
            export_button.Text = "Експорт до Exel ";
            export_button.UseVisualStyleBackColor = false;
            export_button.Click += export_button_Click;
            // 
            // eBase
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1788, 992);
            Controls.Add(export_button);
            Controls.Add(moreBUT);
            Controls.Add(pictureBox2);
            Controls.Add(userLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(del_button);
            Controls.Add(edit_but);
            Controls.Add(add_button);
            Controls.Add(searchTabl);
            Controls.Add(mainstrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainstrip;
            Name = "eBase";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eBase";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            mainstrip.ResumeLayout(false);
            mainstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainstrip;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem довідникToolStripMenuItem;
        private ToolStripMenuItem налаштуванняToolStripMenuItem;
        private ToolStripMenuItem аккаунтToolStripMenuItem;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem дляАдміністратораToolStripMenuItem;
        private TextBox searchTabl;
        private Button add_button;
        private Button edit_but;
        private Button del_button;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Label label1;
        private PictureBox pictureBox1;
        private Label userLabel;
        private PictureBox pictureBox2;
        private Button moreBUT;
        private Button export_button;
        private ToolStripTextBox toolStripTextBox1;
    }
}
