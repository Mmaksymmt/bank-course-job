using Bank.Models;
using Common_Forms;
using CommonForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApp
{
    public partial class MainMenuForm : Form
    {
        private MyBank bank;
        private Customer currentCustomer;
        private bool isLogOut;
        private bool isDirty;

        public MainMenuForm(MyBank bank, Customer customer)
        {
            InitializeComponent();
            EnableDepositButtons(false);
            this.bank = bank;
            currentCustomer = customer;
            welcomeLabel.Text = "Добро пожаловать, " + customer.FullName + "!";
            isLogOut = false;
            isDirty = false;

            foreach (Deposit depos in customer.Deposits)
            {
                depos.Charge();
            }
            depositsBindingSource.DataSource = currentCustomer.Deposits;
        }

        private void EnableDepositButtons(bool value)
        {
            putToolStripMenuItem.Enabled = value;
            withdrawToolStripMenuItem.Enabled = value;
            putButton.Enabled = value;
            withdrawButton.Enabled = value;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Save();
            isDirty = false;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Load();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult res = MessageBox.Show(
                    "Выйти и сохранить?",
                    "",
                    MessageBoxButtons.YesNoCancel
                );
                switch (res)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        isLogOut = false;
                        return;
                    case DialogResult.Yes:
                        bank.Save();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            if (isLogOut)
            {
                Program.context.MainForm = new LoginForm(bank);
                Program.context.MainForm.Show();
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogOut = true;
            Close();
        }

        private void UploadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Charge();
            depositsBindingSource.ResetBindings(false);
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
                row.DefaultCellStyle.BackColor = depositsGridView.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.SelectionBackColor
                    = depositsGridView.DefaultCellStyle.SelectionBackColor;
                row.DefaultCellStyle.SelectionForeColor
                    = depositsGridView.DefaultCellStyle.SelectionForeColor;
            }
        }

        private void PrivateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerEditForm = new CustomerInfoFormCustomer(currentCustomer, bank);
            customerEditForm.ShowDialog();
            isDirty = true;
            welcomeLabel.Text = "Добро пожаловать, " + currentCustomer.FullName + "!";
        }

        private void AddDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var depositAddingForm = new DepositAddingForm(bank, currentCustomer);
            depositAddingForm.ShowDialog();
            isDirty = true;
            depositsBindingSource.ResetBindings(false);
        }

        private void PutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit deposit =
                depositsGridView.SelectedRows[0].DataBoundItem as Deposit;
            deposit.Charge();
            var putForm = new PutForm(deposit);
            putForm.ShowDialog();
            isDirty = true;
            depositsBindingSource.ResetBindings(false);
        }

        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit deposit =
                depositsGridView.SelectedRows[0].DataBoundItem as Deposit;
            deposit.Charge();
            var withdrawForm = new WithdrawForm(deposit);
            withdrawForm.ShowDialog();
            bank.RemoveEmptyDeposits(currentCustomer);
            isDirty = true;
            depositsBindingSource.ResetBindings(false);
        }

        private void DepositsGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelectedNull = depositsGridView.SelectedRows.Count == 0;
            EnableDepositButtons(!isSelectedNull);
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Приложение \"Банк\" для пользователей.\n" +
                "Автор: Тельной Максим\n" +
                "ПЗПІ-19-4\n2020",
                "О программе",
                MessageBoxButtons.OK
            );
        }
    }
}
