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

namespace CustomerApp
{
    public partial class RegisterForm : Form
    {
        private MyBank bank;

        public RegisterForm(MyBank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Program.context.MainForm = new LoginForm(bank);
            Close();
            Program.context.MainForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(
                loginTextBox.Text,
                passwordTextBox.Text,
                fullNameTextBox.Text,
                accNumberTextBox.Text,
                addressTextBox.Text,
                birthDateTimePicker.Value
            );

            try
            {
                if (bank.Find(customer.Login) != null)
                {
                    throw new InputException("Этот логин уже занят!");
                }
                customer.CheckData();
            }
            catch (InputException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            // If no exceptions - register and login

            bank.Customers.Add(customer);
            Program.context.MainForm = new MainMenuForm(bank, customer);
            Close();
            Program.context.MainForm.Show();
        }
    }
}
