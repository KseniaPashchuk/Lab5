using Lab5.model;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        private BankAccount depositAccount;
        private BankAccount savingAccount;

        [SetUp]
        public void Setup()
        {
            depositAccount = new DepositAccount(100, 12345, "Vasya", 2, 2.1);
            savingAccount = new SavingAccount(100, 12345, "Vasya", 3);
        }

        [Test]
        public void Test_DepositReplenishment()
        {
            try
            {
                depositAccount.ReplenishAmount(100);
            }
            catch (NotSupportedException ex)
            {
                Assert.AreEqual("For this type of account replenishment is not allowed", ex.Message);
            }
            catch (Exception ex)
            {
                // not the right kind of exception
                Assert.Fail();
            }
        }

        [Test]
        public void Test_DepositWitdraw()
        {
            try
            {
                depositAccount.WithdrawAmount(30);
            }
            catch (NotSupportedException ex)
            {
                Assert.AreEqual("For this type of account withdrawal is not allowed", ex.Message);
            }
            catch (Exception ex)
            {
                // not the right kind of exception
                Assert.Fail();
            }
        }

        [Test]
        public void Test_SavingWitdraw()
        {
            savingAccount.WithdrawAmount(30);
            decimal expectedAmount = 70;
            Assert.AreEqual(expectedAmount, savingAccount.MoneyAmount);
        }

        [Test]
        public void Test_SavingWitdraw_Negative()
        {
            try
            {
                savingAccount.WithdrawAmount(15000);
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Sorry, you cannot withdraw more than you have", ex.Message);
            }
            catch (Exception ex)
            {
                // not the right kind of exception
                Assert.Fail();
            }
        }

        [Test]
        public void Test_SavingReplenishment()
        {
            savingAccount.ReplenishAmount(30);
            decimal expectedAmount = 130;
            Assert.AreEqual(expectedAmount, savingAccount.MoneyAmount);
        }

        [Test]
        public void Test_AccountBlocking()
        {
            savingAccount.BlockAccount();
            bool expectedBlocking = true;
            Assert.AreEqual(expectedBlocking, savingAccount.IsBlocked);
        }
    }
}