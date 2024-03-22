using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Sallary: Account
    {

      public Sallary(string title,int AccountID,double Amount): base(title,AccountID,Amount)
        {
        }
        public double Taxcalculator(double amount)
        {
            return 0.17 * amount;
        }
        public double WithDrawAmount(double withdrawalAmount)
        {
            double amount = (Withdraw(withdrawalAmount));/// amount after withdraw
            double taxamount = Taxcalculator(withdrawalAmount);///tqx calculated on withdrawalamount

            Amount =  Amount-taxamount;
            return amount;  

        }
        public string AmountDeposited(double amount)

        {
            DepositAmount(amount);
            return $"Amount deposited: {Amount}";
        }
        public string ToStringSallary()
        {
            return ToString();
        }

    }
}
