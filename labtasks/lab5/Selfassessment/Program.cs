using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment; 

namespace Teleassessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// driver prog//////
            DegProgCRUD obj = new DegProgCRUD();
            StudentCRUD objs = new StudentCRUD();
            DegProg objd = new DegProg("T", 0,0,obj);
            Subject sub = new Subject("123", 12, "Literature", 34);
            List<DegProg> d = new List<DegProg>();
            Student s = new Student("",0,0,0,d);

            int option = 0;

            while (option != 8)
            {
                ConsoleUtilityUI.DisplayMenu();
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Student s = StudentUI.inputforStudent(obj, objs);
                    StudentCRUD.ListofStudents.Add(s);


                }
                if (option == 2)
                {
                    DegProg d = DegProgUI.InputForDegprog(obj);
                    DegProgCRUD.ListOfDeg.Add(d);

                }
                if (option == 3)
                {
                    for (int i = 0; i < StudentCRUD.ListofStudents.Count; i++)
                    {
                        double merit = StudentCRUD.ListofStudents[i].MeritCal(StudentCRUD.ListofStudents[i]);
                        if (merit >= 70)
                        {
                            Console.WriteLine($"{StudentCRUD.ListofStudents[i].Name} got admissioned with merit {StudentCRUD.ListofStudents[i].Merit}");
                        }
                        else
                        {
                            Console.WriteLine($"{StudentCRUD.ListofStudents[i].Name} did not get admission with merit {StudentCRUD.ListofStudents[i].Merit}");

                        }


                    }
                }
                if (option == 4)
                {
                    StudentUI.DisplayStudents();
                }

                if (option == 5)
                {
                    DegProg d = DegProgUI.viewStudentsForSpecificProg();
                    StudentCRUD.displayStudents(d);
                }
                if (option == 6)
                {
                    
                }
                if (option == 7)
                {
                    for (int x = 0; x < StudentCRUD.ListofStudents.Count; x++)
                    {
                        DegProg objdeg=DegProg.GetdegProgObj(StudentCRUD.ListofStudents[x]);
                        List<Subject> sub= new List<Subject>();
                        sub = objdeg.getSubjectsForDeg(objdeg);
                    /* 
                        float fee = sub.Calculatefee(objdeg)*/
                        SubjectUI.Displayfee(objdeg, fee, StudentCRUD.ListofStudents[x]);

                    }
                }
                Console.ReadKey();
                Console.Clear();
                option = -1;
            }
        }
       

        }
    }
