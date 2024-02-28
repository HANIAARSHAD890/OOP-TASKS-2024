using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Routine
    {
        public string Time;
        public List<Exercise> ListofExercise;
        public static List<Routine> ListOfRoutines= new List<Routine>();
          
    public Routine(string time )
    {
            Time = time;z
        ListofExercise=new List<Exercise>();
    }
        public List<Exercise> Getlist()
        { 
        return ListofExercise;
        }
        public void  Set(string time)
        {
            Time= time;
         
        }
        public string  Gettimings()
        {
            return Time;
        }
    }
}
