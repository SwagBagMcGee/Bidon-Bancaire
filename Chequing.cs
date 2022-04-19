using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Chequing : Accounts
    {
        //constructors
        public Chequing(string accType, int accNum, double startBalance)
        {
            this.accType = accType;
            this.accNum = accNum;
            this.currentBalance = startBalance;
        }

        //Methods
        //account info
        public override void AccInfo()
        {
            Console.WriteLine("===== Chequings Account Info ======");
            Console.WriteLine(accType + "\n");
            Console.WriteLine("Account Number: " + accNum + "\n");
            Console.WriteLine("Your current balance is: " + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            Console.WriteLine("===================================");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }

        //deposit
        public override void AccDeposit()
        {
            Console.WriteLine("========= Deposit Amount ==========");
            depositAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance + depositAmount;
            Console.WriteLine("===================================");
            Console.WriteLine("Your deposit of $" + depositAmount + " has been accepted.");
            Console.WriteLine("Your new balance is $" + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            Console.WriteLine("===================================");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }

        //withdraw
        public override void AccWithdraw()
        {
            Console.WriteLine("========= Withdraw Amount =========");
            withdrawAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance - withdrawAmount;
            Console.WriteLine("You have withdrawn $" + withdrawAmount);
            Console.WriteLine("Your new balance is $" + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
