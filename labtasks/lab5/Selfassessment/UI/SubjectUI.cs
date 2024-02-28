using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class SubjectUI
    {
    
            public static Subject Takeinputforsubject( )
            {
                Console.WriteLine("Enter subcode:");
                string Subcode = (Console.ReadLine());
                Console.WriteLine("Enter credithours:");
                int Credithours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter subType:");
                string Subtype = Console.ReadLine();
                Console.WriteLine("Enter fees for the subject:");
                int Generatefees = int.Parse(Console.ReadLine());
                Subject objs = new Subject(Subcode, Credithours, Subtype, Generatefees);
                return objs;
  
            }
        public static void  Displayfee(DegProg d ,float fee,Student s  )
        {
            Console.WriteLine($"The fee for the {s.Name} having degree {d.degtitle} is {fee} ");
        }

    }
}
