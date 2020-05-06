using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // 
    [Serializable]
    public class Deposit
    {
        public Deposit
        (
            int percent,
            decimal value,
            Customer owner,
            DateTime startDate
        )
        {
            Percent = percent;
            Value = value;
            Owner = owner;
            StartDate = startDate;
        }

        public int Percent { set; get; }
        public decimal Value { set; get; }
        public Customer Owner { set; get; }
        public DateTime StartDate { set; get; }
    }
}
