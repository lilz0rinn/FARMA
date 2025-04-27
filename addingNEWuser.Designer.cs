namespace farma
{
    partial class addingNEWuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addingNEWuser));
            button1 = new Button();
            savebutton1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            passagain = new TextBox();
            passwordBox2 = new TextBox();
            loginBox1 = new TextBox();
            dolsh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(345, 97);
            button1.Name = "button1";
            button1.Size = new Size(98, 47);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // savebutton1
            // 
            savebutton1.BackColor = Color.FromArgb(192, 255, 192);
            savebutton1.FlatAppearance.BorderSize = 0;
            savebutton1.FlatAppearance.MouseDownBackColor = Color.Lime;
            savebutton1.FlatAppearance.MouseOverBackColor = Color.Olive;
            savebutton1.FlatStyle = FlatStyle.Flat;
            savebutton1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            savebutton1.Location = new Point(345, 14);
            savebutton1.Name = "savebutton1";
            savebutton1.Size = new Size(98, 47);
            savebutton1.TabIndex = 16;
            savebutton1.Text = "SAVE";
            savebutton1.UseVisualStyleBackColor = false;
            savebutton1.Click += savebutton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(41, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(41, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.kent;
            pictureBox1.Location = new Point(23, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // passagain
            // 
            passagain.BorderStyle = BorderStyle.FixedSingle;
            passagain.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passagain.Location = new Point(95, 113);
            passagain.Name = "passagain";
            passagain.PasswordChar = '*';
            passagain.Size = new Size(198, 40);
            passagain.TabIndex = 12;
            passagain.UseSystemPasswordChar = true;
            // 
            // passwordBox2
            // 
            passwordBox2.BorderStyle = BorderStyle.FixedSingle;
            passwordBox2.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordBox2.Location = new Point(95, 67);
            passwordBox2.Name = "passwordBox2";
            passwordBox2.PasswordChar = '*';
            passwordBox2.Size = new Size(198, 40);
            passwordBox2.TabIndex = 11;
            passwordBox2.UseSystemPasswordChar = true;
            // 
            // loginBox1
            // 
            loginBox1.BorderStyle = BorderStyle.FixedSingle;
            loginBox1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBox1.Location = new Point(95, 12);
            loginBox1.Multiline = true;
            loginBox1.Name = "loginBox1";
            loginBox1.Size = new Size(198, 31);
            loginBox1.TabIndex = 10;
            // 
            // dolsh
            // 
            dolsh.BorderStyle = BorderStyle.FixedSingle;
            dolsh.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dolsh.Location = new Point(95, 168);
            dolsh.Name = "dolsh";
            dolsh.Size = new Size(198, 40);
            dolsh.TabIndex = 18;
            dolsh.TextChanged += dolsh_TextChanged;
            // 
            // addingNEWuser
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(481, 231);
            Controls.Add(dolsh);
            Controls.Add(button1);
            Controls.Add(savebutton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(passagain);
            Controls.Add(passwordBox2);
            Controls.Add(loginBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addingNEWuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addingNEWuser";
            TopMost = true;
            Load += addingNEWuser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button savebutton1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox passagain;
        private TextBox passwordBox2;
        private TextBox loginBox1;
        private TextBox dolsh;
    }
}