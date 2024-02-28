using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class ConsoleUtilityUI
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("UAMS SYSTEM");
            Console.WriteLine("1.ADD STUDENT");
            Console.WriteLine("2.ADD DEGPROGRAM");
            Console.WriteLine("3.GENERATE MERIT");
            Console.WriteLine("4.VIEW REG STUDENT");
            Console.WriteLine("5.VIEW STUDENT OF SPECIFIC PROG");
            Console.WriteLine("6.REG SUBJECTS FOR SPECIFIC STUDENT");
            Console.WriteLine("7.CALCULATE FEES FOR ALL REGISTERED STUDENTS ");
            Console.WriteLine("8.EXIT");

        }
    }
}
