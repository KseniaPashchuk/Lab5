using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.model
{
    class SavingAccount : BankAccount
    {
        private double percentPerMonth;
        private DateTime accountOpeningDate;

        public SavingAccount()
        {
        }

        public SavingAccount(double percentPerMonth, DateTime accountOpeningDate)
        {
            PercentPerMonth = percentPerMonth;
            AccountOpeningDate = accountOpeningDate;
            IsContributionAllowed = true;
        }

        public double PercentPerMonth { get => percentPerMonth; set => percentPerMonth = value; }
        public DateTime AccountOpeningDate { get => accountOpeningDate; set => accountOpeningDate = value; }
    }
}
