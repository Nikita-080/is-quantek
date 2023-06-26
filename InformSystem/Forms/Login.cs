using Microsoft.EntityFrameworkCore;
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
            KeyPreview = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        private void LogIn()
        {
            Main mainMenu = new Main();
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

        private void LoginButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) LogIn();
        }
    }
}
