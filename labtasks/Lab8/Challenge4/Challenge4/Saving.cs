using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Saving : Account
    {
        public Saving(string title, int AccountID, double amount) : base(title, AccountID, amount)
        {
        }
        public double Profitcalculator(double amount)
        {
            return amount * 0.1;
        }
        public double WithDrawAmount(double withdrawalAmount)
        { 
                double amount = (Withdraw(withdrawalAmount));
               double profit = Profitcalculator(withdrawalAmount);
                Amount = Amount - profit;
                return amount;

           
        }
        public string AmountDeposited(double amount)

        {
            DepositAmount(amount);
            return $"Amount deposited: {Amount}";
        }
        public string ToStringSaving()
        {
            return ToString();
        }
    }
}
