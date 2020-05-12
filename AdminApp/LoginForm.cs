using Bank.Models;
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

namespace AdminApp
{
    public partial class LoginForm : Form
    {
        private MyBank bank;
        public LoginForm()
        {
            InitializeComponent();
            bank = new MyBank();
        }

        private void LogIn()
        {
            bool loginRes = bank.LogInAsAdmin(loginTextBox.Text, passwordTextBox.Text);
            if (loginRes)
            {
                Program.context.MainForm = new MainMenuForm(bank);
                Close();
                Program.context.MainForm.Show();
            }
            else
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }
    }
}
