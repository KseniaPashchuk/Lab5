using Lab5.comparer;
using Lab5.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.collection
{
    class UserAccounts
    {
        private List<BankAccount> accounts;

        public UserAccounts()
        {
            this.Accounts = new List<BankAccount>();
        }

        public UserAccounts(List<BankAccount> accounts)
        {
            this.Accounts = accounts;
        }

        public List<BankAccount> Accounts { get => accounts; set => accounts = value; }

        public override bool Equals(object obj)
        {
            var collection = obj as UserAccounts;
            return collection != null &&
                   Accounts.SequenceEqual(collection.Accounts);
        }

        public override int GetHashCode()
        {
            return -687758171 + EqualityComparer<List<BankAccount>>.Default.GetHashCode(Accounts);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (BankAccount acc in Accounts)
            {
                result.Append(acc.ToString());
                result.Append("/n");
            }
            return result.ToString();
        }

        public decimal CalculateAllAccountsSum()
        {
            decimal result = 0;
            foreach (BankAccount acc in Accounts)
            {
                result += acc.MoneyAmount;
            }
            return result;
        }

        public decimal CalculatePositiveAccountsSum()
        {
            decimal result = 0;
            foreach (BankAccount acc in Accounts)
            {
                if (acc.MoneyAmount >= 0)
                {
                    result += acc.MoneyAmount;
                }
            }
            return result;
        }

        public decimal CalculateNegativeAccountsSum()
        {
            decimal result = 0;
            foreach (BankAccount acc in Accounts)
            {
                if (acc.MoneyAmount < 0)
                {
                    result += acc.MoneyAmount;
                }
            }
            return result;
        }

        public BankAccount FindAccountByNumber(int number)
        {
            BankAccount result = null;
            foreach (BankAccount acc in Accounts)
            {
                if (acc.AccountNumber == number)
                {
                    result = acc;
                    break;
                }
            }
            return result;
        }

        public List<BankAccount> SortAccountByNumber(int number)
        {
            List<BankAccount> result = new List<BankAccount>();
            result.AddRange(Accounts);
            result.Sort(new AccountNumberComparer());
            return result;
        }        
    }
}
