using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    public class Account : IAccount
    {
        private string balance;

        public int Balance { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }

        public Account(string firstName, string lastName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Balance = 0;
        }
        public void PayInto()
        {
            Console.WriteLine("Balance: {0}", Balance);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {AccountId}\nFirst name: {FirstName}\nLast name: {LastName}\nGender: {Gender}\nBalance: {Bace}");
        }
    }
}
