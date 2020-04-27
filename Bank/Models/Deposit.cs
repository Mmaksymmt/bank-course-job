using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // 
    [Serializable]
    class Deposit
    {
        public Deposit
        (
            int percent,
            decimal value,
            DateTime startDate
        )
        {
            Percent = percent;
            Value = value;
            StartDate = startDate;
        }

        public int Percent { set; get; }
        public decimal Value { set; get; }
        public DateTime StartDate { set; get; }
        //public Customer Owner;

        protected Deposit() { }
    }
}
