using Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class DepositEditingForm : Form
    {
        private Customer customer;
        private Deposit deposit;
        private bool isInputChanged;

        public DepositEditingForm(Customer customer, Deposit depos)
        {
            InitializeComponent();
            nameLabel.Text = "Ф.И.О.: " + customer.FullName;
            deposit = depos;
            percentUpDown.Value = depos.Percent;
            valueUpDown.Value = deposit.Value;
            finishDatePicker.Value = deposit.FinishDate;
            finishTimeHoursUpDown.Value = deposit.FinishDate.Hour;
            finishTimeMinutesUpDown.Value = deposit.FinishDate.Minute;

            saveButton.Enabled = false;
            isInputChanged = false;
        }

        // Saves new data, returns true if changed
        private bool Save()
        {
            DateTime newFinishDate = new DateTime(
                finishDatePicker.Value.Year,
                finishDatePicker.Value.Month,
                finishDatePicker.Value.Day,
                (int)finishTimeHoursUpDown.Value,
                (int)finishTimeMinutesUpDown.Value,
                deposit.FinishDate.Second
            );
            try
            {
                deposit.Change(
                    (int)percentUpDown.Value,
                    valueUpDown.Value,
                    deposit.Interval,
                    deposit.StartDate,
                    newFinishDate
                );
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void InputsValueChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            isInputChanged = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DepositEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isInputChanged)
            {
                var res = MessageBox.Show(
                    "Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel
                );

                switch (res)
                {
                    case DialogResult.OK:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
            isInputChanged = false;
            saveButton.Enabled = false;
        }
    }
}
