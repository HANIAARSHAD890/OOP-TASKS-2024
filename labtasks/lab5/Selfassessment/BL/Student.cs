using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;
namespace Teleassessment
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double Fscmarks;
        public double Ecatmarks;
        public double Merit;
        public List<DegProg> Preferences;
        public List<Subject> Regsubject;
        public DegProg registerDegree;

        public Student(string name, int age, double fscmarks, double ecatmarks, List<DegProg> preferences)
        {
            this.Name = name;
            this.Age = age;
            this.Fscmarks = fscmarks;
            this.Ecatmarks = ecatmarks;
            this.Preferences = preferences;
            Regsubject = new List<Subject>();
  
    }
        public double MeritCal(Student s)
        {
            double merit = (s.Ecatmarks * 40 / 100) + (s.Fscmarks * 60 / 100);
            s.Merit = merit;
            return merit; 
        }
    }
}
