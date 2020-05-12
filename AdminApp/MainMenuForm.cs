using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Models;

namespace AdminApp
{
    public partial class MainMenuForm : Form
    {
        private MyBank Bank;

        public MainMenuForm(MyBank bank)
        {
            Bank = bank;
            InitializeComponent();
            Bank.FillTestData(10000);
            CustomersBindingSource.DataSource = Bank.Customers;
            usersList.DisplayMember = "InfoString";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.Load();
            CustomersBindingSource.ResetBindings(false);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.Save();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Сохранить данные перед закрытием?", "Выход", MessageBoxButtons.YesNoCancel
            );
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    Bank.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer toDelete = usersList.SelectedItem as Customer;
            if (toDelete != null)
            {
                DialogResult res = MessageBox.Show(
                    $"Удалить {toDelete.Login}?", "Подтверждение", MessageBoxButtons.OKCancel
                );
                if (res == DialogResult.OK)
                {
                    Bank.RemoveCustomer(toDelete);
                    CustomersBindingSource.ResetBindings(false);
                }
            }
        }

        private void UsersList_SelectedValueChanged(object sender, EventArgs e)
        {
            Customer selectedCustomer = usersList.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                DepositsBindingSource.DataSource = selectedCustomer.Deposits;
                DepositsBindingSource.ResetBindings(false);
                depositsList.DisplayMember = "InfoString";
            }
            else
            {
                DepositsBindingSource.DataSource = new List<int>();
            }
        }

        private void DeleteDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = usersList.SelectedItem as Customer;
            Deposit selectedDeposit = depositsList.SelectedItem as Deposit;
            if (selectedDeposit != null)
            {
                DialogResult res = MessageBox.Show(
                    "Удалить депозит?", "Подтверждение", MessageBoxButtons.OKCancel
                );
                if (res == DialogResult.OK)
                {
                    Bank.RemoveDeposit(selectedCustomer, selectedDeposit);
                    DepositsBindingSource.ResetBindings(false);
                }
            }
        }

        private void UploadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.Charge();
            CustomersBindingSource.ResetBindings(false);
            DepositsBindingSource.ResetBindings(false);
        }

        private void CustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = usersList.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                var customerInfoForm = new CustomerInfoForm(selectedCustomer);
                customerInfoForm.ShowDialog();
                CustomersBindingSource.ResetBindings(false);
            }
        }

        private void EditDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit selectedDeposit = depositsList.SelectedItem as Deposit;
            if (selectedDeposit != null)
            {
                var depositEditingForm = new DepositEditingForm(
                    usersList.SelectedItem as Customer, selectedDeposit
                );
                depositEditingForm.ShowDialog();
                DepositsBindingSource.ResetBindings(false);
            }
        }
    }
}
