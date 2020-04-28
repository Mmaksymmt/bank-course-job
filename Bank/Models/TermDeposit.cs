using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    // 
    [Serializable]
    class TermDeposit : Deposit
    {
        public TermDeposit
        (
            int percent,
            decimal value,
            Customer owner,
            DateTime startDate, 
            DateTime expirationDate
        )
        {
            Percent = percent;
            Value = value;
            Owner = owner;
            StartDate = startDate;
            ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; set; }
    }
}
