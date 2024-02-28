using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", "Electronics", 999.99f, 50, 10, 20);
            Product product2 = new Product("Headphones", "Electronics", 49.99f, 100, 20, 30);
            Product product3 = new Product("Book", "Stationery", 12.99f, 200, 50, 100);
            ProductCRUD.ListofProducts.Add(product1);
            ProductCRUD.ListofProducts.Add(product2);
            ProductCRUD.ListofProducts.Add(product3);

        


            Customer c1 = new Customer("user1", "pass1", "user1@example.com", "Address 1", "1234567890");
            Customer c2 = new Customer("user2", "pass2", "user2@example.com", "Address 2", "2345678901");
            Customer c3 = new Customer("user3", "pass3", "user3@example.com", "Address 3", "3456789012");
            Customer c4 = new Customer("user4", "pass4", "user4@example.com", "Address 4", "4567890123");
            Customer c5 = new Customer("user5", "pass5", "user5@example.com", "Address 5", "5678901234");
            CustomerCRUD.AddCustomer(c1);
            CustomerCRUD.AddCustomer(c2);
            CustomerCRUD.AddCustomer(c3);
            CustomerCRUD.AddCustomer(c4);
            CustomerCRUD.AddCustomer(c5);
            Admin a = new Admin("Hania","123");
            int Option=0;
            int option = 0;
            while (Option != 3)
            {
                ConsoleUtility.MainMenu();
                Option = int.Parse(Console.ReadLine());
                if (Option == 1)
                {
                    string role = "";
                    Console.WriteLine("SIGN IN MENU");
                    Console.WriteLine(role);
                    role = ConsoleUtility.InputForSignin();
                  
              
                    if (role == "Admin")
                    {
                        while (option != 7)
                        {
                            AdminUI.AdminMenu();
                            option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                Product p = ProductUI.inputforProduct();
                                ProductCRUD.ListofProducts.Add(p);


                            }

                            if (option == 2)
                            {

                                for (int i = 0; i < ProductCRUD.ListofProducts.Count; i++)
                                {
                                    ProductCRUD.retrieve(ProductCRUD.ListofProducts[i]);


                                }
                            }
                            if (option == 3)
                            {
                                Product p = ProductCRUD.highestPriceRetrieval();
                                ProductCRUD.retrieve(p);

                            }
                            if (option == 4)
                            {
                                for (int i = 0; i < ProductCRUD.ListofProducts.Count; i++)
                                {
                                    Console.WriteLine($"the ({ProductCRUD.ListofProducts[i].Name} has a  price after tax is {Product.taxcalculator(ProductCRUD.ListofProducts[i])}");
                                }
                            }

                            if (option == 5)
                            {
                                for (int i = 0; i < ProductCRUD.ListofProducts.Count; i++)
                                {
                                    Product p = Product.RetrieveProductsHaveMinthreshold(ProductCRUD.ListofProducts[i]);
                                    ProductUI.OrderProducts(p);
                                }
                            }
                            if (option == 6)
                            {
                                AdminCRUD.ViewProfile(a);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            option = -1;
                        }
                    }
                    else if (role == "Customer")
                    {
                        while (option!= 4)
                        {
                            CustomerUI.CustomerMenu();
                            option = int.Parse(Console.ReadLine());
                            if (option == 1)
                            {
                                for (int i = 0; i < ProductCRUD.ListofProducts.Count; i++)
                                {
                                    ProductCRUD.retrieve(ProductCRUD.ListofProducts[i]);
                                }
                            }
                            else if (option == 2)
                            {
                                Product p = ProductCRUD.highestPriceRetrieval();
                                ProductCRUD.retrieve(p);
                            }
                            else if (option == 3)
                            {
                                for (int i = 0; i < ProductCRUD.ListofProducts.Count; i++)
                                {
                                    Console.WriteLine($"the {ProductCRUD.ListofProducts[i].Name} has a  price after tax is {Product.taxcalculator(ProductCRUD.ListofProducts[i])}");
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            option = -1;
                        }
                        
                    }
                }
                if (Option == 2)
                {
                    Console.WriteLine("SIGN UP MENU");
                    Customer c = CustomerUI.InputForCustomer();
                    CustomerCRUD.AddCustomer(c);

                }
                Console.ReadKey();
                Console.Clear();
                Option = -1;


            }
        }
    }
}