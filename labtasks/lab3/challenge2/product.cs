using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSystem
{
    internal class product
    {
        public int ID;
        public string name;
        public int price;  
        public string Category;
        public string  BrandName;
        public string country;
        public int productcount;

        public product(int ID1,string name1, int price1, string  category1 , string brandname1,string country1)
        {

            ID = ID1;
           name = name1;
           price = price1;
           Category = category1;
            BrandName = brandname1;
            country = country1;
            productcount++;
        }
        public void showstudents()
        { 
            for (int i =0;i<productcount;i++)
            {
                Console.WriteLine(ID);
                Console.WriteLine(name);
                Console.WriteLine(price);
                Console.WriteLine(Category);
                Console.WriteLine(BrandName);
                Console.WriteLine(country);

                

            }

        }
        public int totalprice()
        {
            int totalprice;
            totalprice = 0;
            for (int i =0;i<productcount;i++)
            {
                totalprice = totalprice + price;   
            }
           
            return totalprice;
        }
}

}
