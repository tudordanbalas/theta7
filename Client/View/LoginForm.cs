﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class LoginForm : Form
    {
        private bool waterMarkUsernameActive;
        private bool waterMarkPasswordActive;

        public LoginForm()
        {
            InitializeComponent();
            initUsernameView();
            initPasswordView();
        }

        private void initUsernameView()
        {
            waterMarkUsernameActive = true;
            usernameLabel.Hide();
            usernameTextBox.ForeColor = Color.Gray;
            usernameTextBox.Text = "Username";
            usernameTextBox.GotFocus += (source, e) =>
            {
                if (waterMarkUsernameActive)
                {
                    waterMarkUsernameActive = false;
                    usernameLabel.Show();
                    usernameTextBox.Text = "";
                    usernameTextBox.ForeColor = Color.Black;
                }
            };
            usernameTextBox.LostFocus += (source, e) =>
            {
                if (!waterMarkUsernameActive && string.IsNullOrEmpty(usernameTextBox.Text))
                {
                    waterMarkUsernameActive = true;
                    usernameLabel.Hide();
                    usernameTextBox.Text = "Username";
                    usernameTextBox.ForeColor = Color.Gray;
                }
            };
        }
        private void initPasswordView()
        {
            waterMarkPasswordActive = true;
            passwordLabel.Hide();
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Text = "Password";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.GotFocus += (source, e) =>
            {
                if (waterMarkPasswordActive)
                {
                    waterMarkPasswordActive = false;
                    passwordLabel.Show();
                    passwordTextBox.Text = "";
                    passwordTextBox.PasswordChar = '*';
                    passwordTextBox.ForeColor = Color.Black;
                }
            };
            passwordTextBox.LostFocus += (source, e) =>
            {
                if (!waterMarkPasswordActive && string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    waterMarkPasswordActive = true;
                    passwordLabel.Hide();
                    passwordTextBox.Text = "Password";
                    passwordTextBox.PasswordChar = '\0';
                    passwordTextBox.ForeColor = Color.Gray;
                }
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Console.Write("BUTTON LOGIN HAVE BEEN PRESSED");
            Console.WriteLine(usernameTextBox.Text);
            Console.WriteLine(passwordTextBox.Text);
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }
    }
}