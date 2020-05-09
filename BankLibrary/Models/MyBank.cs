using Bank.DAL;
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
        public MyBank()
        {
            Customers = new List<Customer>();
            Deposits = new List<Deposit>();
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
        }

        public void FillTestData(int n)
        {
            Dao dao = new Dao(this);
            dao.FillTestData(n);
        }

        public List<Customer> Customers { private set; get; }
        public List<Deposit> Deposits { private set; get; }
    }
}
