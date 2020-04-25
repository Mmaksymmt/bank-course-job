using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // Customer = login + password + passport data + deposits
    [Serializable]
    class Customer
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public uint AccountNumber { get; set; }
        public string Address { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
    }
}
