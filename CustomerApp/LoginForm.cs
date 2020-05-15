using Bank.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApp
{
    public partial class LoginForm : Form
    {
        MyBank bank;

        public LoginForm(MyBank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        public LoginForm() : this(new MyBank())
        {
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            Customer customer = bank.Find(login);
            Console.WriteLine(bank.Customers.Count);

            if (customer == null || customer.Password != password)
            {
                MessageBox.Show("Не верные данные. " +
                    "Попробуйте снова или создайте новый аккаунт");
                return;
            }

            // If no exceptions - login

            Program.context.MainForm = new MainMenuForm(bank, customer);
            Close();
            Program.context.MainForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Program.context.MainForm = new RegisterForm(bank);
            Close();
            Program.context.MainForm.Show();
        }
    }
}
