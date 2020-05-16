using Bank.Models;
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
    public partial class CustomerInfoFormCustomer : CustomerInfoForm
    {
        public CustomerInfoFormCustomer(Customer customer, MyBank bank)
            : base(customer, bank)
        {
            loginLabel.Visible = false;
            loginTextBox.Visible = false;
        }
    }
}
