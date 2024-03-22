using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Student:Account
    {
        public Student(string title, int AccountID, double amount) : base(title, AccountID, amount)
        {

        }
      
        public double WithDrawAmount(double withdrawalAmount)
        {
            return Withdraw(withdrawalAmount);
        }
        public string AmountDeposited(double amount)
           
        {
            if (amount + Amount <= 50000)
            {
                DepositAmount(amount);
                return $"Amount deposited: {Amount}";
            }
            else
            {
                return $"Amount can't be deposited as it exceeds 50,000";
            }
        }
        public string ToStringStudent()
        {
            return ToString();
        }
    }
}
