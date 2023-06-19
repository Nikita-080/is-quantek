namespace InformSystem.Forms
{
    partial class Login
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
            panel1 = new Panel();
            WelcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 60);
            panel1.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(216, 7);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(245, 37);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Вход в систему";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pnppk;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(129, 82);
            LoginTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(445, 23);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.Text = "Имя пользователя";
            LoginTextBox.Enter += LoginTextBox_Enter;
            LoginTextBox.Leave += LoginTextBox_Leave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(129, 131);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(445, 23);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.Text = "Пароль";
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(129, 175);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(445, 30);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 377);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyDown += Login_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label WelcomeLabel;
        private PictureBox pictureBox1;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}