using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to ATM machine ");
            int currentbalance = 700000;
         
           ATM  machine = new ATM(currentbalance);
            machine.currentbalance();
            machine. deposit();
            machine.deposit();
            machine.currentbalance();
             machine.withdrawal();
            machine.withdrawal();
            machine.currentbalance();
            machine.seehistory();
            Console.ReadKey();
        }
       
    }
}
