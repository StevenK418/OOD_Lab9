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
    }
}
