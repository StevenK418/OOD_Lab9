using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using BankAccountTestProject;
using OOD_Lab9;

namespace BankAccountTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the BankAccount's deposit method and resultant balance
        /// using a given amount.
        /// </summary>
        [TestMethod]
        public void TestDeposit()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            decimal expectedBalance = 200m;

            //Act
            b1.DepositAmount(200m);

            //Assert
            Assert.AreEqual(expectedBalance, b1.Balance);
        }


        /// <summary>
        /// Tests the BankAccount's deposit method and resultant balance
        /// using multiple amounts.
        /// </summary>
        [TestMethod]
        public void TestMultipleDeposits()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            decimal expectedBalance = 200m;

            //Act
            b1.DepositAmount(200m);
            b1.DepositAmount(60m);
            b1.DepositAmount(40m);

            //Assert
            Assert.AreEqual(expectedBalance, b1.Balance);
        }

        /// <summary>
        /// Tests the BankAccount's balance is zero when
        /// a new instance has been initialized. 
        /// </summary>
        [TestMethod]
        public void TestNewAccountHasZeroBalance()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            decimal expectedBalance = 0m;

            //Act
            
            //Assert
            Assert.AreEqual(expectedBalance, b1.Balance);
        }

        /// <summary>
        /// Tests the BankAccount withdrawal method when account
        /// has sufficient funds for withdrawal amount. 
        /// </summary>
        [TestMethod]
        public void TestWithdrawSufficientFunds()
        {
            //Arrange
            BankAccount b1 = new BankAccount();
            b1.DepositAmount(200m);
            decimal expectedBalance = 100m;

            //Act
            b1.WithdrawAmount(100m);

            //Assert
            Assert.AreEqual(expectedBalance, b1.Balance);
        }
    }
}
