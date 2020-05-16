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

namespace AdminApp
{
    public partial class CustomerInfoFormAdmin : CustomerInfoForm
    {
        public CustomerInfoFormAdmin(Customer customer, MyBank bank)
            : base(customer, bank)
        {
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
        }
    }
}
