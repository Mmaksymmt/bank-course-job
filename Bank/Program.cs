using Bank.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            MyBank bank = new MyBank();
            //bank.FillTestData(10);
            //bank.Save();
            bank.Load();
            Console.WriteLine(bank.Deposits[0].StartDate);

            Application.Run(new Form1());
        }
    }
}
