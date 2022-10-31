using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingApp
{
    public class UserDetails
    { 
        public string _firstName;
        public string _lastName;
        public string _email;
        public string _password;
        public string _pin;
        public string _bankAccount;

        public string FirstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return _lastName;
                }
                set
                {
                    _lastName = value;
                }
            }

            public string Email { get; set; }
            public string Password { get; set; }
            public string TranasactionPin { get; set; }
            public string Number { get; set; }
            public Account BankAccount { get; set; }

       
    }

}
