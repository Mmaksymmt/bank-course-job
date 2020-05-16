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

namespace Common_Forms
{
    public partial class DepositAddingForm : Form
    {
        private MyBank bank;
        private Customer customer;

        public DepositAddingForm(MyBank bank, Customer customer)
        {
            InitializeComponent();
            this.bank = bank;
            this.customer = customer;
            conditionsComboBox.DataSource = bank.DepositConditions;
            conditionsComboBox.DisplayMember = "InfoString";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var condition = conditionsComboBox.SelectedItem as DepositCondition;
            customer.Deposits.Add(
                new Deposit(
                    condition.Percent,
                    valueUpDown.Value,
                    condition.Interval,
                    condition.Duration
                )
            );
            Close();
        }
    }
}
