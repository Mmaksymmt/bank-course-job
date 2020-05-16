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
    public partial class PutForm : Form
    {
        private Deposit deposit;

        public PutForm(Deposit deposit)
        {
            InitializeComponent();
            this.deposit = deposit;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            deposit.Value += valueUpDown.Value;
            Close();
        }
    }
}
