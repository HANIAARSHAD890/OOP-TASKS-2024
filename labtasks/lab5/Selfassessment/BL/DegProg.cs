using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class DegProg
    {
        public int DegID;
        public string Degtitle;
        public int Durationdeg;
        public int Seats;
        public double Merit;
        public List<Subject> subjectsForDeg;

      
        public DegProg(string degtitle, int durationdeg, int seats,double merit)
        {

            this.Degtitle = degtitle;
            this.Durationdeg = durationdeg;
            this.Seats = seats;
            this.Merit = merit;

        }

        public static DegProg GetdegProgObj(Student s)
        {
            return s.registerDegree;

        }
        public List<Subject> getSubjectsForDeg(DegProg d)
        {
            return d.subjectsForDeg;
        }
        public static int SelectDegree()
        {
            Console.WriteLine("Enter degree no for which you want to enter subjects");
            int index = int.Parse(Console.ReadLine());
            return index;
        }
        public void AddSubjects(List<Subject> subjects)
        {
         subjectsForDeg=subjects;
        }
        
    }
}
