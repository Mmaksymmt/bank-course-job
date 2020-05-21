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
    // Returns DialogResult.OK, if changed data
    public partial class DepositConditionsForm : Form
    {
        private MyBank bank;
        private bool isDirty;

        public DepositConditionsForm(MyBank bank)
        {
            InitializeComponent();
            this.bank = bank;
            conditionsBindingSource.DataSource = this.bank.DepositConditions;
            isDirty = false;
        }

        private void EnableButtons(bool value)
        {
            editButton.Enabled = value;
            deleteButton.Enabled = value;
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
            isDirty = true;
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
            DialogResult res = condEditForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                isDirty = true;
            }
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
            DialogResult res = editForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                isDirty = true;
            }
            conditionsBindingSource.ResetBindings(false);
        }

        private void ConditionsGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool isSelectedNull = conditionsGridView.SelectedRows.Count == 0;
            EnableButtons(!isSelectedNull);
        }

        private void DepositConditionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
