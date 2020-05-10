using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Models;

namespace BankTest
{
    [TestClass]
    public class MyBankTest
    {
        [TestMethod]
        public void FillData()
        {
            MyBank bank = new MyBank();
            const int TEST_VALUE = 10000;
            bank.FillTestData(TEST_VALUE);
            for (int i = 0; i < TEST_VALUE; i++)
            {
                Assert.AreEqual(500.50m, bank.Deposits[i].Value);
                Assert.AreEqual($"login{i}", bank.Customers[i].Login);
            }
        }

        [TestMethod]
        public void Charge()
        {
            Deposit deposit1 = new Deposit(
                10, 1000, "User", Deposit.AccrualsInterval.month, DateTime.Now.AddMonths(0)
            );
            deposit1.Charge();
            Assert.AreEqual(1000, deposit1.Value);
            Deposit deposit2 = new Deposit(
                10, 1000, "User", Deposit.AccrualsInterval.minute, DateTime.Now.AddMinutes(-2.5)
            );
            Assert.IsTrue(deposit2.lastAccrual == deposit2.StartDate);
            deposit2.Charge();
            Assert.AreEqual(1210, deposit2.Value);
            Assert.IsTrue(deposit2.lastAccrual != deposit2.StartDate
                && deposit2.lastAccrual <= DateTime.Now);
        }

        [TestMethod]
        public void Put()
        {
            Deposit deposit = new Deposit(
                10, 1000, "User", Deposit.AccrualsInterval.minute, DateTime.Now.AddMinutes(0)
            );
            deposit.Put(100.50m);
            Assert.AreEqual(1100.50m, deposit.Value);
        }

        [TestMethod]
        public void Withdraw()
        {
            Deposit deposit = new Deposit(
                10, 1000, "User", Deposit.AccrualsInterval.minute, DateTime.Now.AddMinutes(0)
            );
            deposit.Withdraw(999.50m);
            Assert.AreEqual(0.50m, deposit.Value);
        }
    }
}
