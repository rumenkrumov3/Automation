using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using SeleniumBasicDemo;
using System;
using System.Text.RegularExpressions;

namespace NUnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAcount account;
        
        [SetUp]
        public void Setup()
        {
            this.account = new BankAcount(1000);
            
        }     
        [Test]
        public void BankAccountHaveCorrectAmount_When_Deposit()
        {
            #region TestStart
            this.account = new BankAcount(1100);
            account.Deposit(200);
            Assert.AreEqual(1300, account.Amount);
            #endregion TestEnd
        }
        [Test]
        public void ExceptionIsThrown_When_DepositNegativeValue()
        {
            #region TestStart
            this.account = new BankAcount(1100);          
            Assert.Throws<ArgumentException>(() => account.Deposit(-2000));
            #endregion TestEnd
        }
        [Test]
        public void BankAccountHaveCorrectAmount_When_DepositZero()
        {
            #region TestStart
            this.account = new BankAcount(1100);
            decimal amount = account.Amount;
            account.Deposit(0);
            Assert.AreEqual(amount, account.Amount);
            #endregion TestEnd
        }
        [Test]
        public void BankAccountAmount_When_WindrawUnder1000()
        {
            #region TestStart
            this.account = new BankAcount(1100);
            decimal Amount = account.Amount;
            decimal withrawAmount = 500;
            decimal expectedWithraw = withrawAmount + (withrawAmount * 0.05m);
            account.Withdraw(withrawAmount);
            Assert.AreEqual(Amount, account.Amount + expectedWithraw);
            #endregion TestEnd
        }
        [Test]
        public void BankAccountAmount_When_WindrawAbove1000()
        {
            #region TestStart
            this.account = new BankAcount(1500);
            decimal Amount = account.Amount;
            decimal withrawAmount = 1100;
            decimal expectedWithraw = withrawAmount + (withrawAmount * 0.02m);
            account.Withdraw(withrawAmount);
            Assert.AreEqual(Amount, account.Amount + expectedWithraw);
            #endregion TestEnd
        }
        [Test]
        public void ExceptionIsThrown_When_WithrawWithNegativeValue()
        {
            #region TestStart
            this.account = new BankAcount(1100);
            Assert.Throws<ArgumentException>(() => account.Withdraw(-2000));
            #endregion TestEnd

        }
        [Test]
        public void ExceptionIsThrown_When_WithrawMoreThatWeHave()
        {
            #region TestStart
            this.account = new BankAcount(1100);
            Assert.Throws<ArgumentException>(() => account.Withdraw(1200));
            #endregion TestEnd
        }
    }
}