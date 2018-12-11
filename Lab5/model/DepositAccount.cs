using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.model
{
    class DepositAccount : BankAccount
    {
        private double percent;
        private DateTime accountOpeningDate;
        private int period;

        public DepositAccount()
        {
        }

        public DepositAccount(double percent, DateTime accountOpeningDate, int period)
        {
            Percent = percent;
            AccountOpeningDate = accountOpeningDate;
            Period = period;
            IsContributionAllowed = false;
        }

        public double Percent { get => percent; set => percent = value; }
        public DateTime AccountOpeningDate { get => accountOpeningDate; set => accountOpeningDate = value; }
        public int Period { get => period; set => period = value; }
    }
}
