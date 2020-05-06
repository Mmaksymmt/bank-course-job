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
    }
}
