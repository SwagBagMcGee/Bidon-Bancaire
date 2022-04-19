using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Accounts : Client
    {
        //Fields
        protected string accType;
        protected int accNum;
        protected double startBalance;
        protected double currentBalance;
        protected double depositAmount;
        protected double withdrawAmount;

        //Properties
        public string AccType
        {
            get { return this.accType; }
            set { this.accType = value; }
        }
        public int AcctNum
        {
            get { return this.accNum; }
            set { this.accNum = value; }
        }
        public double StartBalance
        {
            get { return startBalance; }
            set { startBalance = value; }
        }
        public double CurrentBalance
        {
            get { return this.currentBalance; }
            set { this.currentBalance = value; }
        }
        public double DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }
        public double WithdrawAmount
        {
            get { return this.withdrawAmount; }
            set { this.withdrawAmount = value; }
        }

        //Constructors
        public Accounts()
        {

        }
        public Accounts(string accType, int accNum, double startBalance)
        {
            this.accType = accType;
            this.accNum = accNum;
            this.startBalance = startBalance;
        }

        //Methods
        public virtual void AccInfo()
        {

        }
        public abstract void AccDeposit();
        public abstract void AccWithdraw();
    }
}
