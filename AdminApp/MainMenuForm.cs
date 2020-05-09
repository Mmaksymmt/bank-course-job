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
    }
}
