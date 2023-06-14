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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 100);
            panel1.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(309, 11);
            WelcomeLabel.Margin = new Padding(4, 0, 4, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(368, 55);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Вход в систему";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pnppk;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(184, 136);
            LoginTextBox.Margin = new Padding(4, 4, 4, 4);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(636, 34);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.Text = "Имя пользователя";
            LoginTextBox.Enter += LoginTextBox_Enter;
            LoginTextBox.Leave += LoginTextBox_Leave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(184, 218);
            PasswordTextBox.Margin = new Padding(4, 4, 4, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(636, 34);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.Text = "Пароль";
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(184, 292);
            LoginButton.Margin = new Padding(4, 4, 4, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(636, 50);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 629);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
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