using Bank.Models;
using BankLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class DepositConditionsForm : Form
    {
        private MyBank bank;

        public DepositConditionsForm(MyBank bank)
        {
            InitializeComponent();
            this.bank = bank;
            conditionsBindingSource.DataSource = this.bank.DepositConditions;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (conditionsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult res = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }
            DepositCondition condition =
                conditionsGridView.SelectedRows[0].DataBoundItem as DepositCondition;
            bank.DepositConditions.Remove(condition);
            conditionsBindingSource.ResetBindings(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (conditionsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var condition =
                conditionsGridView.SelectedRows[0].DataBoundItem as DepositCondition;
            var condEditForm = new ConditionEditingForm(bank, condition, false);
            condEditForm.ShowDialog();
            conditionsBindingSource.ResetBindings(false);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DepositCondition condition = new DepositCondition(
                10,
                AccrualsInterval.month,
                12
            );
            var editForm = new ConditionEditingForm(bank, condition, true);
            editForm.ShowDialog();

            conditionsBindingSource.ResetBindings(false);
        }
    }
}
