using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static ApplicationContext context;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyBank bank = new MyBank();
            try
            {
                bank.Load();
            }
            catch (System.IO.FileNotFoundException)
            {
                DialogResult res = MessageBox.Show(
                    "Невозможно загрузить данные приложения. Продолжить?",
                    "",
                    MessageBoxButtons.YesNo
                );

                // If yes - create new MyBank, serialize
                // If no - close application

                switch (res)
                {
                    case DialogResult.Yes:
                        bank.FillTestData(10);
                        bank.Save();
                        break;
                    case DialogResult.No:
                        return;
                }
            }

            if (context == null)
            {
                context = new ApplicationContext(new LoginForm(bank));
            }

            context = new ApplicationContext(new LoginForm());
            Application.Run(context);
        }
    }
}
