using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.model
{
   public abstract class BankAccount
    {
        private decimal moneyAmount;
        private bool isBlocked;
        private int accountNumber;
        private string userName;
        private bool isContributionAllowed;

        public BankAccount()
        {
            MoneyAmount = 0;
            IsBlocked = false;
        }

        public BankAccount(int accountNumber, string userName)
        {
            MoneyAmount = 0;
            IsBlocked = false;
            AccountNumber = accountNumber;
            UserName = userName;
        }

        public BankAccount(decimal moneyAmount, int accountNumber, string userName)
        {
            MoneyAmount = moneyAmount;
            IsBlocked = false;
            AccountNumber = accountNumber;
            UserName = userName;
        }

        public BankAccount(bool isBlocked, int accountNumber, string userName)
        {
            MoneyAmount = 0;
            IsBlocked = isBlocked;
            AccountNumber = accountNumber;
            UserName = userName;
        }

        public BankAccount(decimal moneyAmount, bool isBlocked, int accountNumber, string userName)
        {
            MoneyAmount = moneyAmount;
            IsBlocked = isBlocked;
            AccountNumber = accountNumber;
            UserName = userName;
        }

        public decimal MoneyAmount { get => moneyAmount; set => moneyAmount = value; }
        public bool IsBlocked { get => isBlocked; set => isBlocked = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public bool IsContributionAllowed { get => isContributionAllowed; set => isContributionAllowed = value; }
    }
}
