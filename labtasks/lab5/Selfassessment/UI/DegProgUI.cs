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
                if (DegreeName == DegProgCRUD.ListOfDeg[x].degtitle)
                Preferences.Add(DegProgCRUD.ListOfDeg[x]);
            }
            return Preferences;
        }

        public static void ViewDegPrograms()
        {

            foreach (DegProg deg in DegProgCRUD.ListOfDeg)
            {
                Console.WriteLine(deg.degtitle);
            }
        }
        public static DegProg InputForDegprog(DegProgCRUD obj )
        {
          
                Console.WriteLine("ENTER DEGTITLE:");
                string Degtitle = (Console.ReadLine());
                Console.WriteLine("ENTER DEGDURATION:");
                float Degduration = float.Parse(Console.ReadLine());
                Console.WriteLine("ENTER DEGSEATS:");
                int Degseats = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER THE SUBJECTS NO IN THE DEGREEPROGRAM:");
                int Subno = int.Parse(Console.ReadLine());
        
                for (int i = 0; i < Subno; i++)
                {
                Subject s =  SubjectUI.Takeinputforsubject();
                obj.subjectsForDeg.Add(s);
                }
            DegProg objp = new DegProg(Degtitle, Degduration, Degseats, obj);
            return objp;
        }
        public static DegProg viewStudentsForSpecificProg()
        {
            Console.WriteLine("Enter degname ");
             string degName = Console.ReadLine();
            for (int i = 0; i < DegProgCRUD.ListOfDeg.Count; i++)
            {
                if (degName == DegProgCRUD.ListOfDeg[i].degtitle)
                {
                    return DegProgCRUD.ListOfDeg[i];
                }

            }
            return null;


        }
    }
}
