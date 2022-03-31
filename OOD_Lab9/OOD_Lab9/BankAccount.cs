using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Lab9
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public decimal OverdraftLimit { get; set; }

        /// <summary>
        /// Deposits a given amount into the account balance.
        /// </summary>
        /// <param name="amount"></param>
        public void DepositAmount(decimal amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// Withdraws a given amount from the account Balance.
        /// </summary>
        /// <param name="amount"></param>
        public void WithdrawAmount(decimal amount)
        {
            decimal availableFunds = Balance + OverdraftLimit;

            //Check there are sufficient funds
            if (amount <= availableFunds)
            {
                Balance -= amount;
            }
        }



    }
}
