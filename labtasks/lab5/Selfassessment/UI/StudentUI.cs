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
        public static Student inputforStudent(DegProgCRUD obj, StudentCRUD objs)
        {
            Console.WriteLine("Enter name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fscMarks: ");
            double Fscmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecatMarks: ");
            double Ecatmarks = double.Parse(Console.ReadLine());
            DegProgUI.ViewDegPrograms();
            List<DegProg> Preferences = DegProgUI.InputForPreferences();
            Student objstu = new Student(Name, Age, Fscmarks, Ecatmarks, Preferences);
            return objstu;
        }

        public static void DisplayStudents()
        {
            for (int x = 0; x < StudentCRUD.ListofStudents.Count; x++)
            {
                Console.WriteLine($"{StudentCRUD.ListofStudents[x].Name}/t/t/t/{StudentCRUD.ListofStudents[x].Ecatmarks}/t/t/t/{StudentCRUD.ListofStudents[x].Fscmarks}/t/t/t/{StudentCRUD.ListofStudents[x].Fscmarks}");
            }

        }
        public static void viewstudentDeg(string Degname)
        {

            for (int x = 0; x < StudentCRUD.ListofStudents.Count; x++)
            {
                if (StudentCRUD.ListofStudents[x].registerDegree != null)
                {
                    if (Degname == StudentCRUD.ListofStudents[x].registerDegree.degtitle)
                    {
                        Console.WriteLine($"{StudentCRUD.ListofStudents[x].Name} has got admissioned in this degree{StudentCRUD.ListofStudents[x].registerDegree}");
                    }


                }
            }
        }
        
           

        }
    
}