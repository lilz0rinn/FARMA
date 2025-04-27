namespace farma
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            label1 = new Label();
            loginBox1 = new TextBox();
            passwordBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            loginbutton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 0;
            // 
            // loginBox1
            // 
            loginBox1.BorderStyle = BorderStyle.FixedSingle;
            loginBox1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox1.Location = new Point(102, 220);
            loginBox1.Multiline = true;
            loginBox1.Name = "loginBox1";
            loginBox1.Size = new Size(211, 40);
            loginBox1.TabIndex = 1;
            loginBox1.TextChanged += loginBox1_TextChanged;
            // 
            // passwordBox2
            // 
            passwordBox2.BorderStyle = BorderStyle.FixedSingle;
            passwordBox2.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox2.Location = new Point(102, 300);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.Size = new Size(211, 40);
            passwordBox2.TabIndex = 2;
            passwordBox2.UseSystemPasswordChar = true;
            passwordBox2.TextChanged += passwordBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.kent;
            pictureBox1.Location = new Point(29, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(29, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(192, 255, 192);
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatAppearance.MouseDownBackColor = Color.Green;
            loginbutton.FlatAppearance.MouseOverBackColor = Color.Lime;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginbutton.Location = new Point(332, 250);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(178, 66);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "ВХІД";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 100);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(74, 35);
            label2.Name = "label2";
            label2.Size = new Size(386, 24);
            label2.TabIndex = 0;
            label2.Text = "Меню входу до кабінета адміністратора ";
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 463);
            Controls.Add(panel1);
            Controls.Add(loginbutton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(passwordBox2);
            Controls.Add(loginBox1);
            Controls.Add(label1);
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginBox1;
        private TextBox passwordBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button loginbutton;
        private Panel panel1;
        private Label label2;
    }
}