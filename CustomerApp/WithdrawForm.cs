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
    public partial class WithdrawForm : Form
    {
        private Deposit deposit;

        public WithdrawForm(Deposit deposit)
        {
            InitializeComponent();
            this.deposit = deposit;
            valueUpDown.Maximum = deposit.Value;
            valueUpDown.Value = deposit.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            deposit.Value -= valueUpDown.Value;
            Close();
        }
    }
}
