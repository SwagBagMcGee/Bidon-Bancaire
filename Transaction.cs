using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Transaction
    {
        internal double Amount { get; set; }
        internal DateTime Date { get; set; }
        internal string Notes { get; set; }
        internal Transaction(double amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

    }
}
