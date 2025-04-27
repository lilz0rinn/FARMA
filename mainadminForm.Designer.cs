namespace farma
{
    partial class admin
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
            addnewadmin = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            add_us = new Button();
            label2 = new Label();
            btnRefresh = new Button();
            del_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addnewadmin
            // 
            addnewadmin.BackColor = Color.MistyRose;
            addnewadmin.FlatAppearance.BorderSize = 0;
            addnewadmin.FlatStyle = FlatStyle.Flat;
            addnewadmin.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addnewadmin.Location = new Point(355, 16);
            addnewadmin.Name = "addnewadmin";
            addnewadmin.Size = new Size(78, 28);
            addnewadmin.TabIndex = 0;
            addnewadmin.Text = "ADD";
            addnewadmin.UseVisualStyleBackColor = false;
            addnewadmin.Click += addnewadmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(278, 22);
            label1.TabIndex = 1;
            label1.Text = "Додати нового адміністратора ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(510, 278);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // add_us
            // 
            add_us.BackColor = Color.FromArgb(128, 255, 128);
            add_us.FlatAppearance.BorderSize = 0;
            add_us.FlatStyle = FlatStyle.Flat;
            add_us.Location = new Point(355, 73);
            add_us.Name = "add_us";
            add_us.Size = new Size(78, 29);
            add_us.TabIndex = 3;
            add_us.Text = "ADD";
            add_us.UseVisualStyleBackColor = false;
            add_us.Click += add_us_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 73);
            label2.Name = "label2";
            label2.Size = new Size(251, 22);
            label2.TabIndex = 4;
            label2.Text = "Додати нового користувача";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 255, 192);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(423, 669);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 39);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Оновити ";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // del_button
            // 
            del_button.BackColor = Color.FromArgb(255, 192, 192);
            del_button.FlatAppearance.BorderSize = 0;
            del_button.FlatAppearance.MouseDownBackColor = Color.Red;
            del_button.FlatStyle = FlatStyle.Flat;
            del_button.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            del_button.Location = new Point(239, 669);
            del_button.Name = "del_button";
            del_button.Size = new Size(152, 39);
            del_button.TabIndex = 9;
            del_button.Text = "Видалити";
            del_button.UseVisualStyleBackColor = false;
            del_button.Click += del_button_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 807);
            Controls.Add(del_button);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(add_us);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(addnewadmin);
            Name = "admin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainadmin";
            TopMost = true;
            Load += mainadminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addnewadmin;
        private Label label1;
        private DataGridView dataGridView1;
        private Button add_us;
        private Label label2;
        private Button btnRefresh;
        private Button del_button;
    }
}