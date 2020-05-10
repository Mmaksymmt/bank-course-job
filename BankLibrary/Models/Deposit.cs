using System;
using System.Collections.Generic;
using System.Data;
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
            string owner,
            AccrualsInterval interv,
            DateTime startDate
        )
        {
            Percent = percent;
            Value = value;
            Owner = owner;
            interval = interv;
            if (startDate == DateTime.MinValue)
            {
                startDate = DateTime.Now;
            }
            StartDate = startDate;
            lastAccrual = startDate;
        }

        public Deposit(int percent, decimal value, string owner, AccrualsInterval interv)
            : this(percent, value, owner, interv, DateTime.MinValue)
        {
        }       

        public void Charge()
        {
            DateTime last = lastAccrual;
            DateTime next = last;
            while (true)
            {
                switch (interval)
                {
                    case AccrualsInterval.minute:
                        next = last.AddMinutes(1);
                        break;
                    case AccrualsInterval.month:
                        next = last.AddMonths(1);
                        break;
                    case AccrualsInterval.year:
                        next = last.AddYears(1);
                        break;
                }
                if (next <= DateTime.Now)
                {
                    Value += Value * Percent / 100;
                    last = next;
                }
                else
                {
                    lastAccrual = last;
                    break;
                }
            }
        }

        public void Put(decimal value)
        {
            if (value < 0)
            {
                throw new Exception("Value can not be less than 0");
            }
            Value += value;
        }

        public void Withdraw(decimal value)
        {
            if (value < 0 || value > Value)
            {
                throw new Exception("Value can not be less than 0 or more than current account");
            }
            Value -= value;
        }

        public enum AccrualsInterval { minute, month, year };
        public int Percent { set; get; }
        public decimal Value { set; get; }
        public string Owner { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime lastAccrual { get; private set; }
        public AccrualsInterval interval { get; private set; }
    }
}
