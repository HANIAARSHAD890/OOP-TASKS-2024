using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Selfassessment;

namespace Teleassessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///students
            Student student1 = new Student("John", 18, 1100, 400);
            /* Student student2 = new Student(2,"Alice", 19,1100, 350);
             Student student3 = new Student(3,"Bob", 20, 1050,340);
             Student student4 = new Student(4,"Emily", 18,1050, 240);
             Student student5 = new Student(5,"Michael", 19, 1020, 222);*/
            /* StudentCRUD.ListofStudents.Add(student1);
             StudentCRUD.ListofStudents.Add(student2);
             StudentCRUD.ListofStudents.Add(student3);
             StudentCRUD.ListofStudents.Add(student4);
             StudentCRUD.ListofStudents.Add(student5);*/
            ////subjects
            /* Subject subject1 = new Subject("MATH101", 4, "Mathematics", 1000);
             Subject subject2 = new Subject("PHYS102", 3, "Physics", 900);
             Subject subject3 = new Subject("COMP103", 3, "Computer Science", 950);
             Subject subject4 = new Subject("ENG101", 3, "English", 800);
             Subject subject5 = new Subject("CHEM101", 4, "Chemistry", 950);
             Subject subject6 = new Subject("BIO101", 4, "Biology", 900);
             Subject subject7 = new Subject("HIST101", 3, "History", 850);
             Subject subject8 = new Subject("ECON101", 3, "Economics", 900);
             Subject subject9 = new Subject("ART101", 2, "Art", 750);
             Subject subject10 = new Subject("STAT101", 3, "Statistics", 850);
             List<Subject>subjects1 = new List<Subject>();   
             subjects1.Add(subject1);    
             subjects1.Add(subject2);
             subjects1.Add(subject3);
             subjects1.Add(subject4);
             subjects1.Add(subject5);
             subjects1.Add(subject6);
             subjects1.Add(subject7);
             subjects1.Add(subject8);
             subjects1.Add(subject9);
             subjects1.Add(subject10);
             ///degprograms
             DegProg degProg1 = new DegProg("Bachelor of Science", 4.0f, 100, 80.5f);
             DegProg degProg2 = new DegProg("Bachelor of Arts", 3.5f, 80, 75.0f);
             DegProg degProg3 = new DegProg("Bachelor of Engineering", 4.5f, 120, 85.0f);
             DegProg degProg4 = new DegProg("Bachelor of Business Administration", 3.0f, 90, 78.0f);
             DegProg degProg5 = new DegProg("Bachelor of Medicine", 5.5f, 150, 90.0f);
             degProg1.subjectsForDeg = subjects1;
             degProg2.subjectsForDeg = subjects1;
             degProg3.subjectsForDeg = subjects1;
             degProg4.subjectsForDeg = subjects1;
             degProg5.subjectsForDeg = subjects1;
             DegProgCRUD.ListOfDeg.Add(degProg1);
             DegProgCRUD.ListOfDeg.Add(degProg2);
             DegProgCRUD.ListOfDeg.Add(degProg3);
             DegProgCRUD.ListOfDeg.Add(degProg4);
             DegProgCRUD.ListOfDeg.Add(degProg5);

             //// driver prog//////
             List<DegProg> preferences = new List<DegProg>();
             DegProgCRUD obj = new DegProgCRUD();
             Subject sub = new Subject("123", 12, "Literature", 34);
             List<DegProg> d = new List<DegProg>();
             List<Subject> subjects = new List<Subject>();
             List<string> subnames = new List<string>();
             /////sql query 
             */
           


            //// subjectsRegistration


            /*    List<Student> ListOfStudents = new List<Student>();*/
            /* Console.ReadKey();*/
            /*  StudentCRUD.AddStudent(student1);*/

            /*  Console.ReadKey();
           
              Console.WriteLine("enter the ID for which you want to to see the result");
              int ID = int.Parse(Console.ReadLine());
              Student s1 = StudentCRUD.GetStudent(ID);*/
            /*  Console.WriteLine(s.Name);*/

            int option = 0;
            /* StudentCRUD.DeleteStudent(1002);
             ListOfStudents = StudentCRUD.GetAllStudents();
             for (int i = 0; i < ListOfStudents.Count; i++)
             {
                 Console.WriteLine($"{ListOfStudents[i].Name}\t){ListOfStudents[i].ID}");
             }
             Console.ReadKey();*/

            /*   while (option != 8)
               {
                   ConsoleUtilityUI.DisplayMenu();
                   option = int.Parse(Console.ReadLine());
                   if (option == 1)
                   {
                       Student s = StudentUI.InputforStudent();
                       StudentCRUD.ListofStudents.Add(s);

                   }
                   if (option == 2)
                   {
                       Student s = StudentUI.InputforStudent();
                       StudentCRUD.UpdateStudent(s);
                       Console.WriteLine("Updatedrecord");
                       StudentCRUD.DisplayStudentInfo(s);

                       if (option == 3)
                       {
                           int Id1 = StudentUI.StudentID();
                           StudentCRUD.DeleteStudent(Id);
                           List<Student> Students = StudentCRUD.GetAllStudents();

                           StudentCRUD.DisplayAllStudentInfo(Students);
                       }
                       if (option == 4)
                       {
                           int Id2 = StudentUI.StudentID();
                           Student s2 = StudentCRUD.GetStudent(Id);
                           StudentCRUD.DisplayStudentInfo(s2);
                       }
                       if (option == 5)
                       {
                           int Id3 = StudentUI.StudentID();
                           List<Student> Students = StudentCRUD.GetAllStudents();
                           StudentCRUD.DisplayAllStudentInfo(Students);
                       }
                       if (option == 6)
                       {
                           int Id4 = StudentUI.StudentID();
                           List<Subject> Registersubjects = RegisterSubjectsCRUD.GetAllSubjects(Id);
                           SubjectUI.DisplaySubjects(Registersubjects);
                       }
                       if (option == 7)
                       {*/
            //////////register subjects
            /*  int Id1 = StudentUI.StudentID();
              int SubNO = SubjectUI.TakeInputForSubjectsRegistered();
              RegisterSubjectsCRUD.RegisterAllSubjects(SubNO, Id1);*/
            /* }
             if (option == 8)
             {
                 int DegreeID = DegProgUI.DegreeID();
                 List<Subject> AllSubjects = DegProgCRUD.GetAllSubjects(DegreeID);
                 SubjectUI.DisplayAllSubjects(AllSubjects);
             }

             if (option == 9)
             {
                 List<DegProg> AllDegrees = DegProgCRUD.GetAlldegrees();
                 DegProgUI.DisplayAllDegrees(AllDegrees);
             }*/
            /* if (option == 6)
 {
     StudentCRUD.DisplayStudents();
     int index = Student.SelectStudent();
     Student s = StudentCRUD.ReturnStudent(index);
     DegProgCRUD.ViewDegreePrograms();
     preferences = DegProgUI.InputForPreferences();
     s.AddPreferences(preferences);
 }*/
            /*  if (option == 7)
              {

                  DegProg deg = DegProgUI.InputForDegprog();
                  DegProgCRUD.ListOfDeg.Add(deg);

              }
              if (option == 8)
              {
                  DegProgCRUD.ViewDegreePrograms();
                  int indexD = DegProg.SelectDegree();
                  DegProg P = DegProgCRUD.ReturnDeg(indexD);
                  subjects = SubjectUI.TakeInputForsubject();
                  P.AddSubjects(subjects);
              }
              if (option == 9)
              {
                  StudentCRUD.DisplayStudents();
                  int index = Student.SelectStudent();
                  Student s = StudentCRUD.ReturnStudent(index);
                  Console.WriteLine("SEE the REGISTER DEGREE FOR THE STUDENT");
                  DegProg P = s.StudentDegree();

                  DegProgCRUD.ViewDegreeDetails(P);


              }
              if (option == 10)
              {
                  Console.WriteLine("Merit For All STudents ");
                  StudentCRUD.DisplayMerit();
              }
              if (option == 11)
              {

                  Console.WriteLine("ADMISSION STATUS FOR THE STUDENTS ");
                  StudentCRUD.AdmissionList();
              }
              if (option == 12)
              {
                  StudentCRUD.DisplayStudents();
                  int index = Student.SelectStudent();
                  Student s = StudentCRUD.ReturnStudent(index);
                  DegProg D = s.ReturnDegree();
                  DegProgCRUD.DisplaySubjects(D);
                  subnames = s.NamesOFSubject();
                  s.RegisterSubjects(subnames, D);

              }
              if (option == 13)
              {
                  Console.WriteLine("FEES FOR ALL STUDENTS");
                  StudentCRUD.DisplayFee();

              }
*/
            ///library at 7:58//
            ///Add degreeprogram
           /* DegProg deg = DegProgUI.InputForDegprog();
            DegProgCRUD.AddDegree(deg);
            ////retrieve
            int Id = DegProgUI.DegreeID();
            DegProg d = DegProgCRUD.GetDegree(Id);
            DegProgUI.DisplayDegreeInfo(d);
            ///retrieveveall
            List<DegProg> AllDegrees = DegProgCRUD.GetAlldegrees();
            DegProgUI.DisplayAllDegrees(AllDegrees);
            //update Degree
            //update DegreeDegProgUI
            int ID = DegProgUI.DegreeID();
            DegProg g = DegProgUI.InputForDegprog();
            DegProgCRUD.Updatedegree(g, ID);
            Console.WriteLine("Updatedrecord");
            DegProgUI.DisplayDegreeInfo(g);
            //deletedegree
            int Id1 = DegProgUI.DegreeID();
            DegProgCRUD.DeleteDegree(Id1);
            List<DegProg> Alldegrees = DegProgCRUD.GetAlldegrees();
            DegProgUI.DisplayAllDegrees(Alldegrees);
            //add subject
            int Id2 = DegProgUI.DegreeID();
            int Subno = SubjectUI.TakeInputForsubjectNO();
            DegProgCRUD.SubjectsForDeg(Subno, Id2);*/
            //retrieve DegreeInfowithsubjects
            List<DegProg> Degrees = DegProgCRUD.GetAlldegrees();
            DegProgUI.DisplayAllDegrees(Degrees);
            //delete degree

            Console.Clear();
                  option = -1;
                  /*    }
                  }
              */

        }



    }
        
}
  
