using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    public class AccountList
    {
        private static int iDCount = 1;
        public static List<Account> accounts = new List<Account>();

        public static void CreateAccount()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter gender: (male/female) ");
            string gender = Console.ReadLine();

            Account account = new Account(firstName, lastName, gender);
            account.AccountId = iDCount++;
            accounts.Add(account);
        }
        public static void PayInto()
        {
            foreach (var item in accounts)
            {
                item.PayInto();
            }
        }
        public static void ShowData()
        {
            foreach (var item in accounts)
            {
                item.ShowInfo();
                Console.WriteLine("---------------");
            }
        }

    }
}
