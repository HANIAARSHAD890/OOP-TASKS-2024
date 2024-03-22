using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesment
{
    internal class Student
    {
        protected string Name;
        protected string Session;
        protected bool IsDayScholar;
        protected float EntrytestMarks;
        protected float HSMarks;
     public Student(string name, string session, bool isDayScholar, float entrytestMarks, float hSMarks)
        {
            Name = name;
            Session = session;
            IsDayScholar = isDayScholar;
            EntrytestMarks = entrytestMarks;
            HSMarks = hSMarks;
        }
        public double CalculateMerit()
        {
            double merit = EntrytestMarks * 0.6 + HSMarks * 0.4; 
            return merit;
        }

    }
}
