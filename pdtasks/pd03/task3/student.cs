using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMSystem
{
    internal class student
    {
        List<KeyValuePair<double, string>> keyValueList = new List<KeyValuePair<double, string>>();
        public string name;
        public double fsc;
        public double matric;
        public double ecat;
        public double aggregatecal;
        int studentcount = 0;

        public student(string name1, double fsc1, double matric1, double ecat1, double aggregate1)
        {
            this.name = name1;
            this.fsc = fsc1;
            this.matric = matric1;
            this.ecat = ecat1;
            this.aggregatecal = aggregate1;


            studentcount++;
        }
        public void showstudents()
        {
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine(name);
            }
            

        }
        public double calaggregate()
        {

            aggregatecal = ((fsc / 1100 * 30.00)+ (matric / 1100 * 40.00) * (ecat / 400 * 30.00));
            keyValueList.Add(new KeyValuePair<double, string>(aggregatecal, name));
            return aggregatecal;
        }

        public void topstudents()
        {
          

            // Sorting the dictionary by keys
            var sortedByKey = keyValueList.OrderBy(pair => pair.Key);

            // Displaying the sorted key-value pairs by keys
            Console.WriteLine("Sorted key-value pairs by keys:");
            foreach (var pair in sortedByKey)
            {
                Console.WriteLine($"AGGREGATE: {pair.Key}, : {pair.Value}");
            }
        }
    }
}
