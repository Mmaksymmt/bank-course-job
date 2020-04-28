using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // 
    class MyBank
    {
        public MyBank()
        {
            Customers = new List<Customer>();
            Deposits = new List<Deposit>();
        }

        public List<Customer> Customers { private set; get; }
        public List<Deposit> Deposits { private set; get; }

        public void Save()
        {
            SaveCustomers();
            SaveDeposits();
        }

        public void FillTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Customers.Add
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
                    Deposits.Add
                    (
                        new Deposit(5, 500.50m, Customers[i], DateTime.Now)
                    );
                }
                else
                {
                    DateTime expiration = DateTime.Now;
                    expiration.AddMonths(i);
                    Deposits.Add
                    (
                        new TermDeposit(5, 500.50m, Customers[i], DateTime.Now, expiration)
                    );
                }
            }
        }

        public void SaveCustomers()
        {
            using (StreamWriter stream = new StreamWriter("customers.txt"))
            {
                stream.WriteLine(Customers.Count);
                foreach (Customer c in Customers)
                {
                    stream.WriteLine(c.Login);
                    stream.WriteLine(c.Password);
                    stream.WriteLine(c.FullName);
                }
            }
        }

        public void SaveDeposits()
        {
            using (StreamWriter stream = new StreamWriter("deposits.txt"))
            {
                stream.WriteLine(Deposits.Count);
                foreach (Deposit d in Deposits)
                {
                    stream.WriteLine(d.Owner.Login);
                    stream.WriteLine(d.Percent);
                    stream.WriteLine(d.StartDate);
                    stream.WriteLine(d.Value);
                }
            }
        }
    }
}
