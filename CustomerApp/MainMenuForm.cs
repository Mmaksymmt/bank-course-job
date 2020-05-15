using Bank.Models;
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

        public MainMenuForm(MyBank bank, Customer customer)
        {
            InitializeComponent();
            this.bank = bank;
            currentCustomer = customer;
            welcomeLabel.Text = "Добро пожаловать, " + customer.FullName + "!";
            isLogOut = false;
            depositsBindingSource.DataSource = currentCustomer.Deposits;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Save();
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
                case DialogResult.OK:
                    bank.Save();
                    break;
                case DialogResult.No:
                    break; 
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

        private void uploadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.Charge();
            depositsBindingSource.ResetBindings(false);
        }

        private void depositsGridView_CellFormatting(
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
    }
}
