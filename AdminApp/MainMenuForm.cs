using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Models;

namespace AdminApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            Bank = new MyBank();
        }

        private MyBank Bank;

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.Load();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank.Save();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Сохранить данные перед закрытием?", "Выход", MessageBoxButtons.YesNoCancel
            );
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.OK:
                    Bank.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
