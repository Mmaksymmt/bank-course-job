using Bank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary.Models
{
    //
    [Serializable]
    public class DepositCondition
    {
        public DepositCondition(
            int percent,
            AccrualsInterval interval,
            int duration
        )
        {
            Percent = percent;
            Interval = interval;
            Duration = duration;
        }

        public int Percent { get; set; }
        public AccrualsInterval Interval { get; set; }
        public int Duration { get; set; }
    }
}
