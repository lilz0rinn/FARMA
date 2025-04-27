namespace farma
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            loginbutton = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            passwordBox2 = new TextBox();
            loginBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(502, 42);
            label1.TabIndex = 0;
            label1.Text = "Вхід в аккаунт працівника";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 100);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(632, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 23);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightYellow;
            panel2.Controls.Add(loginbutton);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(passwordBox2);
            panel2.Controls.Add(loginBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(658, 144);
            panel2.TabIndex = 2;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.FromArgb(192, 255, 192);
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatAppearance.MouseDownBackColor = Color.Green;
            loginbutton.FlatAppearance.MouseOverBackColor = Color.Lime;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginbutton.Location = new Point(420, 36);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(178, 66);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "ВХІД";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(16, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(-428, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.kent;
            pictureBox1.Location = new Point(16, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // passwordBox2
            // 
            passwordBox2.BorderStyle = BorderStyle.FixedSingle;
            passwordBox2.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox2.Location = new Point(84, 81);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.Size = new Size(211, 40);
            passwordBox2.TabIndex = 1;
            passwordBox2.UseSystemPasswordChar = true;
            // 
            // loginBox1
            // 
            loginBox1.BorderStyle = BorderStyle.FixedSingle;
            loginBox1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox1.Location = new Point(84, 19);
            loginBox1.Multiline = true;
            loginBox1.Name = "loginBox1";
            loginBox1.Size = new Size(211, 40);
            loginBox1.TabIndex = 0;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            BackgroundImage = Properties.Resources.who_cards_08_sdg03_tmb_1200v;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(658, 660);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            Load += loginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox passwordBox2;
        private TextBox loginBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button loginbutton;
    }
}