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
    public partial class ConditionEditingForm : Form
    {
        private DepositCondition condition;
        private MyBank bank;
        private bool isCreating;

        public ConditionEditingForm(
            MyBank bank,
            DepositCondition condition,
            bool isCreating)
        {
            InitializeComponent();
            this.bank = bank;
            this.condition = condition;
            this.isCreating = isCreating;
            intervalComboBox.DataSource = Enum.GetValues(typeof(AccrualsInterval));

            intervalComboBox.SelectedItem = condition.Interval;
            percentUpDown.Value = condition.Percent;
            durationUpDown.Value = condition.Duration;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            // Searching for existing similar condition

            foreach (DepositCondition x in bank.DepositConditions)
            {
                if (x.Percent == (int)percentUpDown.Value
                    && x.Interval == (AccrualsInterval)intervalComboBox.SelectedItem
                    && x.Duration == (int)durationUpDown.Value)
                {
                    Close();
                    MessageBox.Show("Такое условие уже существует.");
                    return;
                }
            }

            condition.Percent = (int)percentUpDown.Value;
            condition.Interval = (AccrualsInterval)intervalComboBox.SelectedItem;
            condition.Duration = (int)durationUpDown.Value;

            if (isCreating)
            {
                bank.DepositConditions.Add(condition);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
