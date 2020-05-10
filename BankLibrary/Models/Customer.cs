using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // Customer = login + password + passport data + deposits
    [Serializable]
    public class Customer
    {
        public Customer(
            string login,
            string password,
            string fullName,
            uint accountNumber,
            string address,
            int bYear,
            int bMonth,
            int bDay
        )
        {
            Login = login;
            Password = password;
            FullName = fullName;
            AccountNumber = accountNumber;
            Address = address;
            BirthYear = bYear;
            BirthMonth = bMonth;
            BirthDay = bDay;
            Deposits = new List<Deposit>();
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public uint AccountNumber { get; set; }
        public string Address { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public List<Deposit> Deposits { get; private set; }
    }
}
