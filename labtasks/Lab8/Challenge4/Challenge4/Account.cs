using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Account
    {
        protected string Title;
        protected int ID;
        protected double Amount=300;
        public Account(string title, int iD, double amount)
        {
            Title = title;
            ID = iD;
            Amount = amount;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public string GetTitle()
        {
            return Title ;
        }
        public void SetAmount(double amount)
        {
           Amount = amount;
        }
        public double GetAmount()
        {
            return Amount;
        }
        public string ToString()
        {
            return $"Title: {Title},ID: {ID} ,Amount: {Amount}";
        }
        public double Withdraw(double withdrawalAmount)
        {
            Amount = Amount - withdrawalAmount;
            return GetAmount();
        }
        public double DepositAmount(double depositedAmount)
        {
            Amount = Amount+ depositedAmount;
            return GetAmount();
        }

    }

}
