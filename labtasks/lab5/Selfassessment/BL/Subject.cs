using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleassessment;

namespace Selfassessment
{
    internal class Subject
    {
        public string subcode;
        public int credithours;
        public string subtype;
        public int generatefees;
   
   
    public Subject(string subcode, int credithours, string subtype, int generatefees)
        {
            this.subcode = subcode;
            this.credithours = credithours;
            this.subtype = subtype;
            this.generatefees = generatefees;
 
       }
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

