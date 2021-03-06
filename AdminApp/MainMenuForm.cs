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
        private bool isDirty;

        public MainMenuForm(MyBank bank)
        {
            this.bank = bank;
            isDirty = false;
            InitializeComponent();
            EnableCustomerButtons(false);
            EnableDepositButtons(false);
            //Bank.FillTestData(10);
            CustomersBindingSource.DataSource = bank.Customers;            
        }

        private void EnableDepositButtons(bool value)
        {
            deleteDepositToolStripMenuItem.Enabled = value;
            editDepositToolStripMenuItem.Enabled = value;
        }

        private void EnableCustomerButtons(bool value)
        {
            customerInfoToolStripMenuItem.Enabled = value;
            deleteToolStripMenuItem.Enabled = value;
            createDeposToolStripMenuItem.Enabled = value;
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
            isDirty = false;
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDirty)
            {
                return;
            }

            DialogResult res = MessageBox.Show(
                "Сохранить данные перед закрытием?", "Выход", MessageBoxButtons.YesNoCancel
            );
            switch (res)
            {
                case DialogResult.Yes:
                    bank.Save();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    isDirty = true;
                }
            }
        }

        private void DeleteDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    isDirty = true;
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
            Customer selectedCustomer
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (selectedCustomer != null)
            {
                var customerInfoForm = new CustomerInfoFormAdmin(selectedCustomer, bank);
                DialogResult res = customerInfoForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    isDirty = true;
                }
                CustomersBindingSource.ResetBindings(false);
            }
        }

        private void EditDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit selectedDeposit
                = depositsGridView.SelectedRows[0].DataBoundItem as Deposit;
            if (selectedDeposit != null)
            {
                var depositEditingForm = new DepositEditingForm(
                    usersGridView.SelectedRows[0].DataBoundItem as Customer,
                    selectedDeposit
                );
                DialogResult res = depositEditingForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    isDirty = true;
                }
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
            DialogResult res = conditionsForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                isDirty = true;
            }
        }

        private void CreateDeposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (customer == null)
            {
                return;
            }

            var createDepositForm = new DepositAddingForm(bank, customer);
            DialogResult res = createDepositForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                isDirty = true;
            }
            DepositsBindingSource.ResetBindings(false);
        }

        private void DepositsGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool isNoDeposit = depositsGridView.SelectedRows.Count != 0;
            EnableDepositButtons(isNoDeposit);
        }

        private void UsersGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelectedNull = usersGridView.SelectedRows.Count == 0;
            EnableCustomerButtons(!isSelectedNull);
            if (isSelectedNull)
            {
                DepositsBindingSource.DataSource = new List<Deposit>();
                DepositsBindingSource.ResetBindings(false);
                return;
            }

            Customer selectedCustomer
                = usersGridView.SelectedRows[0].DataBoundItem as Customer;
            if (!isSelectedNull)
            {
                DepositsBindingSource.DataSource = selectedCustomer.Deposits;
                DepositsBindingSource.ResetBindings(false);
            }
            
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Приложение \"Банк\" для администратора.\n" +
                "Автор: Тельной Максим\n" +
                "ПЗПІ-19-4\n2020",
                "О программе",
                MessageBoxButtons.OK
            );
        }
    }
}
