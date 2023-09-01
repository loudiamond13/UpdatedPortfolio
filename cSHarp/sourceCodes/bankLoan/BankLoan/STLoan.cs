using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankLoan
{
    internal class STLoan : ILoan
    {




        public string Name { get; }
        public string Type { get; }

        public decimal Balance { get; }

        //full arg
        public STLoan(string name, string type, decimal balance)
        {
            Name = name;
            Type = type;
            Balance = balance;

        }

        public decimal ApplyInterest(decimal balance)
        {
            // calculates and add the interest with the balance
            decimal balanceWithInterest = 0m;
            const decimal interestPercent = 0.1m;
            balanceWithInterest = balance * interestPercent;

            balanceWithInterest = balanceWithInterest + balance;

            return balanceWithInterest;

        }

        public decimal MakePayment()
        {
            decimal currentBalance;
            currentBalance = Balance - 450;
            return currentBalance;
        }

        void ILoan.MakePayment()
        {
            throw new NotImplementedException();
        }

        void ILoan.ApplyInterest()
        {
            throw new NotImplementedException();
        }
    }
}
