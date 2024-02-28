using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selfassessment;

namespace Teleassessment
{
    internal class DegProg
    {

        public string degtitle;
        public float durationdeg;
        public int seats;
        public List<Subject> subjectsForDeg;
        public DegProg(string degtitle, float dutrationdeg, int seats, DegProgCRUD obj)
        {

            this.degtitle = degtitle;
            this.durationdeg = dutrationdeg;
            this.seats = seats;
            subjectsForDeg= new List<Subject> ();   

        }
   
        public static DegProg GetdegProgObj(Student s)
        { 
                return s.registerDegree;
            
        }
        public List<Subject> getSubjectsForDeg(DegProg d ) 
        {
            return d.subjectsForDeg;
        }    
}
}
