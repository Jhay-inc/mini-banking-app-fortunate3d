using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Account : UserDetails
    {
        public Account(decimal initialDeposit = 0)
        {
            AccountBalance = 1000 + initialDeposit;
            string acctNum = "";
            string firstTwo = "07";
            string nextSix = DateTime.Now.ToString("yyMMdd");

            string LastTwo = new Random().Next(99).ToString().PadLeft(2, '0');
            acctNum = firstTwo + nextSix + LastTwo;

            }
        public string AccountNumber { get; set; }
        public string TransactionPin { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
