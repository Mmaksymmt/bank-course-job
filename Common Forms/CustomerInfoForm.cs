﻿using Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonForms
{
    // Returns DialogResult.OK, if changed data
    public partial class CustomerInfoForm : Form
    {
        private Customer customer;
        private MyBank bank;
        private bool isInputChanged;
        private bool isDirty;

        public CustomerInfoForm(Customer customer, MyBank bank)
        {
            InitializeComponent();
            this.customer = customer;
            this.bank = bank;

            Fill();
            isInputChanged = false;
            isDirty = false;
            saveButton.Enabled = false;
        }

        private void Fill()
        {
            loginTextBox.Text = customer.Login;
            passwordTextBox.Text = customer.Password;
            fullNameTextBox.Text = customer.FullName;
            accNumberTextBox.Text = customer.AccountNumber.ToString();
            addressTextBox.Text = customer.Address;
            birthDateTimePicker.Value = customer.BirthDate;
        }

        // Saves new data, returns true if changed
        private bool Save()
        {
            try
            {
                if (bank.Find(loginTextBox.Text) != null
                    && loginTextBox.Text != customer.Login)
                {
                    throw new InputException("Этот логин уже занят!");
                }
                customer.Change(
                    new Customer(
                        loginTextBox.Text,
                        passwordTextBox.Text,
                        fullNameTextBox.Text,
                        accNumberTextBox.Text,
                        addressTextBox.Text,
                        birthDateTimePicker.Value
                    )
                );
                isDirty = true;
            }
            catch (InputException e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void InputChanged(object sender, EventArgs e)
        {
            isInputChanged = true;
            saveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
            isInputChanged = false;
            saveButton.Enabled = false;
        }

        private void CustomerInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult = DialogResult.OK;
            }

            if (isInputChanged)
            {
                var res = MessageBox.Show(
                    "Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel
                );

                switch (res)
                {
                    case DialogResult.OK:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
