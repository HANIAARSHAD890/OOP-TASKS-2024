using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class CustomerCRUD
    {
       public static List<Customer> ListofCustomer = new List<Customer>();
        public  List<Product>ListOfproducts= new List<Product>();
        public static void AddCustomer(Customer c)
        {
            ListofCustomer.Add (c);    
        }
        public  void AddProductToList(Product p )
        {
            ListOfproducts.Add(p);
        }
        public List<Product> Getlist()
        {
            return ListOfproducts;
        }
    }
}
