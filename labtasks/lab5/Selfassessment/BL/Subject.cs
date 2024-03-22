using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teleassessment;

namespace Selfassessment
{
    internal class Subject
    {
        public int subcode;
        public int credithours;
        public string subtype;
        public int generatefees;
        public int DegID;
      
   
   public Subject(string SubjectTitle )
            {
            subtype = SubjectTitle;
             }
        public Subject(string subjecttitle, int creditHours, int fees)
        {
       
            subtype = subjecttitle;
            credithours = creditHours;      
            generatefees = fees;      
        }
   /* public Subject(string subcode, int credithours, string subtype, int generatefees)
        {
            this.subcode = subcode;
            this.credithours = credithours;
            this.subtype = subtype;
            this.generatefees = generatefees;
 
       }*/
        public float  Calculatefee(DegProg d)
        {
            float totalfee = 0;
            for (int x = 0; x < d.subjectsForDeg.Count; x++)
            {
               totalfee = totalfee + d.subjectsForDeg[x].generatefees;

            }
            return totalfee;
        }
       
    }
}

