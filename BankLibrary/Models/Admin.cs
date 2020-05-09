using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // Admin = login + password
    [Serializable]
    public class Admin
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
