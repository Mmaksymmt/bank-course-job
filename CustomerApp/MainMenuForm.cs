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

        public MainMenuForm(MyBank bank, Customer customer)
        {
            InitializeComponent();
            this.bank = bank;
            currentCustomer = customer;
        }
    }
}
