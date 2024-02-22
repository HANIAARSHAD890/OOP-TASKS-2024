using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace buisness1
{
    public class fooditem
    {
        public List<string> breakfast;

        public List<string> days;

        public List<string> dinner;
        public string day;
        public string dayForFooditem;
        public string Fooditem;



    public fooditem()
        { 

   
                 breakfast = new List<string>
        {
            "Omelette",         // اوملیٹ
            "Paratha",          // پراٹھا
            "Halwa Puri",       // حلوہ پوری
            "Chai",             // چائے
            "Nihari",           // نہاری
            "Samosa",           // سموسہ
            "Alu Paratha"      // آلو پراٹھا
        };

                // List of dinner items in Urdu language (typed in English)
                 dinner = new List<string>
        {
            "Biryani",          // بریانی
            "Karahi",           // کڑاہی
            "Kofta",            // کوفتہ
            "Seekh Kabab",      // سیخ کباب
            "Pulao",            // پلاؤ
            "Haleem",           // ہلیم
            "Chapli Kabab"      // چپلی کباب
        };

                // List of days
               days = new List<string>
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

   

      }
        public void retrieveAll()
        {

            Console.WriteLine("\t\tBREAKFAST");
            Console.WriteLine("\t\t\t\t\t\t\t*");
            Console.WriteLine("DAYS\t\t\t\t\t\t\tFOOD");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{days[i]} {new string('\t', 6)} {breakfast[i]} {new string('\t', 6)}");

            }
            Console.WriteLine("\t\tDINNER");
            Console.WriteLine("\t\t\t\t\t\t\t*");
            Console.WriteLine("DAYS\t\t\t\t\t\t\tFOOD");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{days[i]} {new string('\t', 6)} {dinner[i]} {new string('\t', 6)}");

            }

        }
        public string retrievespecific()
        {

            int index = days.FindIndex(item => item == day);
            return breakfast[index];
          
        }
        public string createfooditem()
        {

            int index =days.FindIndex(item => item == dayForFooditem);
            breakfast.Insert(index,Fooditem);
            return $"{breakfast[index]} is added at the day {dayForFooditem}";

        }
        public string deletefooditem()
        {

            int index = days.FindIndex(item => item == dayForFooditem);
            string deletedfood = breakfast[index];
            breakfast.Insert(index," --- ");
            return $"{deletedfood} is deleted at the day {dayForFooditem}";

        }

    }

}


