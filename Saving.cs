using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Saving : Accounts
    {
        //Fields
        public double minBalance;

        //Constructors
        public Saving(string accType, int accNum, double startBalance, double minBalance)
        {
            this.accType = accType;
            this.accNum = accNum;
            this.currentBalance = startBalance;
            this.minBalance = minBalance;
        }

        //Properties

        //Methods
        //Savings Account Information
        public override void AccInfo()
        {
            Console.WriteLine("====== Savings Account Info =======");
            Console.WriteLine(accType + "\n");
            Console.WriteLine("Account Number: " + accNum + "\n");
            Console.WriteLine("Your current balance is: " + currentBalance + "\n");
            Console.WriteLine("Your minimum balance is: " + minBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            Console.WriteLine("===================================");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        //Deposit to Savings Account
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
        //Withdraw from Savings Account
        public override void AccWithdraw()
        {
            Console.WriteLine("========= Withdraw Amount =========");
            withdrawAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance - withdrawAmount;
            if (currentBalance < minBalance)
            {
                currentBalance = currentBalance + withdrawAmount;
                Console.WriteLine("Your Savings Account must retain a balance of at least $200.00.\nPlease choose a lesser amount or cancel transaction.");
                Console.WriteLine("How much would you like to withdraw?");
                withdrawAmount = double.Parse(Console.ReadLine());
                currentBalance = currentBalance - withdrawAmount;
                Console.WriteLine("You have withdrawn $" + withdrawAmount);
                Console.WriteLine("Your new balance is $" + currentBalance);
            }
            else if (currentBalance > 200)
            {
                Console.WriteLine("You have withdrawn $" + withdrawAmount);
                Console.WriteLine("Your new balance is $" + currentBalance + "\n");
                Console.WriteLine("Press ENTER to continue.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }

        }

    }
}
