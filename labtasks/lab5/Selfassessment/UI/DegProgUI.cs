using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class DegProgUI
    {
        public static List<DegProg> InputForPreferences()
        {
            Console.WriteLine("Enter no of  preferences: ");
            int subNO = int.Parse(Console.ReadLine());
            List<DegProg> Preferences = new List<DegProg>();
            for (int x = 0; x < subNO; x++)
            {

                string DegreeName = (Console.ReadLine());
                if (DegreeName == DegProgCRUD.ListOfDeg[x].Degtitle)
                Preferences.Add(DegProgCRUD.ListOfDeg[x]);
            }
            return Preferences;
        }

     
        public static DegProg InputForDegprog()
        {
            List<Subject> subjectsForDeg = new List<Subject>();
                Console.WriteLine("ENTER DEGTITLE:");
                string Degtitle = (Console.ReadLine());
                Console.WriteLine("ENTER DEGDURATION:");
                int  Degduration = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER DEGSEATS:");
                int Degseats = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER MERIT FOR DEGREE:");
           double Merit = double.Parse(Console.ReadLine());
            DegProg objp = new DegProg(Degtitle, Degduration, Degseats, Merit);
            return objp;
        }
        public static DegProg viewStudentsForSpecificProg()
        {
            Console.WriteLine("Enter degname ");
             string degName = Console.ReadLine();
            for (int i = 0; i < DegProgCRUD.ListOfDeg.Count; i++)
            {
                if (degName == DegProgCRUD.ListOfDeg[i].Degtitle)
                {
                    return DegProgCRUD.ListOfDeg[i];
                }

            }
            return null;


        }
        public static int DegreeID()

        { 
            Console.WriteLine("Enter the ID for the Degree");
            int ID = int.Parse(Console.ReadLine());
            return ID;
        }

        public static void DisplayAllDegrees(List<DegProg> AllDegrees)
        
        {
            Console.WriteLine("ALL DEGREES DISPLAY ");
         

                for (int i = 0; i < AllDegrees.Count; i++)
            {
                
                    Console.WriteLine($"DegreeID: {AllDegrees[i].DegID} ");
                    Console.WriteLine($"DegreeTitle: {AllDegrees[i].Degtitle} ");
                    Console.WriteLine($"Duration: {AllDegrees[i].Durationdeg} ");
                    Console.WriteLine($"DegreeSeats: {AllDegrees[i].Seats} ");
                    Console.WriteLine($"DegreeMerit: {AllDegrees[i].Merit} ");
                    List<Subject>Subjects= DegProgCRUD.GetAllSubjects(AllDegrees[i].DegID);
                    SubjectUI.DisplayAllSubjects(Subjects);
              



            }

        }
        public static void DisplayDegreeInfo(DegProg s2)
        {
            Console.WriteLine($"DegreeTitle: {s2.Degtitle} ");
            Console.WriteLine($"Duration: {s2.Durationdeg} ");
            Console.WriteLine($"DegreeSeats: {s2.Seats} ");
            Console.WriteLine($"DegreeMerit: {s2.Merit} ");

        }
        public static void DisplaySubjects(DegProg D)
        {
            for (int i = 0; i < D.subjectsForDeg.Count; i++)
            {
                Console.WriteLine($"{D.subjectsForDeg[i].subtype}");
            }

        }
        public static void ViewDegreeDetails(DegProg d)
        {


            Console.WriteLine("Degree Title: " + d.Degtitle);
            Console.WriteLine("Duration: " + d.Durationdeg + " years");
            Console.WriteLine("Available Seats: " + d.Seats);
            Console.WriteLine("Merit: " + d.Merit);
            Console.WriteLine("Subjects:");

            foreach (var subject in d.subjectsForDeg)
            {
                Console.WriteLine("- " + subject.subtype + " (" + subject.subcode + ")");
            }
        }


    }
}
