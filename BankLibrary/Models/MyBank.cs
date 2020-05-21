using Bank.DAL;
using BankLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // Main class of model, represents bank
    // Customers + affordable deposit conditions
    [Serializable]
    public class MyBank
    {
        public List<Customer> Customers { private set; get; }
        public List<DepositCondition> DepositConditions { private set; get; }
        [NonSerialized] private readonly Admin admin;

        public MyBank()
        {
            Customers = new List<Customer>();
            DepositConditions = new List<DepositCondition>();
            admin = new Admin("admin", "0000");
        }

        public void Save()
        {
            Dao dao = new Dao(this);
            dao.Save();
        }

        public void Load()
        {
            Dao dao = new Dao(this);
            dao.Load();
            Charge();
        }

        public void FillTestData(int n)
        {
            Dao dao = new Dao(this);
            dao.FillTestData(n);
        }

        public void Charge()
        {
            foreach (Customer cust in Customers)
            {
                foreach (Deposit dep in cust.Deposits)
                {
                    dep.Charge();
                }
            }
        }

        public bool LogInAsAdmin(string login, string password)
        {
            return (login == admin.Login && password == admin.Password);
        }

        public Customer Find(string login)
        {
            foreach (Customer account in Customers)
            {
                if (account.Login == login)
                {
                    return account;
                }
            }
            return null;
        }

        public void RemoveEmptyDeposits(Customer customer)
        {
            for (int i = 0; i < customer.Deposits.Count; i++)
            {
                if (customer.Deposits[i].Value <= 0)
                {
                    customer.Deposits.Remove(customer.Deposits[i]);
                    i--;
                }
            }
        }
    }

    public class InputException : Exception
    {
        public InputException(string message) : base(message)
        { }
    }
}
