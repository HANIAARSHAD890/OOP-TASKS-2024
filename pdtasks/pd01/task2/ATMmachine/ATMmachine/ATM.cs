using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMmachine
{
    internal class ATM
    {
        public float balance;

        public List<string> transaction = new List<string>();
        public ATM(int currentbalance)
        {
            balance =currentbalance;
        }
       
     
 
        public int deposit()
          {

          Console.WriteLine("1.What balance you wanted to deposit?");
           int input = int.Parse(Console.ReadLine());
            balance = balance + input;
        transaction.Add($"balance deposited{balance}");
            return 0;


    }
        public void  seehistory()
        {
            for (int i=0;i<transaction.Count;i++) {

                Console.WriteLine(transaction[i]);
            }
          

        }
        public void withdrawal()
        {
            Console.WriteLine("1.How many rupees you wanted to withdrawal?");
            int input = int.Parse(Console.ReadLine());
            balance = balance - input;
            transaction.Add($"balance withdrawal {input}");
            Console.WriteLine($"balance left {balance}");


        }
        public void currentbalance()
        {
            Console.WriteLine($"current balance {balance}");
        }
    }
}



