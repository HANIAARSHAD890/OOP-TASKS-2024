using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_4
{
    class Stats
    {
        public string Name ;
        public float Damage;
        public string Description;
        public float Penetration;
        public float Cost;
        public float heal;
        public Stats(string name, string description, float penetration,float cost)
        {
            Name = name;
            Description = description;
            Penetration = penetration;
            Cost = cost;
            heal = 100;


        }
        public  void statsinfo()
        {
            Console.WriteLine("skill");
            Console.WriteLine(Name);
        }
     
    }
}
