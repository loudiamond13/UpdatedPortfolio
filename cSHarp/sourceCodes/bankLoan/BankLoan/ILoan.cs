using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan
{
    public interface ILoan
    {
        string Name { get; }

        string Type { get; }

        decimal Balance { get; }

        void MakePayment();

        void ApplyInterest();

    }
}
