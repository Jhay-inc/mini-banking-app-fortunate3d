using BankingApp;
using System;
using System.Linq;
using System.Security.Principal;

namespace BankingApp
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("1: Enter Your name below: (FirstName) and (LastName)");
            Console.WriteLine("2: Set your password");
            Console.WriteLine("3: Set your pin");
            Console.WriteLine("4: Enter Your email address");
            AccountDetails accountDetails = new AccountDetails();
            Account account = new Account();
            while (true)
            {
                string number = Console.ReadLine();
                var user = accountDetails.UserDetails.Where(u => u.BankAccount.AccountNumber == number).FirstOrDefault();
                Console.WriteLine($"User with name {user.FirstName} {user.LastName} has {user.BankAccount.AccountBalance}");
            }
        }
    }
}
