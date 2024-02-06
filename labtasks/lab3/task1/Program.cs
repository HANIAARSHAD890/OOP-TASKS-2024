using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //-----declaraing objects of the class

            product PRODUCT1 = new product(0, "", 0, "", "", "");
            product PRODUCT2 = new product(0, "", 0, "", "", "");
            product PRODUCT3 = new product(0, "", 0, "", "", "");
            product PRODUCT4 = new product(0, "", 0, "", "", "");
            product PRODUCT5 = new product(0, "", 0, "", "", "");
            product PRODUCT6 = new product(0, "", 0, "", "", "");
            product PRODUCT7 = new product(0, "", 0, "", "", "");
            product PRODUCT8 = new product(0, "", 0, "", "", "");
            product PRODUCT9 = new product(0, "", 0, "", "", "");
            product PRODUCT10 = new product(0, "", 0, "", "", "");
            // declaring list ofobjects

            List<product> productList = new List<product>
            { PRODUCT1,PRODUCT2,PRODUCT3,PRODUCT4,PRODUCT5,PRODUCT6,PRODUCT7,PRODUCT8,PRODUCT9,PRODUCT10 };

            int productcount = 0;
            int Tprice = 0;

            // file names 
            Console.WriteLine("POS SYSTEM");
            Console.WriteLine("ADD PRODUCT");
            addproduct(productList, ref productcount);
            Console.WriteLine("ADD PRODUCT");
            addproduct(productList, ref productcount);
            for (int i = 0; i < productcount; i++)
            {
                productList[i].showstudents();
            }
            for (int i = 0; i < productcount; i++)
            {
              Tprice = Tprice +  productList[i].totalprice();
            }
            Console.WriteLine($"Totalprice : {Tprice}");
        }
        static product addproduct(List<product> productList,ref int productcount)
        {
            Console.WriteLine("WRITE ID ");
            productList[productcount].ID = int.Parse(Console.ReadLine());
            Console.WriteLine("WRITE NAME : ");
            productList[productcount].name=Console.ReadLine();
            Console.WriteLine("WRITE PRICE");
            productList[productcount].price = int.Parse(Console.ReadLine());
            Console.WriteLine("WRITE CATEGRORY");
            productList[productcount].Category =Console.ReadLine();
            Console.WriteLine("WRITE BRAND:");
            productList[productcount].BrandName =Console.ReadLine();
            Console.WriteLine("WRITE COUNTRY:");
            productList[productcount].country = Console.ReadLine();

            productcount++;
            return productList[productcount];   
        }
    }
}
