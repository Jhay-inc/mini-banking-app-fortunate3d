using BankingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp
{

    public class AccountDetails : UserDetails
    {


        public AccountDetails()
        {
            Console.Write("FirstName: ");
            var firstName = FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            var lastName = LastName = Console.ReadLine();
            Console.Write("Email: ");
            var email = Email = Console.ReadLine();

            if (firstName == "" || lastName == "" || email == "")
            {
                Console.WriteLine("Error in account process, enter correct information");
            }
            else
            {
                UserDetails = new List<UserDetails>()
            {
               new UserDetails()
               {
               FirstName = _firstName,
                   LastName = _lastName,
               BankAccount = new Account(),
               }
            };
            }
        }
        public List<UserDetails>UserDetails { get; set; }
    }
}