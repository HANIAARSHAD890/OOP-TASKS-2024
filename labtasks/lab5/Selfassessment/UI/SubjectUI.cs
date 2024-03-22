using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class SubjectUI
    {
    
            public static Subject Inputsubject( )
            {
            Console.WriteLine("Enter credithours:");
            int Credithours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subType:");
            string Subtype = Console.ReadLine();
            Console.WriteLine("Enter fees for the subject:");
            int Generatefees = int.Parse(Console.ReadLine());
            Subject objs = new Subject(Subtype,Credithours,Generatefees);
                return objs;
  
            }
        public static int TakeInputForsubjectNO()
        { 
            Console.WriteLine("how many subjects you want to enter in this deg program");
            int no=int.Parse(Console.ReadLine());
        
        return no;    
        }
        public static void DisplaySubjects(List<Subject> RegisterSubjects)
        {
            Console.WriteLine("Subjects Registered");
            for (int i = 0; i < RegisterSubjects.Count; i++)
            {
                Console.WriteLine($"SubjectID: {RegisterSubjects[i].subcode}     SubjectType: {RegisterSubjects[i].subtype}");  
            }

        }
        public static int TakeInputForSubjectsRegistered()
        {
            Console.WriteLine("how many subjects you want to enter in this deg program");
            int SubjectNo = int.Parse(Console.ReadLine());
            return SubjectNo;
           
        }
        public static Subject TakeInputForSubjectSQL()

        {
            Console.WriteLine("Enter subType:");
            string Subtype = Console.ReadLine();
            Subject s = new Subject(Subtype);
            return s;
        }
        public static void DisplayAllSubjects(List<Subject>AllSubjects )
        {
            for (int i = 0; i < AllSubjects.Count; i++)
            {
                Console.WriteLine($"degreeID: {AllSubjects[i].DegID}");
                Console.WriteLine($"SubjectID:{AllSubjects[i].subcode}\tSubjectType:{AllSubjects[i].subtype}\tCreditHours:{AllSubjects[i].credithours}\tFee: {AllSubjects[i].generatefees}");
            }
            

            }
        }
    }

