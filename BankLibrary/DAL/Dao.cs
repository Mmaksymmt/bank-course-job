using Bank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Bank.DAL
{
    class Dao
    {
        public Dao(MyBank bank)
        {
            Bank = bank;
        }

        public void Save()
        {
            using (Stream stream = File.Create(FILE_PATH))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, Bank);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(FILE_PATH))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                MyBank tmp = (MyBank)serializer.Deserialize(stream);
                Copy(tmp.Customers, Bank.Customers);
                Copy(tmp.Deposits, Bank.Deposits);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }

        public void FillTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Bank.Customers.Add
                (
                    new Customer
                    (
                        $"login{i}",
                        $"password{i}",
                        $"name{i}",
                        (uint)i,
                        $"address{i}",
                        1900 + i,
                        i % 12 + 1,
                        i % 31 + 1
                    )
                );
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Bank.Deposits.Add
                    (
                        new Deposit(5, 500.50m, Bank.Customers[i], DateTime.Now)
                    );
                }
                else
                {
                    DateTime expiration = DateTime.Now;
                    expiration = expiration.AddMonths(i);
                    Bank.Deposits.Add
                    (
                        new TermDeposit(5, 500.50m, Bank.Customers[i], DateTime.Now, expiration)
                    );
                }
            }
        }

        private readonly MyBank Bank;
        [NonSerialized] private const string FILE_PATH = "BankData.bin";
    }
}
