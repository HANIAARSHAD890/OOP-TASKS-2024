using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSystem
{
    internal class Program
    {
         static void Main(string[] args)
        {


            //-----declaraing objects of the class

            student student1 = new student("",0,0,0,0);
            student student2 = new student("",0,0,0,0);
            student student3 = new student("",0,0,0,0);
            student student4 = new student("",0,0,0,0);
            student student5 = new student("",0,0,0,0);
            student student6 = new student("",0,0,0,0);
            student student7 = new student("",0,0,0,0);
            student student8 = new student("",0,0,0,0);
            student student9 = new student("",0,0,0,0);
            student student10 = new student("", 0, 0, 0, 0);
           

            // declaring list ofobjects

            List<student> studentList = new List<student>
            { student1,student2,student3,student4,student5,student6,student7,student8,student9,student10 };

            int studentcount = 0;
            //file names 
             Console.WriteLine("POS SYSTEM");
              Console.WriteLine("ADD student");
              addstudent(studentList, ref studentcount);
              Console.WriteLine("ADD student");
              addstudent(studentList, ref studentcount);
              Console.WriteLine("SHOW STUDENT");

              for (int i = 0; i < studentcount; i++)
              {
                 studentList[i].showstudents();
              }
            Console.WriteLine("AGGREGATE FOR ALL ");

            for (int i = 0; i < studentcount; i++)
              {
                  Console.WriteLine(studentList[i].calaggregate());
              }
            Console.WriteLine("TOP3STUDENTS ");

            for (int i = 0; i < studentcount; i++)
            {
               studentList[i].topstudents();
            }
            Console.ReadKey();  
        }
        static student addstudent(List<student> studentList,ref int studentcount)
        {
          
            Console.WriteLine("WRITE NAME : ");
            studentList[studentcount].name=Console.ReadLine();
            Console.WriteLine("WRITE FSC MARKS");
            studentList[studentcount].fsc = double.Parse(Console.ReadLine());
            Console.WriteLine("WRITE MATRIC MARKS");
            studentList[studentcount].matric= double.Parse(Console.ReadLine());
            Console.WriteLine("WRITE ECAT MARKS:");
            studentList[studentcount].ecat = double.Parse(Console.ReadLine());


            studentcount++;
            return studentList[studentcount];   
        }
    }
}
