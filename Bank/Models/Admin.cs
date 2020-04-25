using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // Admin = login + password
    [Serializable]
    class Admin
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}
