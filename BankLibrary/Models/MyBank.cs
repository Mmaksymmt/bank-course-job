﻿using Bank.DAL;
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
    // 
    [Serializable]
    public class MyBank
    {
        public List<Customer> Customers { private set; get; }
        [NonSerialized] private readonly Admin admin;

        public MyBank()
        {
            Customers = new List<Customer>();
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

        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void RemoveDeposit(Customer customer, Deposit deposit)
        {
            customer.Deposits.Remove(deposit);
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
    }
}
