using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////staff functionality
            Staff s = new Staff("PAEC ModelCollege", 5788, "hania", "R-9_Chashma");
            Student stu = new Student("Alishba", "R-5", "ComputerScience", 3, 437214);
           Console.WriteLine( s.ToStringStaff());
            Console.WriteLine("write SchoolName");
            string school=Console.ReadLine();
            s.SetSchool(school);
            Console.WriteLine("write name: ");
            string name = Console.ReadLine();
            s.SetName(name);
            Console.WriteLine(  s.ToStringStaff());
            Console.WriteLine("");  
            ///////studentFunctionality
            Console.WriteLine( stu.ToStringStudent());
            Console.WriteLine("Enter Program");
            string program = Console.ReadLine();
             stu.SetProgram(program);
           Console.WriteLine( stu.ToStringStudent());
            Console.ReadKey();  

        }
    }
}
