using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.domain
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            Balance = 0.00M;
        }
    }
}
