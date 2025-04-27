namespace farma
{
    partial class addingadminmicroform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addingadminmicroform));
            loginBox1 = new TextBox();
            passwordBox2 = new TextBox();
            passagain = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            savebutton1 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginBox1
            // 
            loginBox1.BorderStyle = BorderStyle.FixedSingle;
            loginBox1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox1.Location = new Point(112, 12);
            loginBox1.Multiline = true;
            loginBox1.Name = "loginBox1";
            loginBox1.Size = new Size(198, 31);
            loginBox1.TabIndex = 2;
            // 
            // passwordBox2
            // 
            passwordBox2.BorderStyle = BorderStyle.FixedSingle;
            passwordBox2.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox2.Location = new Point(112, 67);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.Size = new Size(198, 40);
            passwordBox2.TabIndex = 3;
            passwordBox2.UseSystemPasswordChar = true;
            // 
            // passagain
            // 
            passagain.BorderStyle = BorderStyle.FixedSingle;
            passagain.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passagain.Location = new Point(112, 113);
            passagain.Name = "passagain";
            passagain.PasswordChar = '*';
            passagain.Size = new Size(198, 40);
            passagain.TabIndex = 4;
            passagain.UseSystemPasswordChar = true;
            passagain.TextChanged += passagain_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.kent;
            pictureBox1.Location = new Point(40, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(56, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(56, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // savebutton1
            // 
            savebutton1.BackColor = Color.FromArgb(192, 255, 192);
            savebutton1.FlatAppearance.BorderSize = 0;
            savebutton1.FlatAppearance.MouseDownBackColor = Color.Lime;
            savebutton1.FlatAppearance.MouseOverBackColor = Color.Olive;
            savebutton1.FlatStyle = FlatStyle.Flat;
            savebutton1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            savebutton1.Location = new Point(362, 13);
            savebutton1.Name = "savebutton1";
            savebutton1.Size = new Size(98, 47);
            savebutton1.TabIndex = 8;
            savebutton1.Text = "SAVE";
            savebutton1.UseVisualStyleBackColor = false;
            savebutton1.Click += savebutton1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(362, 88);
            button1.Name = "button1";
            button1.Size = new Size(98, 47);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addingadminmicroform
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 165);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(savebutton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(passagain);
            Controls.Add(passwordBox2);
            Controls.Add(loginBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addingadminmicroform";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addingadminmicroform";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox1;
        private TextBox passwordBox2;
        private TextBox passagain;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button savebutton1;
        private Button button1;
    }
}