using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Selfassessment;
namespace Teleassessment
{
    internal class Student
    {
        public int ID;
        public string Name;
        public int Age;
        public double Fscmarks;
        public double Ecatmarks;
        public double Merit;
        public List<DegProg> Preferences;
        public List<Subject> Regsubject;
        public DegProg registerDegree;

        public Student(string name, int age, double fscmarks, double ecatmarks)
        {
            this.Name = name;
            this.Age = age;
            this.Fscmarks = fscmarks;
            this.Ecatmarks = ecatmarks;
            registerDegree = new DegProg("",0,0,0) ;
            Preferences =new List<DegProg>();
            Regsubject = new List<Subject>();
        }
        public int GetID()
        {
            return ID;
        }
        public void SetID(int id)
        {
            ID = id;

        }
        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;

        }
        public double GetFscmarks()
        {
            return Fscmarks;
        }
        public double GetEcatMarks()
        {
            return Ecatmarks;
        }
        public double GetMerit()
        {
            return Merit;
        }
        public void SetName(string name )
        {
          Name=name;
        }
        public void SetAge(int age)
        {
            Age=age;

        }
        public void SetFscmarks(double fscMarks)
        {
            Fscmarks=fscMarks;
        }
        public void SetEcatMarks(double ecatMarks)
        {
           Ecatmarks=ecatMarks;
        }
        public void  SetMerit(double merit)
        {
          Merit=merit;
        }
        public double MeritCal()
        {
            double merit = (Ecatmarks * 40 /  400) + (Fscmarks * 60 / 1100);
            Merit = merit;
            return merit; 
        }
        public void AddPreferences(List<DegProg> preferences)
        {
            Preferences = preferences;
       
        }
        public static int SelectStudent()
        {
            Console.WriteLine("Enter student no ");
            int index = int.Parse(Console.ReadLine());
            return index;
        }
        public bool IsStudentMeritHigh(DegProg d)
        {
            Merit=MeritCal();
            if (Merit >= d.Merit)
            {
                return true;
            }
            return false;
        }
        public DegProg StudentDegree()
        {
            for (int i = 0; i < Preferences.Count; i++)
            {
                if (IsStudentMeritHigh(Preferences[i]))
                { 
                    return Preferences[i];
                }
            }
            return null;

           
        }
        public bool IsAdmissioned()
        {
            if (StudentDegree() != null)
            {
                return true;
            }
            return false;
        }

        public string Admissioned()
        {
            if (IsAdmissioned())
            { return " ADMISSIONED "; }
            return "NOT ADMISSIONED";
        }
        public void RegisterDegree(DegProg D)
        {
            registerDegree.Merit = D.Merit;
            registerDegree.Degtitle= D.Degtitle;
            registerDegree.Seats = D.Seats;  
            registerDegree.Durationdeg= D.Durationdeg;
        }
        public List<string>NamesOFSubject()
        {
            List<string>subjectnames=new List<string>();    
            Console.WriteLine("How many subjects you wanted to register");
            int no = int.Parse(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                subjectnames.Add(Console.ReadLine());
            }
            return subjectnames;
        }
        public DegProg ReturnDegree()
        {
         
                for (int i = 0; i < DegProgCRUD.ListOfDeg.Count; i++)
                {
                    if (DegProgCRUD.ListOfDeg[i].Degtitle == registerDegree.Degtitle)
                    {
                        return DegProgCRUD.ListOfDeg[i];
                    }
       
                }
            return null;
           
           
        }
        public void RegisterSubjects(List<string>SubjectNames,DegProg D)
        {
            for (int j = 0; j < SubjectNames.Count; j++)
            {

                for (int i = 0; i < D.subjectsForDeg.Count; i++)
                {
                    if (SubjectNames[j] == D.subjectsForDeg[i].subtype)
                    {
                        registerDegree.subjectsForDeg.Add(D.subjectsForDeg[i]); 
                    }
                }
            }
           
        }
        public float CalculateFee(DegProg D)
        {
            float fee = 0;
            for (int i = 0; i < D.subjectsForDeg.Count; i++)
            {
                fee = fee + D.subjectsForDeg[i].generatefees;  
            }
            return fee;
        }

    }
}
