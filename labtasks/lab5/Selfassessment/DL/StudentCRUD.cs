using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class StudentCRUD
    {
        public static List<Student> ListofStudents = new List<Student>();
        public static void displayStudents(DegProg d)

        {
            for (int x = 0; x < ListofStudents.Count; x++)
            {
                if (ListofStudents[x].registerDegree.degtitle == d.degtitle)
            {
                    Console.WriteLine(ListofStudents[x].Name);
            }
        }
          
    }
}
