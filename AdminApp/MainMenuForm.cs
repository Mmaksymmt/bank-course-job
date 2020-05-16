﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Models;
using Common_Forms;
using CommonForms;

namespace AdminApp
{
    public partial class MainMenuForm : Form
    {
        private MyBank bank;

        public MainMenuForm(MyBank bank)
        {
            this.bank = bank;
            InitializeComponent();
            //Bank.FillTestData(10);
            CustomersBindingSource.DataSource = bank.Customers;            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Load();
            CustomersBindingSource.ResetBindings(false);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Save();
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
                    bank.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Customer toDelete
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (toDelete != null)
            {
                DialogResult res = MessageBox.Show(
                    $"Удалить {toDelete.Login}?", "Подтверждение", MessageBoxButtons.OKCancel
                );
                if (res == DialogResult.OK)
                {
                    bank.Customers.Remove(toDelete);
                    CustomersBindingSource.ResetBindings(false);
                }
            }
        }

        private void UsersGridView_SelectedValueChanged(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                DepositsBindingSource.DataSource = new List<int>();
                return;
            }

            Customer selectedCustomer
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (selectedCustomer != null)
            {
                DepositsBindingSource.DataSource = selectedCustomer.Deposits;
                DepositsBindingSource.ResetBindings(false);
            }
        }

        private void DeleteDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (depositsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Customer selectedCustomer
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            Deposit selectedDeposit =
                depositsGridView.SelectedRows[0].DataBoundItem as Deposit;
            if (selectedDeposit != null)
            {
                DialogResult res = MessageBox.Show(
                    "Удалить депозит?", "Подтверждение", MessageBoxButtons.OKCancel
                );
                if (res == DialogResult.OK)
                {
                    selectedCustomer.Deposits.Remove(selectedDeposit);
                    DepositsBindingSource.ResetBindings(false);
                }
            }
        }

        private void UploadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Charge();
            //CustomersBindingSource.ResetBindings(false);
            DepositsBindingSource.ResetBindings(false);
        }

        private void CustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Customer selectedCustomer
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (selectedCustomer != null)
            {
                var customerInfoForm = new CustomerInfoForm(selectedCustomer, bank, true);
                customerInfoForm.ShowDialog();
                CustomersBindingSource.ResetBindings(false);
            }
        }

        private void EditDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (depositsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Deposit selectedDeposit
                = depositsGridView.SelectedRows[0].DataBoundItem as Deposit;
            if (selectedDeposit != null)
            {
                var depositEditingForm = new DepositEditingForm(
                    usersGridView.SelectedRows[0].DataBoundItem as Customer,
                    selectedDeposit
                );
                depositEditingForm.ShowDialog();
                DepositsBindingSource.ResetBindings(false);
            }
        }

        private void DepositsGridView_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e
        )
        {
            var row = depositsGridView[e.ColumnIndex, e.RowIndex].OwningRow;
            var deposit = row.DataBoundItem as Deposit;
            if (deposit.FinishDate < DateTime.Now)
            {
                row.DefaultCellStyle.BackColor = Color.LightPink;
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);
                row.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            }
            else
            {
                row.DefaultCellStyle.BackColor =
                    depositsGridView.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.SelectionBackColor =
                    depositsGridView.DefaultCellStyle.SelectionBackColor;
                row.DefaultCellStyle.SelectionForeColor =
                    depositsGridView.DefaultCellStyle.SelectionForeColor;
            }
        }

        private void AvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conditionsForm = new DepositConditionsForm(bank);
            conditionsForm.Show();
        }

        private void CreateDeposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                return;
            }
            Customer customer = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (customer == null)
            {
                return;
            }

            var createDepositForm = new DepositAddingForm(bank, customer);
            createDepositForm.ShowDialog();
            DepositsBindingSource.ResetBindings(false);
        }
    }
}
