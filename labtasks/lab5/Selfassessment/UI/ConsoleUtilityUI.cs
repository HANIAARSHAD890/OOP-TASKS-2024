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
            Console.WriteLine("2.UPDATE STUDENT");
            Console.WriteLine("3.DELETE STUDENT");
            Console.WriteLine("4.RETRIEVE STUDENT");
            Console.WriteLine("5.RETRIEVE ALL STUDENTS");
            Console.WriteLine("6.RETRIEVE REGISTER SUBJECTS FOR GIVEN STUDENT ID");
            Console.WriteLine("7.REGISTER SUBJECTS FOR GIVEN STUDENT ID");
            Console.WriteLine();
            Console.WriteLine("8.DISPLAY ALL DEGREES");
            Console.WriteLine("9.DISPLAY ALL DEGREES");
            /* Console.WriteLine("6.ADD PREFERENCES");
             Console.WriteLine("7.ADD DegreeProgram");
             Console.WriteLine("8.ADD subjects in DegProg");
             Console.WriteLine("9.VIEW REGISTER DEGREE");
             Console.WriteLine("10.GENERATE MERIT OF ALL STUDENTS ");
             Console.WriteLine("11.SEE ADMISSION LIST");
             Console.WriteLine("12.REG SUBJECTS FOR DEGREEPROGRAM FOR A STUDENT");
             Console.WriteLine("13.CALCULATE FEES FOR ALL REGISTERED STUDENTS ");*/
            Console.WriteLine("14.EXIT");

        }
        public static bool IsRowAffected(int Affectedrows)
               {
            if (Affectedrows > 0)
                {
                return true;
            }
            return false;
        }
    }
}
