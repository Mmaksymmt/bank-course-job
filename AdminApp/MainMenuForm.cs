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
        public MainMenuForm()
        {
            InitializeComponent();
            Bank = new MyBank();
            //Bank.FillTestData(3);
            CustomersBindingSource.DataSource = Bank.Customers;
            UsersList.DisplayMember = "Login";
        }

        private MyBank Bank;

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
            Customer toDelete = UsersList.SelectedItem as Customer;
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
            Customer selectedCustomer = UsersList.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                DepositsBindingSource.DataSource = selectedCustomer.Deposits;
                DepositsBindingSource.ResetBindings(false);
                DepositsList.DisplayMember = "Info";
            }
            else
            {
                DepositsBindingSource.DataSource = new List<int>();
            }
        }

        private void DeleteDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = UsersList.SelectedItem as Customer;
            Deposit selectedDeposit = DepositsList.SelectedItem as Deposit;
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
    }
}
