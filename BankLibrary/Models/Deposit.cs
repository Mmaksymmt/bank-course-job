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
            AccrualsInterval interv,
            int periods
        )
        {
            Percent = percent;
            Value = value;
            Interval = interv;
            StartDate = DateTime.Now;
            LastAccrual = StartDate;
            switch (interv)
            {
                case AccrualsInterval.minute:
                    FinishDate = StartDate.AddMinutes(periods);
                    break;
                case AccrualsInterval.month:
                    FinishDate = StartDate.AddMonths(periods);
                    break;
                case AccrualsInterval.year:
                    FinishDate = StartDate.AddYears(periods);
                    break;
            }
        }

        public Deposit(
            int percent,
            decimal value,
            AccrualsInterval interv,
            DateTime startDate,
            DateTime finishDate
        )
        {
            Percent = percent;
            Value = value;
            Interval = interv;
            if (startDate == DateTime.MinValue)
            {
                startDate = DateTime.Now;
            }
            if (finishDate == DateTime.MaxValue)
            {
                finishDate = startDate.AddMonths(12);
            }
            StartDate = startDate;
            LastAccrual = startDate;
            FinishDate = finishDate;
        }

        public int Percent { set; get; }
        public decimal Value { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime FinishDate { set; get; }
        public DateTime LastAccrual { get; private set; }
        public AccrualsInterval Interval { get; private set; }

        // Calculate and add %
        public void Charge()
        {
            DateTime last = LastAccrual;
            DateTime next = last;
            while (true)
            {
                switch (Interval)
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
                if (next <= DateTime.Now && next <= FinishDate)
                {
                    decimal bonus = Value * Percent / 100;
                    bonus = Math.Round(bonus, 2);
                    Value += bonus;
                    last = next;
                }
                else
                {
                    LastAccrual = last;
                    break;
                }
            }
        }

        // + Money
        public void Put(decimal value)
        {
            if (value <= 0)
            {
                throw new InputException("Value can not 0 or less");
            }
            Value += value;
        }

        // - Money
        public void Withdraw(decimal value)
        {
            if (value <= 0 || value > Value)
            {
                throw new InputException(
                    "Value can not be less than 0 or more than current account"
                );
            }
            Value -= value;
        }

        public void Change(
            int percent,
            decimal value,
            AccrualsInterval interv,
            DateTime startDate,
            DateTime finishDate
        )
        {
            CheckData(percent, value, interv, startDate, finishDate);

            // if no exceptions - change deposit data

            Percent = percent;
            Value = value;
            Interval = interv;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public static void CheckData(
            int percent,
            decimal value,
            AccrualsInterval interv,
            DateTime startDate,
            DateTime finishDate
        )
        {
            if (value <= 0)
            {
                throw new InputException("Сумма не может быть меньше или равна нулю!");
            }
            if (finishDate <= startDate)
            {
                throw new InputException("Неправильная дата окончания!");
            }
        }
    }

    public enum AccrualsInterval { minute, month, year };
}
