using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        internal string Number { get; }
        internal string Owner { get; set; }
        internal double Balance
        {
            get
            {
                double balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 0001134;

        private List<Transaction> allTransactions = new List<Transaction>();
        internal BankAccount(string name, double initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
        internal void MakeDeposit(double amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        internal void MakeWithdrawal(double amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal.");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        internal string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmmount\t\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
