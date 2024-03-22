using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class StudentUI
    {
        public static Student InputforStudent()
        {
            Console.WriteLine("Enter name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fscMarks: ");
            double Fscmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecatMarks: ");
            double Ecatmarks = double.Parse(Console.ReadLine());

            Student objstu = new Student(Name, Age, Fscmarks, Ecatmarks);
            return objstu;
        }

      
        public static void ViewstudentDeg(string Degname)
        {

            for (int x = 0; x < StudentCRUD.ListofStudents.Count; x++)
            {
                if (StudentCRUD.ListofStudents[x].registerDegree != null)
                {
                    if (Degname == StudentCRUD.ListofStudents[x].registerDegree.Degtitle)
                    {
                        Console.WriteLine($"{StudentCRUD.ListofStudents[x].Name} has got admissioned in this degree{StudentCRUD.ListofStudents[x].registerDegree}");
                    }


                }
            }
        }
        public static int StudentID()
        
        {
            Console.WriteLine("Enter the ID for the student");
            int ID =int.Parse(Console.ReadLine());
            return ID;
        }
       


        }
    
}