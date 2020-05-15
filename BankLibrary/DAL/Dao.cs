using Bank.Models;
using BankLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DAL
{
    class Dao
    {
        private readonly MyBank Bank;
        [NonSerialized] private const string FILE_PATH = "BankData.bin";


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
                        $"Жмышенко Валерий Альбертович",
                        i.ToString(),
                        $"address{i}",
                        new DateTime(1900, 1, 1).AddDays(i)
                    )
                );

                for (int j = 0; j < 4; j++)
                {
                    Bank.Customers[i].Deposits.Add
                     (
                         new Deposit(
                             5 + j,
                             500.50m * j,
                             AccrualsInterval.minute, j % 10 + 10
                         )
                     );
                }

                Bank.DepositConditions.Add(
                    new DepositCondition(
                        i + 1,
                        (AccrualsInterval)(i % 3),
                        i + 2
                    )
                );
            }
        }
    }
}
