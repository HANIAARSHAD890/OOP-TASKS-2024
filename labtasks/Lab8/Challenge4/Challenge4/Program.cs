using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = 0;
            double withdraw  = 0;
            Student s = new Student("StudentAccount", 132, 300);
            Saving  save = new Saving("SavingAccount", 890, 400);
           Sallary sal = new Sallary("SallaryAccount", 567, 100);
            Console.WriteLine("FOR StudentAccount");
            Console.WriteLine("Amount u wanted to deposit");
             deposit =double.Parse(Console.ReadLine());
            s.AmountDeposited(deposit);
            Console.WriteLine(s.ToString());
            Console.WriteLine("Amount u want to withdraw");
            withdraw = double.Parse(Console.ReadLine());
           s.WithDrawAmount(withdraw);
           Console.WriteLine( s.ToString());
            Console.WriteLine("");
            Console.WriteLine("FOR SallaryAccount");
            Console.WriteLine("Amount u wanted to deposit");
            deposit = double.Parse(Console.ReadLine());
            sal.AmountDeposited(deposit);
            Console.WriteLine(sal.ToString());
            Console.WriteLine("Amount u want to withdraw");
            withdraw = double.Parse(Console.ReadLine());
            sal.WithDrawAmount(withdraw);
            Console.WriteLine(sal.ToString());
            Console.WriteLine("");
            Console.WriteLine("FOR SavingAccount");
            Console.WriteLine("Amount u wanted to deposit");
            deposit = double.Parse(Console.ReadLine());
            save.AmountDeposited(deposit);
           Console.WriteLine(save.ToString());
            Console.WriteLine("Amount u want to withdraw");
            withdraw = double.Parse(Console.ReadLine());
            save.WithDrawAmount(withdraw);
            Console.WriteLine( save.ToString());
            Console.ReadKey();

        }
    }
}
