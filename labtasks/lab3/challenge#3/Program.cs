using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables 
            // variables for sign up function
            string signupname = "";
            string signuprole = "";
            string signuppassword = "";
            string name1 = "";
            string password1 = "";


            //variable  for checking
            string option = "";
            bool option2 = false;
            //counter variables 
            int usercount = 0;
            int currentitration = 0;

            //-----declaraing objects of the class

            signup student1 = new signup("", "", "");
            signup student2 = new signup("", "", "");
            signup student3 = new signup("", "", "");
            signup student4 = new signup("", "", "");
            signup student5 = new signup("", "", "");
            signup student6 = new signup("", "", "");
            signup student7 = new signup("", "", "");
            signup student8 = new signup("", "", "");
            signup student9 = new signup("", "", "");
            signup student10 = new signup("", "", "");
            // declaring list ofobjects
            List<signup> peopleList = new List<signup>
            { student1,student2,student3,student4,student5,student6,student7,student8,student9,student10 };
            string[] checkarray = { "0", "1", "2", "3", "4", "5" };
           
          
            // file names 
            string filename1 = "signup.txt";
            // calling load functions 
        
            load(peopleList, ref usercount, filename1);

            // functions 

            while (option != "3")
            {
                option = menu(ref option);

                if (!validoption(option))
                {
                    messageoption();

                }
                Console.ReadKey();
                Console.Clear();
                //sign in 
                if (option == "1")
                {

                    peopleList[currentitration]. UISignin(ref name1, ref password1);
                    Console.ReadKey();
                    Console.Clear();
                    peopleList[currentitration].Signin(ref usercount, ref name1, ref signuprole, ref password1, ref currentitration, peopleList);

                    //sign in as customer


                    Console.ReadKey();
                    if (signuprole == "customer")
                    {
                        Console.WriteLine(" sign in as customer ");
                        Console.ReadKey();
                    }
                    else if (signuprole == "admin")
                    {
                        Console.WriteLine(" sign in as admin ");
                        Console.ReadKey();

                    }


                }
                else if (option == "2")
                {
                    Console.WriteLine(" sign up ");
                    Console.WriteLine("sign up header");
                    Console.ReadKey();
                    Console.Clear();
                    UISignup(ref signupname, ref signuppassword, ref signuprole);
                    option2 = Signup(ref usercount, ref signupname, ref signuprole, ref signuppassword, ref currentitration, peopleList);
                    if (option2)
                    {
                        Console.WriteLine("Valid");
                        store1signin(peopleList, filename1, ref usercount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static string menu(ref string option)
        {

            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Sign up");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your option: ");
            option = Console.ReadLine();
            return option;

        }

        static int UISignup(ref string signupname, ref string signuppassword, ref string signuprole)
        {

            Console.WriteLine("Name: ");
            signupname = Console.ReadLine();
            Console.WriteLine("User password: ");
            signuppassword = Console.ReadLine();
            Console.WriteLine("User role ('admin' or 'customer'): ");
            signuprole = Console.ReadLine();

            return 0;

        }

        static bool Signup(ref int usercount, ref string signupname, ref string signuprole, ref string signuppassword, ref int currentitration, List<signup> peopleList)
        {
            if (!checksignup(signupname, ref usercount, ref signuprole, ref signuppassword, peopleList))
            {
                peopleList[usercount] = new signup(signupname, signuppassword, signuprole);
                usercount++;
                Console.WriteLine("Press any key to continue:");

                return true;
            }
            else
            {
                Console.WriteLine("Press any key to continue:");
                return false;
            }
        }
       
        static bool checksignup(string signupname, ref int usercount, ref string signuprole, ref string signuppassword, List<signup> peopleList)
        {
            for (int k = 0; k < usercount; k++)
            {

                if (((peopleList[k].name == signupname) && (peopleList[k].role == signuprole) && (peopleList[k].password == signuppassword)))
                {

                    return true;

                }

            }

            return false;

        }

      


        static bool validoption(string option) // validation for main menu options
        {
            int check = 0;  // taking the ascii code of option 
            int countercheck = 0;   // for counting the characters,so that each character entered will be valid
            check = option[0];
            if ((check >= 49) && (check <= 51))
            {
                countercheck++;
            }

            if ((countercheck == 1))    // options are 1,2 and 3 
                return true;

            else
                return false;
        }
        ///////////////////////////////////////////////FUNCTIONS FOR VALIDATIONS ///////////////////////////////////////////////////////////////////////////////

        static string messageoption()
        {
            Console.WriteLine("You have entered an invalid option");
            return "";

        }


        /// ///////////////////////////////////////////////FUNCTIONS FOR LOAD AND STORE//////////////////////////////////////////////////////////////////////
      
        static void store1signin(List<signup> peopleList, string fileName, ref int usercount)
        {
            string path ="D:\\OOP labTasks\\lab3\\challenge#3\\bin\\Debug\\signup.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);

            for (int i = 0; i < usercount; i++)
            {
                fileVariable.WriteLine(peopleList[i].name + "," + peopleList[i].password + "," + peopleList[i].role);
            }
            fileVariable.Flush();
            fileVariable.Close();
        }

        static void load(List<signup> peopleList, ref int usercount, string filename1)

        {
            string path = "D:\\OOP labTasks\\lab3\\challenge#3\\bin\\Debug\\signup.txt";

            StreamReader fileVariable = new StreamReader(path);

            if (File.Exists(path))
            {
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record != "")
                    {
                        peopleList[usercount].name = getField(record, 1);
                        peopleList[usercount].password = getField(record, 2);
                        peopleList[usercount].role = getField(record, 3);
                        usercount = usercount + 1;
                    }




                }
                fileVariable.Close();


            }
            else
            {
                Console.WriteLine("file does not exists");
            }
        }

        static string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }

            return item;

        }
    }
}
