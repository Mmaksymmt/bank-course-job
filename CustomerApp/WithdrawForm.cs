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
    // Returns DialogResult.OK, if operation occured
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            deposit.Value -= valueUpDown.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
