using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.domain
{
    public class Customer
    {
        #region Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public BankAccount Account { get; private set; }
        public Gender Gender { get; private set; }

        #endregion
        public Customer(string firstName, string lastName, string accountNumber, Gender gender=Gender.Unknown)
        {  
            LastName = lastName??throw new ArgumentNullException(nameof(firstName));
            FirstName = firstName?? throw new ArgumentNullException(nameof(lastName));
            Account = new BankAccount(accountNumber);
            Gender = gender;
        }
        #region Overrriden
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        #endregion
    }
}
