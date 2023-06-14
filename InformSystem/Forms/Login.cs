using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem.Forms
{
    public partial class Login : Form
    {
        public static string login;
        public static string password;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            mainMenu.FormClosed += Logout;
            login = LoginTextBox.Text;
            password = PasswordTextBox.Text;
            if (LoginTextBox.Text == "Имя пользователя")
                login = "";
            else
                login = LoginTextBox.Text;
            if (PasswordTextBox.Text == "Пароль")
                password = "";
            else
                password = PasswordTextBox.Text;

            this.Hide();



        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Имя пользователя")
            {
                LoginTextBox.Text = "";
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Имя пользователя";

            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Пароль";
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            //PasswordTextBox.Clear();
            //LoginTextBox.Clear();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
